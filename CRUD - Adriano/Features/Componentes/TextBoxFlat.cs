using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Componentes
{
    [DefaultEvent("_TextChanged, _KeyDown, _KeyPress")]
    public partial class TextBoxFlat : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        public TextBoxFlat()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;
        public event KeyEventHandler _KeyDown;
        public event KeyPressEventHandler _KeyPress;

        [Category("Customizado")]
        public Color BorderColor
        { 
            get => borderColor;
            set 
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Customizado")]
        public int BorderSize
        { 
            get => borderSize; 
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Customizado")]
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Customizado")]
        public bool PasswordChar
        {
            get => textBox1.UseSystemPasswordChar;
            set => textBox1.UseSystemPasswordChar = value;
        }

        [Category("Customizado")]
        public bool Multiline
        {
            get => textBox1.Multiline;
            set => textBox1.Multiline = value;
        }

        [Category("Customizado")]
        public override Color BackColor
        { 
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("Customizado")]
        public override Color ForeColor
        { 
            get => base.ForeColor; 
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("Customizado")]
        public override Font Font 
        { 
            get => base.Font; 
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Customizado")]
        public string Texto
        { 
            get => textBox1.Text; 
            set => textBox1.Text = value; 
        }

        public int SelectionStart
        {
            get => textBox1.SelectionStart;
            set => textBox1.SelectionStart = value;
        }

        public int SelectionLength
        {
            get => textBox1.SelectionLength;
            set => textBox1.SelectionLength = value;
        }

        public int MaxLength
        {
            get => textBox1.MaxLength;
            set => textBox1.MaxLength = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (!textBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (_KeyDown != null)
                _KeyDown.Invoke(sender, e);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_KeyPress != null)
                _KeyPress.Invoke(sender, e);
        }
    }
}
