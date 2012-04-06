using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pollux.DataBase;

namespace Pollux.Object
{
    public class Ville
    {
        public Ville(int codePostal, string nom, int index)
        {
            m_codePostal = codePostal;
            m_nom = nom;
            m_index = index;
        }
        public Ville(int codePostal, string nom)
        {
            m_codePostal = codePostal;
            m_nom = nom;
            m_index = -1;
        }
        private int m_codePostal;

        public int CodePostal
        {
            get { return m_codePostal; }
            set { m_codePostal = value; }
        }
        private string m_nom;

        private int m_index;

        public int Index
        {
            get { return m_index; }
            set { m_index = value; }
        }

        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }

        public override string ToString()
        {
            return m_nom + " (" + m_codePostal + ")";
        }
    }
}
