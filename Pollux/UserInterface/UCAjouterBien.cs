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
    public partial class UCAjouterBien : UserControl, InterfaceFenetre
    {

        public UCAjouterBien()
        {
            InitializeComponent();
            loadClients();
            loadVilles();
        }
        #region Chargement des comboBox
        private void loadClients()
        {
            List<string> listeNomClients = SqlDataProvider.GetListeNomClients();
            foreach (string nom in listeNomClients) 
            {
                comboBoxProprietaire.Items.Add(nom);
            }
        }
        private void loadVilles()
        {
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            foreach (Ville ville in listeVilles)
            {
                comboBoxVille.Items.Add(string.Format("{0} ({1})", ville.Nom, ville.CodePostal));
            }
        }
        #endregion

        #region Trackbars
        private void trackBarAjoutBienPrix_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutBienPrix.Text = trackBarAjoutBienPrix.Value.ToString();
        }

        private void trackBarAjoutBienSurfHab_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutBienSurfHab.Text = trackBarAjoutBienSurfHab.Value.ToString();
        }

        private void trackBarAjoutBienJardin_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutBienJardin.Text = trackBarAjoutBienJardin.Value.ToString();
        } 
        #endregion
    }
}
