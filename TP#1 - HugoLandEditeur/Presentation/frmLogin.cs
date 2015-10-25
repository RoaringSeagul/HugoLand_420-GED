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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (var db = new GameContext())
            {
                var queryUsername = from user in db.CompteJoueurs
                                where user.NomUtilisateur == txtUsername.Text
                                select user;

                if (queryUsername.First().NomUtilisateur != "")
                    if (txtPassword.Text != "" && queryUsername.First().Password == txtPassword.Text)
                    {
                        this.Hide();
                        frmMain Main = new frmMain();
                        Main.ShowDialog();
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
    }
}
