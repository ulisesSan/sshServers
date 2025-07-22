using sshServer.Forms;

namespace sshServer
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void openChildForm(object childForm)
        {
            if (this.PrincipalPanel.Controls.Count > 1)
                this.PrincipalPanel.Controls.RemoveAt(0);

            Form fh = childForm as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PrincipalPanel.Controls.Add(fh);
            this.PrincipalPanel.Tag = fh;
            fh.Show();

        }

        private void btnServers_Click(object sender, EventArgs e)
        {
            openChildForm(new listServersForm());
        }
    }
}
