using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pollux.Object
{
    public class Bien
    {
        private int m_prix;

        public int Prix
        {
            get { return m_prix; }
            set { m_prix = value; }
        }
        private DateTime m_dateMiseEnVente;

        public DateTime DateMiseEnVente
        {
            get { return m_dateMiseEnVente; }
            set { m_dateMiseEnVente = value; }
        }
        private int m_surfaceHabitable;

        public int SurfaceHabitable
        {
            get { return m_surfaceHabitable; }
            set { m_surfaceHabitable = value; }
        }
        private int m_surfaceJardin;

        public int SurfaceJardin
        {
            get { return m_surfaceJardin; }
            set { m_surfaceJardin = value; }
        }

        private Ville m_ville;

        public Ville Ville
        {
            get { return m_ville; }
            set { m_ville = value; }
        }
    }
}
