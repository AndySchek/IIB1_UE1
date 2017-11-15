<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    [Serializable]
    public class Material
    {
        private String bezeichnung;
        private String brandschutzklasse;
        private String baustoffklasse;

        //Standardkonstruktor
        public Material()
        {
            bezeichnung = "";
            brandschutzklasse = "";
            baustoffklasse = "";
        }


        //Allgemeiner Konstruktor
        public Material(string bezeichnung, string brandschutzklasse, string baustoffklasse)
        {
            this.Bezeichnung = bezeichnung;
            this.Brandschutzklasse = brandschutzklasse;
            this.Baustoffklasse = baustoffklasse;
        }


        public String Bezeichnung { get { return bezeichnung; } set { bezeichnung = value; } }
        public String Brandschutzklasse {  get { return brandschutzklasse; } set { brandschutzklasse = value; } }
        public String Baustoffklasse { get { return baustoffklasse; } set { baustoffklasse = value; } }
    }

  
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    [Serializable]
    public class Material
    {
        private String bezeichnung;
        private String brandschutzklasse;
        private String baustoffklasse;

        //Standardkonstruktor
        public Material()
        {
            bezeichnung = "";
            brandschutzklasse = "";
            baustoffklasse = "";
        }


        //Allgemeiner Konstruktor
        public Material(string bezeichnung, string brandschutzklasse, string baustoffklasse)
        {
            this.Bezeichnung = bezeichnung;
            this.Brandschutzklasse = brandschutzklasse;
            this.Baustoffklasse = baustoffklasse;
        }


        public String Bezeichnung { get { return bezeichnung; } set { bezeichnung = value; } }
        public String Brandschutzklasse {  get { return brandschutzklasse; } set { brandschutzklasse = value; } }
        public String Baustoffklasse { get { return baustoffklasse; } set { baustoffklasse = value; } }
    }

  
}
>>>>>>> ac2e925c57dca098fc7c682bbb2992d8ff3edf84
