namespace DynamicPanels {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.SaveLayout = new DevExpress.XtraEditors.SimpleButton();
            this.RestoreLayout = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // SaveLayout
            // 
            this.SaveLayout.Location = new System.Drawing.Point(244, 12);
            this.SaveLayout.Name = "SaveLayout";
            this.SaveLayout.Size = new System.Drawing.Size(86, 23);
            this.SaveLayout.TabIndex = 0;
            this.SaveLayout.Text = "SaveLayout";
            this.SaveLayout.Click += new System.EventHandler(this.SaveLayoutToXml);
            // 
            // RestoreLayout
            // 
            this.RestoreLayout.Location = new System.Drawing.Point(336, 12);
            this.RestoreLayout.Name = "RestoreLayout";
            this.RestoreLayout.Size = new System.Drawing.Size(85, 23);
            this.RestoreLayout.TabIndex = 1;
            this.RestoreLayout.Text = "RestoreLayout";
            this.RestoreLayout.Click += new System.EventHandler(this.RestoreLayoutToXml);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 395);
            this.Controls.Add(this.RestoreLayout);
            this.Controls.Add(this.SaveLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.SimpleButton SaveLayout;
        private DevExpress.XtraEditors.SimpleButton RestoreLayout;
    }
}

