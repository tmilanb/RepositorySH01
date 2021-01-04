namespace PracticeAutoMail
{
    partial class ResetForm
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
            this.btnAddReset = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.txtMailReset = new System.Windows.Forms.TextBox();
            this.btnPWGenerator = new System.Windows.Forms.Button();
            this.txtPwReset = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTemplateReset = new System.Windows.Forms.Button();
            this.btnCreateMailReset = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAccReset = new System.Windows.Forms.TextBox();
            this.listOfUsersReset = new System.Windows.Forms.ListBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtLNameReset = new System.Windows.Forms.TextBox();
            this.txtFNameReset = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddReset
            // 
            this.btnAddReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReset.Location = new System.Drawing.Point(274, 53);
            this.btnAddReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddReset.Name = "btnAddReset";
            this.btnAddReset.Size = new System.Drawing.Size(122, 32);
            this.btnAddReset.TabIndex = 45;
            this.btnAddReset.Text = "Add";
            this.btnAddReset.UseVisualStyleBackColor = true;
            this.btnAddReset.Click += new System.EventHandler(this.btnAddReset_Click);
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(2, 10);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 35);
            this.label28.TabIndex = 44;
            this.label28.Text = "Email";
            // 
            // txtMailReset
            // 
            this.txtMailReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMailReset.Location = new System.Drawing.Point(131, 11);
            this.txtMailReset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMailReset.Name = "txtMailReset";
            this.txtMailReset.Size = new System.Drawing.Size(419, 22);
            this.txtMailReset.TabIndex = 43;
            // 
            // btnPWGenerator
            // 
            this.btnPWGenerator.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPWGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPWGenerator.Location = new System.Drawing.Point(447, 251);
            this.btnPWGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.btnPWGenerator.Name = "btnPWGenerator";
            this.btnPWGenerator.Size = new System.Drawing.Size(104, 29);
            this.btnPWGenerator.TabIndex = 61;
            this.btnPWGenerator.Text = "+";
            this.btnPWGenerator.UseVisualStyleBackColor = true;
            this.btnPWGenerator.Click += new System.EventHandler(this.btnPWGenerator_Click);
            // 
            // txtPwReset
            // 
            this.txtPwReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwReset.Location = new System.Drawing.Point(130, 252);
            this.txtPwReset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPwReset.Name = "txtPwReset";
            this.txtPwReset.Size = new System.Drawing.Size(299, 22);
            this.txtPwReset.TabIndex = 60;
            this.txtPwReset.TextChanged += new System.EventHandler(this.txtPwReset_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 35);
            this.label4.TabIndex = 59;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 58;
            this.label3.Text = "User List";
            // 
            // btnTemplateReset
            // 
            this.btnTemplateReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemplateReset.Location = new System.Drawing.Point(335, 582);
            this.btnTemplateReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemplateReset.Name = "btnTemplateReset";
            this.btnTemplateReset.Size = new System.Drawing.Size(215, 59);
            this.btnTemplateReset.TabIndex = 57;
            this.btnTemplateReset.Text = " Copy Resolution Template To Cilpboard";
            this.btnTemplateReset.UseVisualStyleBackColor = true;
            this.btnTemplateReset.Click += new System.EventHandler(this.btnTemplateReset_Click);
            // 
            // btnCreateMailReset
            // 
            this.btnCreateMailReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCreateMailReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMailReset.Location = new System.Drawing.Point(335, 542);
            this.btnCreateMailReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateMailReset.Name = "btnCreateMailReset";
            this.btnCreateMailReset.Size = new System.Drawing.Size(215, 34);
            this.btnCreateMailReset.TabIndex = 56;
            this.btnCreateMailReset.Text = "Create Mail Templates";
            this.btnCreateMailReset.UseVisualStyleBackColor = true;
            this.btnCreateMailReset.Click += new System.EventHandler(this.btnCreateMailReset_Click);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(1, 184);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 28);
            this.label24.TabIndex = 55;
            this.label24.Text = "Account";
            // 
            // txtAccReset
            // 
            this.txtAccReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccReset.Location = new System.Drawing.Point(130, 184);
            this.txtAccReset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAccReset.Name = "txtAccReset";
            this.txtAccReset.Size = new System.Drawing.Size(419, 22);
            this.txtAccReset.TabIndex = 53;
            // 
            // listOfUsersReset
            // 
            this.listOfUsersReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfUsersReset.FormattingEnabled = true;
            this.listOfUsersReset.ItemHeight = 16;
            this.listOfUsersReset.Location = new System.Drawing.Point(130, 304);
            this.listOfUsersReset.Margin = new System.Windows.Forms.Padding(2);
            this.listOfUsersReset.Name = "listOfUsersReset";
            this.listOfUsersReset.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listOfUsersReset.Size = new System.Drawing.Size(420, 196);
            this.listOfUsersReset.TabIndex = 51;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(1, 141);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 28);
            this.label26.TabIndex = 65;
            this.label26.Text = "Last Name";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1, 98);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(119, 28);
            this.label27.TabIndex = 64;
            this.label27.Text = "First Name";
            // 
            // txtLNameReset
            // 
            this.txtLNameReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLNameReset.Location = new System.Drawing.Point(130, 141);
            this.txtLNameReset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtLNameReset.Name = "txtLNameReset";
            this.txtLNameReset.Size = new System.Drawing.Size(419, 22);
            this.txtLNameReset.TabIndex = 63;
            // 
            // txtFNameReset
            // 
            this.txtFNameReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFNameReset.Location = new System.Drawing.Point(130, 99);
            this.txtFNameReset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFNameReset.Name = "txtFNameReset";
            this.txtFNameReset.Size = new System.Drawing.Size(419, 22);
            this.txtFNameReset.TabIndex = 62;
            // 
            // ResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(566, 654);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtLNameReset);
            this.Controls.Add(this.txtFNameReset);
            this.Controls.Add(this.btnPWGenerator);
            this.Controls.Add(this.txtPwReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTemplateReset);
            this.Controls.Add(this.btnCreateMailReset);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtAccReset);
            this.Controls.Add(this.listOfUsersReset);
            this.Controls.Add(this.btnAddReset);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtMailReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ResetForm";
            this.Text = "ResetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddReset;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtMailReset;
        private System.Windows.Forms.Button btnPWGenerator;
        private System.Windows.Forms.TextBox txtPwReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTemplateReset;
        private System.Windows.Forms.Button btnCreateMailReset;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAccReset;
        private System.Windows.Forms.ListBox listOfUsersReset;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtLNameReset;
        private System.Windows.Forms.TextBox txtFNameReset;
    }
}