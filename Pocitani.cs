using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody09_14
{
    class Pocitani
    {
       /* public bool kvadratickaRovnice(int a, int b, int c, out int pocetKorenu)
        {
            //axna druhou + bx + c = 0
            // D= bnadruhou
            return;
        }*/
        public static bool obsahujeCislici(string retezec, out int cifSoucet, out int cifSoucetLich, out int cifSoucetSud)
        {
            int cifra;
            cifSoucet = 0;
            cifSoucetSud = 0;
            cifSoucetLich = 0;
            bool obsahuje = false;
            for(int i = 0; i <retezec.Length;++i)
            {
                if (char.IsNumber(retezec[i]))
                {
                    obsahuje = true;
                    cifra = int.Parse(retezec[i].ToString());
                    cifSoucet += cifra;
                    if (cifra % 2 == 0) cifSoucetSud += cifra;
                    else cifSoucetLich += cifra;
                }
            }
            return obsahuje;  
        }
    }
}
