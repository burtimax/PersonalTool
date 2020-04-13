using DiaryWinFormsNetFramework.HelpersConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryWinFormsNetFramework.Plugins.BaseForm
{
    public partial class BaseFormParent : Form
    {
        static BaseFormParent CurrentForm;
        static Dictionary<Type, InstanceKey> typeInstanceDict = new Dictionary<Type, InstanceKey>();
        static Dictionary<InstanceKey, BaseFormParent> _activeForms;
        public static Dictionary<InstanceKey, BaseFormParent> ActiveForms
        {
            get
            {
                if (_activeForms == null)
                {
                    _activeForms = new Dictionary<InstanceKey, BaseFormParent>();
                }
                return _activeForms;
            }
        }

        /// <summary>
        /// Send Data To All Active Forms
        /// </summary>
        /// <param name="data"></param>
        /// <param name="options"></param>
        private static void SendInternalData(object data, PerformOptions options)
        {
            foreach (var pairStringForm in ActiveForms)
            {
                if (options == PerformOptions.AsyncProcess)
                {
                    Task t = new Task(() => pairStringForm.Value.ReceiveData(data));
                }

                if (options == PerformOptions.SyncProcess)
                {
                    pairStringForm.Value.ReceiveData(data);
                }
            }
        }



        public InstanceKey Key;

        public BaseFormParent()
        {
            InitializeComponent();
            this.Key = InstanceKey.Generate(this);
            RegisterForm();
            PerformAction();
        }

        void RegisterForm()
        {
            if (!ActiveForms.ContainsKey(this.Key))
            {
                BaseFormParent.ActiveForms.Add(this.Key, this);
            }
        }

        protected virtual void ReceiveData(object data)
        {

        }

        protected virtual void PerformAction() { }


        protected void Invoke(BaseFormParent form, Action action)
        {
            form?.Invoke(action);
        }

        protected void DoAsync(Action action)
        {
            Task.Run(action);
        }

        public void SendData(object data, PerformOptions options)
        {
            BaseFormParent.SendInternalData(data, options);
        }




        public BaseFormParent InstanceOf<T>() where T : BaseFormParent
        {
            BaseFormParent result = null;
            var type = typeof(T);
            
            //if typeInstance dict contains form with specific type
            if (typeInstanceDict.ContainsKey(type))
            {
                //Get Instance Key by Type
                if(typeInstanceDict.TryGetValue(type, out var instanceKey))
                {
                    //Get Frm by InstanceKey
                    if (ActiveForms.ContainsKey(instanceKey))
                    {
                        result = ActiveForms[instanceKey];
                    }
                    else
                    {
                        throw new Exception("Форма отсутствует в списке активных форм, хотя тип и ключ формы зарегистрирован");
                    }
                }
                else
                {
                    throw new Exception("Ключ формы не зарегистрирован");
                }
            }
            //If typeInstance dict doesn't contains InstanceKey of Form with Specific Type
            //Create Element in typeInstance dict
            else
            {
                //Instance of Form
                var form = (T)Activator.CreateInstance(type);
                var instanceKey = InstanceKey.Generate(form);
                typeInstanceDict.Add(type, instanceKey);

                if (ActiveForms.ContainsKey(instanceKey))
                {
                    ActiveForms[instanceKey] = form;
                }
                else
                {
                    ActiveForms.Add(instanceKey, form);               
                }
                result = ActiveForms[instanceKey];
            }

            return result;
        }

        //Вызываем чтобы обновить данные (поля) в форме
        public virtual void RefreshData()
        {
        }

        public virtual void OnCloseForm()
        {
        }

    }


    public enum PerformOptions
    {
        SyncProcess,
        AsyncProcess
    }

    

}
