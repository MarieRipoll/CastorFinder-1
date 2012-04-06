using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using Pollux.Object;

namespace Pollux.DataBase
{
    static public partial class SqlDataProvider  
    {
        static public bool ajouterClient(Client c)
        {
            bool ajout;
            // si pas de connexion
            if (!DBConnect())
                ajout = false;
            // si connexion
            else
            {
                string requete = string.Format("INSERT INTO CLIENTS (NOM_C, CODE_POSTAL_V) VALUES (N'{0}',N'{1}')", ville.Nom, ville.CodePostal);
                OleDbCommand command = new OleDbCommand(requete, connect);
                int rowCount = command.ExecuteNonQuery();
                if (rowCount == 1)
                    ajout = true;  // ajout effectué
                else
                    ajout = false; // ajout non effectué
                // déconnexion
                connect.Close();
            }
            return ajout;
        }
        static public List<string> GetListeNomClients()
        {
            List<string> listeNomClients = new List<string>() ;
            if (DBConnect())
            {
                string requete = "SELECT NOM_C FROM CLIENTS ORDER BY NOM_C";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des noms des clients dans la liste
                while (reader.Read())
                    listeNomClients.Add(reader.GetString(0));
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeNomClients;
        }
        static public List<string> GetListeNomClients(string prenomAgent)
        {
            List<string> listeNomClients = new List<string>();
            if (DBConnect())
            {
                string requete = "SELECT NOM_C FROM CLIENTS INNER JOIN AGENTS ON CLIENTS.NUM_A = AGENTS.NUM_A"
                                + " WHERE AGENTS.PRÉNOM_A = N'"
                                + prenomAgent
                                + "' ORDER BY NOM_C";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des noms des clients dans la liste
                while (reader.Read())
                    listeNomClients.Add(reader.GetString(0));
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeNomClients;
        }
    }
}
