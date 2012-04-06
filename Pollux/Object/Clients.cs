using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pollux.Object
{
    public class Client
    {
        private string m_nom;

        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }
        private string m_adresse;

        public string Adresse
        {
            get { return m_adresse; }
            set { m_adresse = value; }
        }
        private string m_telephone;

        public string Telephone
        {
            get { return m_telephone; }
            set { m_telephone = value; }
        }

        private Agent m_agent = null;
        private Ville m_ville;
        public Client(string nom, string adresse, string telephone, int index_ville)
        {
            m_nom = nom;
            m_adresse = adresse;
            m_telephone = telephone;
            m_ville = DataBase.SqlDataProvider.trouverVille(index_ville);
        }

    }
}
