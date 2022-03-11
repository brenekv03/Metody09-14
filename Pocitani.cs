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
        public static int PocetSlov1(string retezec, out string novyretezec)
        {
            string novyretezec1 = retezec;
            char[] separators = { ' ' };
            string[] s = novyretezec1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int pocetSlov = s.Length;
            int i = 0;
            while (i < retezec.Length)
            {
                if (char.IsNumber(retezec[i]))
                {
                    retezec =retezec.Remove(i, 1);
                }
                else ++i;

            }
            novyretezec = retezec;
            return pocetSlov;
        }
        public static int PocetSlov2(ref string retezec)
        {
            string novyretezec1 = retezec;
            char[] separators = { ' ' };
            string[] s = novyretezec1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int pocetSlov = s.Length;
            int i = 0;
            while (i < retezec.Length)
            {
                if (char.IsNumber(retezec[i]))
                {
                    retezec = retezec.Remove(i, 1);
                }
                else ++i;

            }
            return pocetSlov;
        }
        public static bool ObsahujeSlovo(string retezec, out string nejdelsi, out string nejkratsi)
        {
            bool obsahujeSlovo = false;
            nejdelsi = "";
            nejkratsi = "";
            if (retezec.Length > 0 && retezec != "")
            {
                for (int i = 0;i<retezec.Length&&!obsahujeSlovo;i++)
                {
                if (retezec[i] != ' ') obsahujeSlovo = true;
                }
                if (obsahujeSlovo)
                {
                    char[] separators = { ' ' };
                    string[] s = retezec.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    nejdelsi = s[0];
                    nejkratsi = s[0];
                    for (int i = 0; i < s.Length; ++i)
                    {
                        string slovicko = s[i];
                        if (slovicko.Length < nejkratsi.Length) nejkratsi = slovicko;
                        if (slovicko.Length > nejdelsi.Length) nejdelsi = slovicko;
                    }
                }
            }
            return obsahujeSlovo;
        }
        public static bool JeAlfanum(string retezec, out int pocMal, out int pocVel, out int pocJin)
        {
            pocMal = 0;
            pocVel = 0;
            pocJin = 0;
            bool jeAlfanum = true;
            for(int i = 0; i < retezec.Length;i++)
            {
                if (char.IsNumber(retezec[i])) jeAlfanum = true;
                else if (char.IsLower(retezec[i])) pocMal++;
                else if (char.IsUpper(retezec[i])) pocVel++;
                else
                {
                    jeAlfanum = false;
                    pocJin++;
                }
            }
            return jeAlfanum;
        }
    }
}
