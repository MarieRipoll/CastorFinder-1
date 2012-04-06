using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Pollux.DataBase;
using Pollux.Object;

namespace Pollux.UserInterface
{
    public partial class UCRechercherBien : UserControl
    {
        public UCRechercherBien()
        {
            InitializeComponent();
            loadVilles();
        }

        #region Chargement des comboBox
        private void loadVilles()
        {
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            foreach (Ville ville in listeVilles)
            {
                comboBoxVilles.Items.Add(string.Format("{0} ({1})", ville.Nom, ville.CodePostal));
            }
        }
        #endregion
        private void trackBarRechBienPrix_Scroll(object sender, EventArgs e)
        {
            textBoxRechBienPrix.Text = trackBarRechBienPrix.Value.ToString();
        }

        private void trackBarRechBienSurf_Scroll(object sender, EventArgs e)
        {
            textBoxRechBienSurf.Text = trackBarRechBienSurf.Value.ToString();
        }

        private void trackBarRechBienJardin_Scroll(object sender, EventArgs e)
        {
            textBoxRechBienJardin.Text = trackBarRechBienJardin.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent = null;
        }
    }
}
