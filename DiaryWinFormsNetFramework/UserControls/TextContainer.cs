using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryWinFormsNetFramework.HelpersConstants;

namespace DiaryWinFormsNetFramework.UserControls
{
    public partial class TextContainer : UserControl
    {
        private string DefaultTitle = "";
        Color _colorBorder = Constants.COLOR_LIGHT_GREY;
        public TextContainer()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            this.textBoxTitle.Text = this.DefaultTitle;
        }

        public TextContainer(string defaultTitle):this()
        {
            this.DefaultTitle = defaultTitle;           
        }

        [Description("Test text displayed in the textbox"), Category("Data")]
        public string Title
        {
            get { return textBoxTitle.Text; }
            set 
            {               
                textBoxTitle.Text = value;

                if (string.IsNullOrEmpty(textBoxTitle.Text) == true)
                {
                    textBoxTitle.Text = this.DefaultTitle;
                }
            }
        }

        [Description("Border color"), Category("Data")]
        public Color ColorBorder
        {
            get
            {
                return _colorBorder;
            }
            set
            {
                _colorBorder = value;
            }
        }

        public RichTextBox TextField
        {
            get
            {
                return this.rtbField;
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            //Set TitlePanel BackGround Color
            this.topPanel.BackColor = this.ColorBorder;
            this.textBoxTitle.BackColor = this.ColorBorder;
            //Set Border to Text Container
            using (Pen pen = new Pen(ColorBorder, 6))
            {
                Rectangle rect = this.mainPanel.ClientRectangle;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                //ControlPaint.DrawBorder(pen, this.mainPanel.ClientRectangle, Color.FromArgb(219, 219, 219), ButtonBorderStyle.Solid);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        public void Select()
        {
            this.rtbField.Select();
        }
    }
}
