using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Popup;

namespace WindowsApplication1
{
    public class MyCustomBlobPopupFormViewInfo : CustomBlobPopupFormViewInfo
    {
        public MyCustomBlobPopupFormViewInfo(PopupBaseForm form)
            : base(form)
        {
            
        }
        private int GetMyCustomButtonHeight()
        {
            MyPopupContainerForm form = Form as MyPopupContainerForm;
            return form.CustomButtonSize.Height + 2* form.Indent;
        }


        protected override int CalcSizeBarContentHeight()
        {
            return Math.Max(base.CalcSizeBarContentHeight(), GetMyCustomButtonHeight());
        }


    }
}
