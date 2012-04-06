using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pollux.Object
{
        public class Souhait
        {
            private int m_prixMax;

            public int PrixMax
            {
                get { return m_prixMax; }
                set { m_prixMax = value; }
            }
            private int m_surfaceHabitableMin;

            public int SurfaceHabitableMin
            {
                get { return m_surfaceHabitableMin; }
                set { m_surfaceHabitableMin = value; }
            }
            private int m_surfaceJardinMin;

            public int SurfaceJardinMin
            {
                get { return m_surfaceJardinMin; }
                set { m_surfaceJardinMin = value; }
            }

            private List<Ville> m_villes;
        }
}
