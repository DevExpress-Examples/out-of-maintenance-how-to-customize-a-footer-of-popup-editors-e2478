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
  
    public class MyPopupContainerEdit : PopupContainerEdit
    {
        static MyPopupContainerEdit()
        {
            RepositoryItemMyPopupContainerEdit.Register();
        }
     
        public override string EditorTypeName
        {
            get { return RepositoryItemMyPopupContainerEdit.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyPopupContainerEdit Properties
        {
            get { return base.Properties as RepositoryItemMyPopupContainerEdit; }
        }

        protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm()
        {
            return new MyPopupContainerForm(this);
        }
    }
}