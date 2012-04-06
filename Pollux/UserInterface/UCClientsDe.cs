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
    public partial class UCClientsDe : UserControl
    {
        public UCClientsDe()
        {
            InitializeComponent();
            loadAgents();
        }
        #region Chargement des comboBox
        private void loadAgents()
        {
            List<string> listeAgents = SqlDataProvider.GetListePrenomAgents();
            foreach (string prenom in listeAgents)
            {
                comboBoxAgents.Items.Add(prenom);
            }
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            listBoxClients.Items.Clear();
            if (comboBoxAgents.SelectedItem != null)
            {
                List<string> listeClients = SqlDataProvider.GetListeNomClients(comboBoxAgents.SelectedItem.ToString());
                foreach (string nom in listeClients)
                {
                    listBoxClients.Items.Add(nom);
                }
            }
        }
    }
}
