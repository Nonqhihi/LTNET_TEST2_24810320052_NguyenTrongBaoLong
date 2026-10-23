namespace bài3
{
    partial class frmSchoolMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mnuStudentList2 = new ToolStripMenuItem();
            cửaSổToolStripMenuItem1 = new ToolStripMenuItem();
            mnuTileVertical2 = new ToolStripMenuItem();
            mnuTileHorizontal2 = new ToolStripMenuItem();
            mnuCascade2 = new ToolStripMenuItem();
            hệThốngToolStripMenuItem1 = new ToolStripMenuItem();
            mnuExit2 = new ToolStripMenuItem();
            mnuStudentList = new ToolStripMenuItem();
            mnuCourseList = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, cửaSổToolStripMenuItem1, hệThốngToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuStudentList2 });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(62, 20);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // mnuStudentList2
            // 
            mnuStudentList2.Name = "mnuStudentList2";
            mnuStudentList2.Size = new Size(180, 22);
            mnuStudentList2.Text = "DS Sinh Viên";
            mnuStudentList2.Click += mnuStudentList2_Click;
            // 
            // cửaSổToolStripMenuItem1
            // 
            cửaSổToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { mnuTileVertical2, mnuTileHorizontal2, mnuCascade2 });
            cửaSổToolStripMenuItem1.Name = "cửaSổToolStripMenuItem1";
            cửaSổToolStripMenuItem1.Size = new Size(56, 20);
            cửaSổToolStripMenuItem1.Text = "Cửa Sổ";
            // 
            // mnuTileVertical2
            // 
            mnuTileVertical2.Name = "mnuTileVertical2";
            mnuTileVertical2.Size = new Size(180, 22);
            mnuTileVertical2.Text = "Dọc";
            mnuTileVertical2.Click += mnuTileVertical2_Click;
            // 
            // mnuTileHorizontal2
            // 
            mnuTileHorizontal2.Name = "mnuTileHorizontal2";
            mnuTileHorizontal2.Size = new Size(180, 22);
            mnuTileHorizontal2.Text = "Ngang";
            mnuTileHorizontal2.Click += mnuTileHorizontal2_Click;
            // 
            // mnuCascade2
            // 
            mnuCascade2.Name = "mnuCascade2";
            mnuCascade2.Size = new Size(180, 22);
            mnuCascade2.Text = "Xếp Tầng";
            mnuCascade2.Click += mnuCascade2_Click;
            // 
            // hệThốngToolStripMenuItem1
            // 
            hệThốngToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { mnuExit2 });
            hệThốngToolStripMenuItem1.Name = "hệThốngToolStripMenuItem1";
            hệThốngToolStripMenuItem1.Size = new Size(71, 20);
            hệThốngToolStripMenuItem1.Text = "Hệ Thống";
            // 
            // mnuExit2
            // 
            mnuExit2.Name = "mnuExit2";
            mnuExit2.Size = new Size(180, 22);
            mnuExit2.Text = "Thoát";
            mnuExit2.Click += mnuExit2_Click;
            // 
            // mnuStudentList
            // 
            mnuStudentList.Name = "mnuStudentList";
            mnuStudentList.Size = new Size(180, 22);
            mnuStudentList.Text = "DS Sinh viên";
            // 
            // mnuCourseList
            // 
            mnuCourseList.Name = "mnuCourseList";
            mnuCourseList.Size = new Size(180, 22);
            mnuCourseList.Text = "DS Lớp";
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(55, 20);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            cửaSổToolStripMenuItem.Click += cửaSổToolStripMenuItem_Click;
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(121, 22);
            mnuCascade.Text = "Xếp tầng";
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(121, 22);
            mnuTileHorizontal.Text = "Ngang";
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(121, 22);
            mnuTileVertical.Text = "Dọc";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuExit });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            hệThốngToolStripMenuItem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(67, 22);
            // 
            // frmSchoolMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "frmSchoolMain";
            Text = "Hệ thống Quản lý Đào tạo";
            WindowState = FormWindowState.Maximized;
            Load += frmSchoolMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuStudentList;
        private ToolStripMenuItem dSSinhViênToolStripMenuItem;
        private ToolStripMenuItem mnuCourseList;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem mnuStudentList2;
        private ToolStripMenuItem cửaSổToolStripMenuItem1;
        private ToolStripMenuItem dọcToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem mnuTileVertical2;
        private ToolStripMenuItem mnuTileHorizontal2;
        private ToolStripMenuItem mnuCascade2;
        private ToolStripMenuItem hệThốngToolStripMenuItem1;
        private ToolStripMenuItem mnuExit2;
    }
}
