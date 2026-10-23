namespace bài3
{
    public partial class frmSchoolMain : Form
    {
        public frmSchoolMain()
        {
            InitializeComponent();
        }

        private void OpenMdiChild<T>() where T : Form, new()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is T)
                {
                    frm.Activate();
                    return;
                }
            }
            T newFrm = new T();
            newFrm.MdiParent = this;
            newFrm.Show();
        }
        private void dSSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cửaSổToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuStudentList2_Click(object sender, EventArgs e) => OpenMdiChild<frmStudentList>();
      //  private void mnuCourseList_Click(object sender, EventArgs e) => OpenMdiChild<frmCourseList>();

        private void mnuCascade2_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.Cascade);
        private void mnuTileHorizontal2_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileHorizontal);
        private void mnuTileVertical2_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileVertical);

        private void mnuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren) frm.Close();
        }

        private void mnuExit2_Click(object sender, EventArgs e) => Application.Exit();

        private void frmSchoolMain_Load(object sender, EventArgs e)
        {

        }
    }
}
