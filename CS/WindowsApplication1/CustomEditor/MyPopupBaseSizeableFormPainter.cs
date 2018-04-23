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
    public class MyPopupBaseSizeableFormPainter : PopupBaseSizeableFormPainter
    {
        protected override void DrawContent(PopupFormGraphicsInfoArgs info)
        {
            base.DrawContent(info);
            MyCustomBlobPopupFormViewInfo vi = info.ViewInfo as MyCustomBlobPopupFormViewInfo;
            MyPopupContainerForm form = vi.Form as MyPopupContainerForm;
            Rectangle rect = form.myButton.Bounds;
            rect.X = rect.Right;
            rect.Width = vi.SizeGripRect.X - rect.X;
            info.Graphics.DrawString("MyPopupBaseSizeableFormPainter", info.ViewInfo.Appearance.GetFont(), Brushes.Red, rect);
        }

    }
}
