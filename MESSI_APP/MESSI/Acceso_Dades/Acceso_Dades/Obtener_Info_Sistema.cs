using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;


namespace Acceso_Dades
{
    // con esta clase se pretende obtener la mac y el nombre del equipo
   public class Obtener_Info_Sistema
    {
        public string ObtenerMac()
        {
            string mac = "", new_mac;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        mac = nic.GetPhysicalAddress().ToString();
                    }
                }
            }
            new_mac = mac.Substring(0, 2);
            for (int n = 4; n < mac.Length + 2; n = n + 2)
            {
                new_mac = new_mac + "-" + mac.Substring(n - 2, 2);
            }
            return new_mac;
        }

        public string ObtenerHostname()
        {
            String NombreMaquina = Environment.MachineName;
            return NombreMaquina;
        }

    }

    
}
