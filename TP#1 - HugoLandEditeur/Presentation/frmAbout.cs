using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoLandEditeur
{
    /// <summary>
    /// Auteur: Hugo St-Louis
    /// Date : 2015/10/01
    /// Description: Donne de l'information sur la version en cours.
    /// </summary>
    public partial class frmAbout : Form
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public frmAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clique sur le bouton Fermer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Affichage de la version lors du chargement de la fenêtre 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAbout_Load(object sender, System.EventArgs e)
        {
           lblVersion.Text = "Version: " + Application.ProductVersion;
        }
    }
}
