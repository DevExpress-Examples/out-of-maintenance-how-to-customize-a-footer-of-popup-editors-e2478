using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Popup;

namespace WindowsApplication1
{
    public class MyPopupContainerForm : PopupContainerForm
    {
        public SimpleButton myButton = new SimpleButton();
        public MyPopupContainerForm(PopupContainerEdit ownerEdit)
            : base(ownerEdit)
        {
            myButton.Text = "Test";
            Controls.Add(myButton);
            myButton.Click += new EventHandler(myButton_Click);
        }

        void myButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private int _Indent = 5;
        public int Indent
        {
            get { return _Indent; }
            set { _Indent = value; }
        }

        private Size _CustomButtonSize = new Size(30, 30);
        public Size CustomButtonSize
        {
            get { return _CustomButtonSize; }
            set { _CustomButtonSize = value; }
        }

        protected override PopupBaseFormViewInfo CreateViewInfo()
        {
            return new MyCustomBlobPopupFormViewInfo(this);
        }

        protected override PopupBaseFormPainter CreatePainter()
        {
            return new MyPopupBaseSizeableFormPainter();
        }

        protected override void UpdateControlPositionsCore()
        {
            base.UpdateControlPositionsCore();
            UpdateMyButton();
        }
        private void UpdateMyButton()
        {
            myButton.Location = new Point(ViewInfo.CloseButtonRect.Right + Indent, ViewInfo.SizeBarRect.Y + Indent);
            myButton.Width = CustomButtonSize.Width;
            myButton.Height = CustomButtonSize.Height;
        }

    }
}