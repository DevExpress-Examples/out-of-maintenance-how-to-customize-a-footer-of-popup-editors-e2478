namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.myPopupContainerEdit1 = new WindowsApplication1.MyPopupContainerEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPopupContainerEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Controls.Add(this.simpleButton1);
            this.popupContainerControl1.Location = new System.Drawing.Point(12, 60);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(200, 100);
            this.popupContainerControl1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(200, 100);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Hello";
            // 
            // myPopupContainerEdit1
            // 
            this.myPopupContainerEdit1.Location = new System.Drawing.Point(12, 12);
            this.myPopupContainerEdit1.Name = "myPopupContainerEdit1";
            this.myPopupContainerEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myPopupContainerEdit1.Properties.PopupControl = this.popupContainerControl1;
            this.myPopupContainerEdit1.Size = new System.Drawing.Size(457, 20);
            this.myPopupContainerEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 311);
            this.Controls.Add(this.popupContainerControl1);
            this.Controls.Add(this.myPopupContainerEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myPopupContainerEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyPopupContainerEdit myPopupContainerEdit1;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}

