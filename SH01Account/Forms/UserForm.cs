using System;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Net.Mail;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;
using System.Threading.Tasks;

namespace PracticeAutoMail
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        // Button Actions
        private void btnCheck_Click(object sender, EventArgs e)
        {            
            FindUser();
            PasswordGenerate();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Task tOne = new Task(() => CreateTemplate(new User.UserAccount(txtLName.Text + " " + txtFName.Text, txtMail.Text, txtAcc.Text, txtPw.Text)));
            tOne.Start();
        }
        private void btnLDTemplate_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            sb.AppendLine("We have created the account for you and sent the password via encrypted e-mail.");
            sb.AppendLine("You can request for TFS permissions via MADiS by yourself.");
            sb.AppendLine("Link to MADiS");
            sb.AppendLine("https://sh01usertools.onehc.net/madis/User.aspx");
            sb.AppendLine(string.Empty);
            sb.AppendLine("Here you can find a guidance how to use the MADiS:");
            sb.AppendLine("MADiS User Guide");
            sb.AppendLine("https://sh01usertools.onehc.net/madis/Guides.aspx");
            sb.AppendLine(string.Empty);
            sb.AppendLine("To login to MADiS, please use your new SH01 account and the new password that you added at the password change process!");
            sb.AppendLine(string.Empty);
            sb.AppendLine("When you navigate to the provided MADiS pages, a credential popup will appear.");
            sb.AppendLine("On this popup window, please choose the ’More choices’ option. After you click it, you will be able to choose the necessary option: ’Use a different account’.");
            sb.AppendLine($@"Here you can paste your SH01 account as the following: SH01\{txtAcc.Text} and your password as well.");
            sb.AppendLine("Please avoid blank characters at the beginning, the middle, and the end of your account name.");
            sb.AppendLine(string.Empty);
            sb.AppendLine("If you experience problems signing in, please check the following links for help:");
            sb.AppendLine("Username was not found:");
            sb.AppendLine("https://basic-teamspace.healthcare.siemens.com/content/10000032/Lists/Wiki/FirstSteps.aspx#h4");
            sb.AppendLine("Login failed into MADiS (SH01):");
            sb.AppendLine("https://basic-teamspace.healthcare.siemens.com/content/10000032/Lists/Wiki/FirstSteps.aspx#h5");
            sb.AppendLine("Unauthorized access to MADiS (SH01):");
            sb.AppendLine("https://basic-teamspace.healthcare.siemens.com/content/10000032/Lists/Wiki/FirstSteps.aspx#h6");
            sb.AppendLine(string.Empty);
            sb.AppendLine("Sincerely yours");
            sb.AppendLine("");
            sb.AppendLine("Application Service Desk");

            System.Windows.Forms.Clipboard.SetText(sb.ToString());
        }
        private void btnPOCTemplate_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            sb.AppendLine("We have created the account for you and sent the password via encrypted e-mail.");
            sb.AppendLine("You can request TFS Access for your account trough creating a ticket in SHARP: ");
            sb.AppendLine("https://healthcare.service-now.com/");
            sb.AppendLine(string.Empty);
            sb.AppendLine("Sincerely yours");
            sb.AppendLine("");
            sb.AppendLine("Application Service Desk");

            System.Windows.Forms.Clipboard.SetText(sb.ToString());
        }
        private void btnPWGenerator_Click(object sender, EventArgs e)
        {
            PasswordGenerate();
        }

        // Buttons for copying of the content of the textbox
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMail();
        }
        private void btnScriptSet_Click(object sender, EventArgs e)
        {
            if (txtPSscript.Text != "")
            {
                System.Windows.Forms.Clipboard.SetText(txtPSscript.Text);
            }
            else
            {
                Console.WriteLine("The textBox of the script is empty!");
            }
        }
        private void btnScriptGet_Click(object sender, EventArgs e)
        {
            string getScriptValueStart = txtPSscript.Text.Substring(0, 20) + "-Properties EmployeeNumber";
            string getScriptValueEnd = getScriptValueStart.Replace("set", "get");

            if (txtPSscript.Text != "")
            {
                System.Windows.Forms.Clipboard.SetText(getScriptValueEnd);
            }
            else
            {
                Console.WriteLine("The textBox of the script is empty!");
            }
        }
        private void btnFirstGroup_Click(object sender, EventArgs e)
        {
            string group = "SH01-Proxy-Users-L";
            System.Windows.Forms.Clipboard.SetText(group);
        }
        private void btnSecondGroup_Click(object sender, EventArgs e)
        {
            string group = "SH01-TS-Users-L";
            System.Windows.Forms.Clipboard.SetText(group);
        }

        // Methods
        public void FindUser()
        {
            if (txtMail.Text != "")
            {
                try
                {
                    using (var context = new PrincipalContext(ContextType.Domain, "AD005"))
                    {
                        var user = UserPrincipal.FindByIdentity(context, txtMail.Text);
                        txtDName.Text = user.DisplayName;
                        txtAcc.Text = user.SamAccountName;
                        txtFName.Text = user.GivenName;
                        int len = txtAcc.Text.Length + txtFName.Text.Length + 2;
                        txtLName.Text = user.Name.Substring(0, user.Name.Length - len);
                        txtDescription.Text = user.Description;

                        ////Find the City and the GID                        
                        DirectoryEntry entry = new DirectoryEntry("AD005");
                        entry.Path = "LDAP://DC = ad005,DC = onehc,DC = net";
                        DirectorySearcher dSearch = new DirectorySearcher(entry);

                        dSearch.Filter = "(&(objectClass=user)(samAccountName=" + txtAcc.Text + "))";
                        dSearch.PropertiesToLoad.Add("l");
                        dSearch.PropertiesToLoad.Add("siemens-gid");

                        SearchResult result = dSearch.FindOne();

                        string location = result.Properties["l"][0].ToString();
                        string GID = result.Properties["siemens-gid"][0].ToString();

                        //Add the values to the TextBoxes:
                        txtCity.Text = location.ToString();
                        txtPSscript.Text = $"set-aduser {user.SamAccountName} -EmployeeNumber {GID}";
                        
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check the Mail address! It is possible that there is a white space!");
                }
                
            }
            else
            {
                MessageBox.Show("Please add an Email address!");
            }
        }
        private void ClearAllText()
        {
            txtMail.Clear();
            txtAcc.Clear();
            txtCity.Clear();
            txtDescription.Clear();
            txtDName.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtPSscript.Clear();
        }        
        public void CreateTemplate(User.UserAccount user)
        {
            Microsoft.Office.Interop.Outlook.Application newMail = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook._MailItem newMailTemplate = (Microsoft.Office.Interop.Outlook._MailItem)newMail.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            newMailTemplate.To = user.Address;
            newMailTemplate.Subject = "New SH01 account";

            var sb = new StringBuilder();

            sb.AppendLine($"Dear {user.Name} ");
            sb.AppendLine(string.Empty);
            sb.AppendLine($@"The R&D Account SH01\{user.Account} has been created.");
            sb.AppendLine(string.Empty);
            sb.AppendLine("The new, TEMPORARY password is:");
            sb.AppendLine(string.Empty);
            sb.AppendLine(txtPw.Text);
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
            sb.AppendLine("If you use special characters in the password, please use only from the following ones: =#,.;:@!$%");
            sb.AppendLine("");
            sb.AppendLine("If you experience problems, you can also check the following link for help:");
            sb.AppendLine("Username was not found:");
            sb.AppendLine(String.Format("https://dev.azure.com/SHS-IT-AlmDev/Customer%20Information/_wiki/wikis/Customer-Information.wiki/109/Known-Issues?anchor=username-was-not-found-during-chaning-password-(sh01)"));
            sb.AppendLine(string.Empty);
            sb.AppendLine("If you have any further questions, please write into the ticket, as replies to this email are NOT PROCESSED.");

            newMailTemplate.Body = sb.ToString();

            newMailTemplate.Display(true);

        }        
        private void PasswordGenerate()
        {
            if (txtAcc.Text != string.Empty)
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

                txtPw.Text = password;
            }

        }

        // TextBoxesClick
        private void txtMail_DoubleClick(object sender, EventArgs e)
        {
            txtMail.SelectAll();
        }
        private void txtPw_DoubleClick(object sender, EventArgs e)
        {
            txtPw.SelectAll();
        }
        private void txtDName_DoubleClick(object sender, EventArgs e)
        {
            txtDName.SelectAll();
        }
        private void txtDescription_DoubleClick(object sender, EventArgs e)
        {
            txtDescription.SelectAll();
        }

        // Under constructions
        public void SendMailWithoutEncrypt()
        {
            //try LEt's try something else. 
            //{
            //    SmtpClient client = new SmtpClient("mail.siemens.de", 25);

            //    MailMessage msg = new MailMessage();
            //    msg.From = new System.Net.Mail.MailAddress(txtUserName.Text);
            //    msg.To.Add(txtTo.Text);
            //    msg.Subject = txtSubject.Text;
            //    msg.Body = txtMessage.Text;


            //    client.UseDefaultCredentials = false;
            //    client.EnableSsl = true;

            //    client.Credentials = new NetworkCredential(txtUserName.Text, txtPw.Text);

            //    client.Send(msg);
            //    msg = null;

            //    MessageBox.Show("done");

            //    //string userstate = "Sending...";
            //    //client.SendAsync(msg, userstate);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
        public void SendMail()
        {
            string CertificatePath = @"C:\Users\z003x60a\Desktop\Attach\new.p12"; /*"C:\\aa.cer";*/
            string CertificatePassword = "";

            string MailServer = "mail.siemens.de";
            string EmailRecipient = "milan.tirk@evosoft.com";
            string EmailSender = "milan.tirk@evosoft.com";
            string EmailSubject = "Test";
            string EmailBody = "TestBody";
            //bool IsHtmlEmail = false;

            //Load the certificate
            X509Certificate2 EncryptCert = new X509Certificate2(CertificatePath, CertificatePassword, X509KeyStorageFlags.Exportable | X509KeyStorageFlags.PersistKeySet);

            //Build the body into a string
            StringBuilder Message = new StringBuilder();
            //Message.AppendLine("Content-Type: text/" +
            //    ((IsHtmlEmail) ? "html" : "plain") +
            //    "; charset=\"iso-8859-1\"");

            Message.AppendLine("First line");
            Message.AppendLine("                Second line");
            Message.Append("\tThird line");

            Message.AppendLine("Content-Transfer-Encoding: 7bit");
            Message.AppendLine(EmailBody);

            //Convert the body to bytes
            byte[] BodyBytes = Encoding.ASCII.GetBytes(Message.ToString());

            //Build the e - mail body bytes into a secure envelope
            EnvelopedCms Envelope = new EnvelopedCms(new ContentInfo(BodyBytes));
            CmsRecipient Recipient = new CmsRecipient(
                SubjectIdentifierType.IssuerAndSerialNumber, EncryptCert);
            Envelope.Encrypt(Recipient);
            byte[] EncryptedBytes = Envelope.Encode();

            //Creat the mail message
            MailMessage Msg = new MailMessage();
            Msg.To.Add(new System.Net.Mail.MailAddress(EmailRecipient));
            Msg.From = new System.Net.Mail.MailAddress(EmailSender);
            Msg.Subject = EmailSubject;

            //Attach the encrypted body to the email as and ALTERNATE VIEW
            MemoryStream ms = new MemoryStream(EncryptedBytes);
            AlternateView av =
                new AlternateView(ms,
                "application/pkcs7-mime; smime-type=signed-data;name=smime.p7m");
            Msg.AlternateViews.Add(av);

            SmtpClient smtp = new SmtpClient(MailServer, 25);
            //send the email
            smtp.Send(Msg);
            MessageBox.Show("Done");

        }
        
    }
}
