﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuerfelspielTests
{
    class wuerfel
    {
        int anzahlseiten = 6;
        int letztesergebniss;
        bool gesichert = false;
        Random random;
        int wuerfelergebniss;
        wuerfel(int anzahlseiten)
        {
            this.anzahlseiten = anzahlseiten;
           
        }
        wuerfel()
        {

        }



        public int AnzahlSeiten
        {
            get => anzahlseiten;
        }
        public int Letztesergebniss
        {
            get => wuerfelergebniss;
        }
        public bool Gesichert
        {
            get => gesichert;

            set
            {
                gesichert = value;
            }
        }



    }
}
