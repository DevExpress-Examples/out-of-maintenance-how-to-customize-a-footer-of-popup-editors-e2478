using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;

namespace WindowsApplication1 {
	[UserRepositoryItem("Register")]
	public class RepositoryItemMyPopupContainerEdit : RepositoryItemPopupContainerEdit { 
		static RepositoryItemMyPopupContainerEdit() { 
			Register(); 
		}
		public RepositoryItemMyPopupContainerEdit() {}

        internal const string EditorName = "MyPopupContainerEdit";

		public static void Register() {
			EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyPopupContainerEdit), 
				typeof(RepositoryItemMyPopupContainerEdit), typeof(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo), 
				new DevExpress.XtraEditors.Drawing.ButtonEditPainter(), true, null));
		}
		public override string EditorTypeName { 
			get { return EditorName; } 
		}


	}
}
