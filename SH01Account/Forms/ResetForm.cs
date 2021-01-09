using PracticeAutoMail.User;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace PracticeAutoMail
{
    public partial class ResetForm : Form
    {
        // List of the users
        List<UserAccount> listOfUser = new List<UserAccount>();

        public ResetForm()
        {
            InitializeComponent();
        }

        // Button Actions
        private void btnAddReset_Click(object sender, EventArgs e)
        {
            FindUser();
            PasswordGenerate();

            var newUser = new UserAccount(txtLNameReset.Text + " " + txtFNameReset.Text, txtMailReset.Text, txtAccReset.Text, txtPwReset.Text);

            if (listOfUsersReset.Items.Contains(newUser.Address) == false)
            {
                listOfUsersReset.Items.Add(newUser.Address);
                listOfUser.Add(newUser);
            }
            else
            {
                MessageBox.Show("The user is already in the list!");
            }

        }
        private void btnPWGenerator_Click(object sender, EventArgs e)
        {
            PasswordGenerate();
        }
        private void btnCreateMailReset_Click(object sender, EventArgs e)
        {
            foreach (var item in listOfUser)
            {
                Task task = new Task(() => CreateTemplate(item));
                task.Start();
            }
        }
        private void btnTemplateReset_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            #region CommentTemplate            
            sb.AppendLine("Your password has been reset, the new password has been sent to you in an encrypted email with the subject 'SH01 password reset'");
            sb.AppendLine("Please do not forget, that you have to change your password before the first login on the following link:");
            sb.AppendLine("https://sh01usertools.onehc.net/madis/User.aspx");
            sb.AppendLine(string.Empty);
            sb.AppendLine("*A strong password consists of at least one upper and one lower letter, at least one number and a special sign and more than eight characters.");
            sb.AppendLine("If you use special characters in the password, please use only from the following ones: =#,.;:@!$%");
            sb.AppendLine(string.Empty);
            sb.AppendLine("We advise you to use KeePass 2 for your password generation and storage.");
            sb.AppendLine(string.Empty);
            sb.AppendLine("We are closing this ticket. If you have any problem, please reopen the ticket.");
            sb.AppendLine(string.Empty);
            sb.AppendLine("If you have any issue at the password change procedure first please visit the following site for help:");
            sb.AppendLine("https://dev.azure.com/SHS-IT-AlmDev/Customer%20Information/_wiki/wikis/Customer-Information.wiki/197/First-Steps");
            sb.AppendLine(string.Empty);
            sb.AppendLine("Sincerely yours");
            sb.AppendLine("");
            sb.AppendLine("Application Service Desk");
            #endregion
            System.Windows.Forms.Clipboard.SetText(sb.ToString());
        }

        // Methods
        public void FindUser()
        {
            if (txtMailReset.Text != "")
            {
                try
                {
                    using (var context = new PrincipalContext(ContextType.Domain, "AD005"))
                    {
                        var user = UserPrincipal.FindByIdentity(context, txtMailReset.Text);

                        txtAccReset.Text = user.SamAccountName;
                        txtFNameReset.Text = user.GivenName;
                        int len = txtAccReset.Text.Length + txtFNameReset.Text.Length + 2;
                        txtLNameReset.Text = user.Name.Substring(0, user.Name.Length - len);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check the Mail address again! It is possible that there is a white space!");
                }
            }
            else
            {
                MessageBox.Show("Please add an Email address!");
            }
        }
        private void PasswordGenerate()
        {
            if (txtAccReset.Text != string.Empty)
            {
                string password = Membership.GeneratePassword(22, 5);

                /////Add necessary character to the password
                string[] plusLetter = new string[] { "[", ")", "{", "#", "&", "=", ":" };

                foreach (var item in plusLetter)
                {
                    if (password.Contains(item) == false)
                    {
                        password = password + item;
                    }
                }

                ////Remove forbidden character from the password
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i].ToString() == "\\")
                    {
                        password = password.Replace(password[i], 'b');
                    }
                }

                txtPwReset.Text = password;
            }
        }
        public void CreateTemplate(User.UserAccount user)
        {
            Microsoft.Office.Interop.Outlook.Application newMail = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook._MailItem newMailTemplate = (Microsoft.Office.Interop.Outlook._MailItem)newMail.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            newMailTemplate.To = user.Address;
            newMailTemplate.Subject = "SH01 password reset";

            var sb = new StringBuilder();

            #region TemplateMail
            sb.AppendLine($"Dear {user.Name} ");
            sb.AppendLine(string.Empty);
            sb.AppendLine($@"The R&D Account 'SH01\{user.Account}' password has been reset.");
            sb.AppendLine(string.Empty);
            sb.AppendLine("The new, TEMPORARY password is:");
            sb.AppendLine(string.Empty); 
            sb.AppendLine(user.Password.ToString());
            sb.AppendLine(string.Empty);
            sb.AppendLine("Please use the self-service site below to change your password to something more personal right away:");
            sb.AppendLine(String.Format("https://SH01UserTools.onehc.net/SSAD"));
            sb.AppendLine(string.Empty);
            sb.AppendLine("Please be aware of the following:");
            sb.AppendLine(string.Empty);
            sb.AppendLine("Please note that the password reset tool does not accept blank characters.");
            sb.AppendLine("If you are using the wrong format, you will get the following error message: ");
            sb.AppendLine("’The account does not exist’");
            sb.AppendLine("For that reason, please use the following format of the account, when you paste it into the ’account’ field: ");
            sb.AppendLine(string.Empty);
            sb.AppendLine($@"SH01\{user.Account}");
            sb.AppendLine(string.Empty);
            sb.AppendLine("The password field is working the same as the account field. ");
            sb.AppendLine("Please always follow the instructions of the password reset tool!");
            sb.AppendLine("After the password change please wait at least 60 minutes for the synchronization to finish.");
            sb.AppendLine(string.Empty);
            sb.AppendLine("If you experience problems signing in, please check the following links for help:");
            sb.AppendLine("Username was not found:");
            sb.AppendLine(String.Format("https://dev.azure.com/SHS-IT-AlmDev/Customer%20Information/_wiki/wikis/Customer-Information.wiki/109/Known-Issues?anchor=username-was-not-found-during-chaning-password-(sh01)"));
            sb.AppendLine(string.Empty);
            sb.AppendLine("If you have any further questions, please write into the ticket, as replies to this email are NOT PROCESSED.");
            #endregion

            newMailTemplate.Body = sb.ToString();

            newMailTemplate.Display(true);
        }        
        private void txtPwReset_TextChanged(object sender, EventArgs e)
        {
            txtPwReset.SelectAll();
        }
    }
}
