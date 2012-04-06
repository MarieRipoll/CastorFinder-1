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

namespace Pollux.UserInterface
{
    public partial class UCAjouterVisite : UserControl
    {
        public UCAjouterVisite()
        {
            InitializeComponent();
            loadClients();
        }

        #region Chargement des comboBox
        private void loadClients()
        {
            List<string> listeClients = SqlDataProvider.GetListeNomClients();
            foreach (string prenom in listeClients)
            {
                comboBoxClients.Items.Add(prenom);
            }
        }
        #endregion
    }
}
