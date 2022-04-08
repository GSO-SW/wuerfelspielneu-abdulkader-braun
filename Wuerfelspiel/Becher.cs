using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuerfelspiel
{
    public class Becher
    {
        public Wuerfel[] Wuerfels { get; private set; }

        public Becher(int anzahlWuerfel)
        {
            Wuerfels = new Wuerfel[anzahlWuerfel];
        }

        public void WuerfelSicherungUmschalten(int wuerfelNummer)
        {
            Wuerfels[wuerfelNummer].Gesichert = !Wuerfels[wuerfelNummer].Gesichert;
        }

        private void Wuerfeln()
        {

        }
    }
}
