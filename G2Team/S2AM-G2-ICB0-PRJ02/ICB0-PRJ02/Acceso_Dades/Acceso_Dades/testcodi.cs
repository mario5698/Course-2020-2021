using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Dades
{
     public class testcodi
    {
        public  String getdesc(String codigo)
        {
            string Desc;
            if (codigo == "S1J")
            {
                Desc = "Desenv. App. Multiplataforma";
            }
            else
            {
                Desc = "Uknow Data";
            }
            return Desc;
        }
    }
}
