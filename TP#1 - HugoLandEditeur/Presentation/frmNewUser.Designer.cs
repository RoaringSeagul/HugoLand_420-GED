namespace HugoLandEditeur.Presentation
{
    partial class frmNewUser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label nomUtilisateurLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label prenomLabel;
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this._bsUser = new System.Windows.Forms.BindingSource(this.components);
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblNewUserActions = new System.Windows.Forms.Label();
            this.gbChoseUser = new System.Windows.Forms.GroupBox();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.rdUser = new System.Windows.Forms.RadioButton();
            courrielLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            nomUtilisateurLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._bsUser)).BeginInit();
            this.gbChoseUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(23, 143);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(45, 13);
            courrielLabel.TabIndex = 16;
            courrielLabel.Text = "Courriel:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(23, 116);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 20;
            nomLabel.Text = "Nom:";
            // 
            // nomUtilisateurLabel
            // 
            nomUtilisateurLabel.AutoSize = true;
            nomUtilisateurLabel.Location = new System.Drawing.Point(23, 35);
            nomUtilisateurLabel.Name = "nomUtilisateurLabel";
            nomUtilisateurLabel.Size = new System.Drawing.Size(81, 13);
            nomUtilisateurLabel.TabIndex = 22;
            nomUtilisateurLabel.Text = "Nom Utilisateur:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(23, 61);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 24;
            passwordLabel.Text = "Password:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(23, 88);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 26;
            prenomLabel.Text = "Prenom:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(56, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(137, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsUser, "Courriel", true));
            this.txtEmail.Location = new System.Drawing.Point(112, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // _bsUser
            // 
            this._bsUser.DataSource = typeof(HugoLandEditeur.CompteJoueur);
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsUser, "Nom", true));
            this.txtLastName.Location = new System.Drawing.Point(112, 113);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 21;
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsUser, "NomUtilisateur", true));
            this.txtUsername.Location = new System.Drawing.Point(112, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 23;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsUser, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(112, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 25;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsUser, "Prenom", true));
            this.txtFirstName.Location = new System.Drawing.Point(112, 85);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 27;
            // 
            // lblNewUserActions
            // 
            this.lblNewUserActions.AutoSize = true;
            this.lblNewUserActions.Location = new System.Drawing.Point(32, 10);
            this.lblNewUserActions.Name = "lblNewUserActions";
            this.lblNewUserActions.Size = new System.Drawing.Size(149, 13);
            this.lblNewUserActions.TabIndex = 30;
            this.lblNewUserActions.Text = "Entrer un nouvelle utilisateur : ";
            // 
            // gbChoseUser
            // 
            this.gbChoseUser.Controls.Add(this.rdUser);
            this.gbChoseUser.Controls.Add(this.rdAdmin);
            this.gbChoseUser.Location = new System.Drawing.Point(26, 166);
            this.gbChoseUser.Name = "gbChoseUser";
            this.gbChoseUser.Size = new System.Drawing.Size(186, 50);
            this.gbChoseUser.TabIndex = 31;
            this.gbChoseUser.TabStop = false;
            this.gbChoseUser.Text = "Choisir votre utilisateur";
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Location = new System.Drawing.Point(9, 19);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(91, 17);
            this.rdAdmin.TabIndex = 0;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Administrateur";
            this.rdAdmin.UseVisualStyleBackColor = true;
            // 
            // rdUser
            // 
            this.rdUser.AutoSize = true;
            this.rdUser.Location = new System.Drawing.Point(106, 19);
            this.rdUser.Name = "rdUser";
            this.rdUser.Size = new System.Drawing.Size(71, 17);
            this.rdUser.TabIndex = 1;
            this.rdUser.TabStop = true;
            this.rdUser.Text = "Utilisateur";
            this.rdUser.UseVisualStyleBackColor = true;
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 259);
            this.Controls.Add(this.gbChoseUser);
            this.Controls.Add(this.lblNewUserActions);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(nomUtilisateurLabel);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmNewUser";
            this.Text = "frmNewUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewUser_FormClosing);
            this.Load += new System.EventHandler(this.frmNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this._bsUser)).EndInit();
            this.gbChoseUser.ResumeLayout(false);
            this.gbChoseUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource _bsUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblNewUserActions;
        private System.Windows.Forms.GroupBox gbChoseUser;
        private System.Windows.Forms.RadioButton rdUser;
        private System.Windows.Forms.RadioButton rdAdmin;
    }
}