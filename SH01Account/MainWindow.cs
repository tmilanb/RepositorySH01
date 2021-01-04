using System;
using System.Windows.Forms;

namespace PracticeAutoMail
{
    public partial class MainWindow : Form
    {
        ////Field
        private Form currentChildForm;
        public MainWindow()
        {
            InitializeComponent();
            OpenChildForm(new UserForm());
        }       

        ////Panels
        private void btnUserPanel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());            
        }
        private void btnUsersPanel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UsersForm());
        }
        private void btnResetPanel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResetForm());

        }

        ////Method for open the panel
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelForForms.Controls.Add(childForm);
            panelForForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
    }
}
