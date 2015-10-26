using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoLandEditeur.Presentation
{
    public partial class frmNewUser : Form
    {
        private GameContext _dbContext;
        public frmNewUser()
        {
            InitializeComponent();

        }
        private void frmNewUser_Load(object sender, EventArgs e)
        {
            _dbContext = new GameContext();
        }

        /// <summary>
        /// Sauvegarde les informations du nouveau utilisateur dans la base de données et test s'il a été entré correctement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            CompteJoueur User = new CompteJoueur();
            User.Courriel = txtEmail.Text;
            User.Nom = txtFirstName.Text;
            User.NomUtilisateur = txtUsername.Text;
            User.Password = txtPassword.Text;
            User.Prenom = txtFirstName.Text;
            User.TypeUtilisateur = int.Parse(txtUserType.Text);
            _dbContext.CompteJoueurs.Add(User);
            _dbContext.SaveChanges();

            var queryTest = (from db in _dbContext.CompteJoueurs
                            where db.NomUtilisateur == txtUsername.Text
                            select db).ToList();
            if (queryTest.Count > 0)
            {
                lblNewUserActions.ForeColor = Color.Green;
                lblNewUserActions.Text = "L'utilisateur a été ajouté correctement";
            }
            else
            {
                lblNewUserActions.ForeColor = Color.Red;
                lblNewUserActions.Text = "L'utilisateur n'a pas été ajouté correctement";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbContext.SaveChanges();
        }
    }
}
