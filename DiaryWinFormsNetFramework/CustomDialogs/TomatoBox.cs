using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryWinFormsNetFramework.CustomDialogs
{
    public partial class TomatoBox : Form
    {
        

        public TomatoBox()
        {
            InitializeComponent();
            Init();
        }


        private void TomatoBox_Load(object sender, EventArgs e)
        {

        }

        private void Init()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            SetInitBoundsAndPosition();
            this.BackColor = Color.Gray;
            this.AllowTransparency = true;
            this.TransparencyKey = Color.Gray;
            
        }

        public static void ShowTomato()
        {
            TomatoBox box = new TomatoBox();


            using (Button acceptBtn = new Button())
            {
                acceptBtn.Click += delegate(object sender, EventArgs args)
                {

                    box.Close();
                    box.Dispose();
                };

                Button declineBtn = new Button();
                declineBtn.Click += delegate(object sender, EventArgs args) { box.Close(); };

                box.AcceptButton = acceptBtn;
                box.CancelButton = declineBtn;
                box.ShowInTaskbar = false;
                box.ShowDialog();
            }
        }

        private void SetInitBoundsAndPosition()
        {
            if (this.Width == 20 && this.Height == 80) return;

            this.Width = 400;
            this.Height = 7;

            this.Left = Convert.ToInt32(Math.Round(Screen.PrimaryScreen.Bounds.Width/2.0 - this.Width/2.0));
            this.Top = -5;
        }

        private void SetBroadenBoundsAndPosition()
        {
            if (this.Width == 300 && this.Height == 80) return;

            this.Width = 400;
            this.Height = 100;

            this.Left = Convert.ToInt32(Math.Round(Screen.PrimaryScreen.Bounds.Width / 2.0 - this.Width / 2.0));
            this.Top = -5;
        }

     
        private void TomatoBox_MouseLeave(object sender, EventArgs e)
        {
            SetInitBoundsAndPosition();
        }

        private void TomatoBox_MouseDown(object sender, MouseEventArgs e)
        {
            SetBroadenBoundsAndPosition();
        }
    }
}
