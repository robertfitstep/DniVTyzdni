using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypisDniVTyzdni
{
    static class DniVTyzdni
    {
        static string errMsg = "Zadali ste nesprávny deň v týždni";

        static Dictionary<int, string> prvyPondelok = new Dictionary<int, string>
        {
            { 1,"Pondelok" },
            { 2, "Utorok" },
            { 3, "Streda" },
            { 4, "Štvrtok" },
            { 5, "Piatok" },
            { 6, "Sobota" },
            { 7, "Nedela" }
        };

        static Dictionary<int, string> prvaNedela = new Dictionary<int, string>
        {
            { 1, "Nedela" },
            { 2,"Pondelok" },
            { 3, "Utorok" },
            { 4, "Streda" },
            { 5, "Štvrtok" },
            { 6, "Piatok" },
            { 7, "Sobota" }
        };

        public static string VypisDenVTyzdni(string denVTyzdni)
        {
            return VypisDenVTyzdni(denVTyzdni, false);
        }

        public static string VypisDenVTyzdni(string denVTyzdni, bool nedelaPrva)
        {
            if (ValidujDen(denVTyzdni))
            {
                if (nedelaPrva)
                {
                    return prvaNedela[int.Parse(denVTyzdni)];
                }
                else if (!nedelaPrva)
                {
                    return prvyPondelok[int.Parse(denVTyzdni)];
                }
                else
                {
                    return errMsg;
                }
            }
            else
            {
                return errMsg;
            }
        

        bool ValidujDen(string den) {
            int d = int.Parse(den);
            if (d > 0 && d <= 7) { return true; }
            else return false;            
            }
        }
    }
    }


