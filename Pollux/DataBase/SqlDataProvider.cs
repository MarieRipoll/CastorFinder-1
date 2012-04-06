using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Pollux.DataBase
{
    static public partial class SqlDataProvider
    {
        static public OleDbConnection connect;

        static public bool DBConnect()
        {
            try
            {
                connect = new OleDbConnection(@"Provider=SQLOLEDB;Data Source=localhost;Integrated Security=SSPI;Initial Catalog=CASTORFINDER");
                connect.Open();
                return (connect.State == ConnectionState.Open);
            }
            catch (Exception)
            {
                MessageBox.Show("Attention", "erreur connexion BdD");
                return false;
            }
        }

        static public List<string> GetListePrenomAgents()
        {
            List<string> listePrenomAgents = new List<string>();
            if (DBConnect())
            {
                string requete = "SELECT PRÉNOM_A FROM AGENTS ORDER BY PRÉNOM_A";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des prénoms des agents dans la liste
                while (reader.Read())
                {
                    listePrenomAgents.Add(reader.GetString(0));
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listePrenomAgents;
        }

    }
}
