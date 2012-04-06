using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Pollux.Object;
using Pollux.DataBase;

namespace Pollux.UserInterface
{
    public partial class UCRechercherSouhait : UserControl
    {
        public UCRechercherSouhait()
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
        private void trackBarRechSouhaitPrix_Scroll(object sender, EventArgs e)
        {
            textBoxRechSouhaitPrix.Text = trackBarRechSouhaitPrix.Value.ToString();
        }

        private void trackBarRechSouhaitSurf_Scroll(object sender, EventArgs e)
        {
            textBoxRechSouhaitSurf.Text = trackBarRechSouhaitSurf.Value.ToString();
        }

        private void trackBarRechSouhaitJardin_Scroll(object sender, EventArgs e)
        {
            textBoxRechSouhaitJardin.Text = trackBarRechSouhaitJardin.Value.ToString();
        }
    }
}
