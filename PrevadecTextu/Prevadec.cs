using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevadecTextu
{
    internal class Prevadec
    {
        public string PrevadenyText { get; set; }

        public string MalaPismena()
        {
            string vysledek = PrevadenyText.ToLower();
            vysledek = vysledek.Trim();
            return vysledek;
        }
        public string VelkaPismena()
        {
           //doplň
        }
        public bool ZacinaKonciStejne()
        {
            char prvniZnak = PrevadenyText[0];
            if(PrevadenyText.StartsWith(prvniZnak) && ) //doplň, tohle je jen nápověda :)
        }
        public string SpongebobCase()
        {
            //vytvoř metodu, která z textu např. "ahoj světe" udělá "aHoJ sVěTe"
            //nápověda - cyklus + kontrola sudých a lichých písmen :)
        }
    }
}
