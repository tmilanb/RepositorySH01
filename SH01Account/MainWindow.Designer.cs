namespace PracticeAutoMail
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnResetPanel = new FontAwesome.Sharp.IconButton();
            this.btnUsersPanel = new FontAwesome.Sharp.IconButton();
            this.btnUserPanel = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelForForms = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btnResetPanel);
            this.MainPanel.Controls.Add(this.btnUsersPanel);
            this.MainPanel.Controls.Add(this.btnUserPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(562, 76);
            this.MainPanel.TabIndex = 15;
            // 
            // btnResetPanel
            // 
            this.btnResetPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPanel.FlatAppearance.BorderSize = 0;
            this.btnResetPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPanel.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnResetPanel.IconColor = System.Drawing.Color.Black;
            this.btnResetPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetPanel.IconSize = 42;
            this.btnResetPanel.Location = new System.Drawing.Point(383, 2);
            this.btnResetPanel.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPanel.Name = "btnResetPanel";
            this.btnResetPanel.Size = new System.Drawing.Size(179, 76);
            this.btnResetPanel.TabIndex = 2;
            this.btnResetPanel.Text = "Reset Password";
            this.btnResetPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnResetPanel.UseVisualStyleBackColor = true;
            this.btnResetPanel.Click += new System.EventHandler(this.btnResetPanel_Click);
            // 
            // btnUsersPanel
            // 
            this.btnUsersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsersPanel.FlatAppearance.BorderSize = 0;
            this.btnUsersPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersPanel.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnUsersPanel.IconColor = System.Drawing.Color.Black;
            this.btnUsersPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsersPanel.IconSize = 42;
            this.btnUsersPanel.Location = new System.Drawing.Point(200, 0);
            this.btnUsersPanel.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsersPanel.Name = "btnUsersPanel";
            this.btnUsersPanel.Size = new System.Drawing.Size(179, 76);
            this.btnUsersPanel.TabIndex = 1;
            this.btnUsersPanel.Text = "Create Users";
            this.btnUsersPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsersPanel.UseVisualStyleBackColor = true;
            this.btnUsersPanel.Click += new System.EventHandler(this.btnUsersPanel_Click);
            // 
            // btnUserPanel
            // 
            this.btnUserPanel.FlatAppearance.BorderSize = 0;
            this.btnUserPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserPanel.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUserPanel.IconColor = System.Drawing.Color.Black;
            this.btnUserPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserPanel.IconSize = 36;
            this.btnUserPanel.Location = new System.Drawing.Point(0, 0);
            this.btnUserPanel.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserPanel.Name = "btnUserPanel";
            this.btnUserPanel.Size = new System.Drawing.Size(196, 76);
            this.btnUserPanel.TabIndex = 0;
            this.btnUserPanel.Text = "Create User";
            this.btnUserPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserPanel.UseVisualStyleBackColor = true;
            this.btnUserPanel.Click += new System.EventHandler(this.btnUserPanel_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.AutoSize = true;
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.Location = new System.Drawing.Point(0, 76);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(0, 0);
            this.panelMenu.TabIndex = 16;
            // 
            // panelForForms
            // 
            this.panelForForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForForms.Location = new System.Drawing.Point(0, 76);
            this.panelForForms.Name = "panelForForms";
            this.panelForForms.Size = new System.Drawing.Size(562, 754);
            this.panelForForms.TabIndex = 17;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(562, 830);
            this.Controls.Add(this.panelForForms);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private FontAwesome.Sharp.IconButton btnResetPanel;
        private FontAwesome.Sharp.IconButton btnUsersPanel;
        private FontAwesome.Sharp.IconButton btnUserPanel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForForms;
    }
}

