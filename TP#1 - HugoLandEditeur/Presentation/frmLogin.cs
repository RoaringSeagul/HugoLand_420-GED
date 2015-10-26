using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace HugoLandEditeur.Presentation
{
    public partial class frmLogin : Form
    {
        public int UserType { get; private set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Va regarder si l'utilisateur existe dans la base de données et ensuite va le connecté d'après ses privilège
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (var db = new GameContext())
            {
                var queryUsername = (from user in db.CompteJoueurs
                                where user.NomUtilisateur == txtUsername.Text
                                select user).ToList();

                if (queryUsername.Count > 0)
                    if (txtPassword.Text != "" && queryUsername.First().Password == txtPassword.Text)
                    {
                        UserType = queryUsername.First().TypeUtilisateur;
                        this.TopMost = false;
                        this.Close();
                    }
                    else
                        lblActions.Text = "Le mot de passe est incorrect";
                else
                    lblActions.Text = "Cette utilisateur n'existe pas";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Met cette fenêtre en premier plan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Activate();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
