using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;

namespace DynamicPanels {
    public partial class Form1 : Form {
        const string DockingLayoutFile = "DockingLayoutFile.xml";
        public Form1() {
            InitializeComponent();            
            CreateDockPanels();
        }

        private void CreateDockPanels() {
            DockPanel panel1 = dockManager1.AddPanel(DockingStyle.Left);
            panel1.Text = "Panel 1";
            panel1.ID = new Guid("{00000000-0000-0000-0000-000000000001}");
            panel1.Controls.Add(new UserControl1());

            DockPanel panel2 = dockManager1.AddPanel(DockingStyle.Right);
            panel2.Text = "Panel 2";
            panel2.ID = new Guid("{00000000-0000-0000-0000-000000000002}");
            panel2.Controls.Add(new UserControl2());
        }

        private void SaveLayoutToXml(object sender, EventArgs e) {
            dockManager1.SaveLayoutToXml(DockingLayoutFile);
        }

        private void RestoreLayoutToXml(object sender, EventArgs e) {
            if(System.IO.File.Exists(DockingLayoutFile))
                dockManager1.RestoreLayoutFromXml(DockingLayoutFile);
        }
    }
}