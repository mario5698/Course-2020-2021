using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Acceso_Dades;
using System.Configuration;
using System.Collections.Specialized;

namespace FTPServer
{
    public class FTP_Propierties
    {
        NameValueCollection appconfig = ConfigurationManager.AppSettings;
        Acceso con = new Acceso();
        OrderEntities db;
        string ord_id = "", id_op_a = "", id_fac = "", id_ag = "";
        string order = "", ord_date = "", order_id_type = "";
        string id_pla = "", id_ref = "", quant = "", fecha_ent = "";
        int counter;
        string line;

        public void Split( string name, string folder)
        {
            counter = 0;
            db = new OrderEntities();
            //descarga el documento del servidor ftp
            //getFileFromFPTServer();


            //cuenta las lineas del documento descargador del ftp server
            countLines(name, folder);
            //obtiene los varlores del edi y los sube a la base de datos
            getSplitVar(name, folder);
            //sube el docuemento a el servidor ftp
            //uploadFileToFtpServer(filepath, name);
        }

        public void upload(string filepath, string name)
        {
            uploadFileToFtpServer(filepath, name);
        }


        private void getSplitVar(string name, string folder)
        {
            string[] array = new string[counter];

            int arrayCounter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(folder);

            while ((line = file.ReadLine()) != null)
            {
                array[arrayCounter] = line;
                arrayCounter++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                string[] linea = array[i].Split('|');
                if (linea[0] == "ORD")
                {
                    order = linea[1];
                    order_id_type = (Select(linea[2], "idPriority", "codePriority", "Priority"));
                }
                else if (linea[0] == "DTM")
                {
                    ord_date = linea[1];
                }
                else if (linea[0] == "NADMS")
                {
                    id_ag = (Select(linea[1], "idOperationalArea", "codeOperationalArea", "OperationalAreas"));
                    id_op_a = (Select(linea[2], "idAgency", "codeAgency", "Agencies"));
                }
                else if (linea[0] == "NADMR")
                {
                    id_fac = Select(linea[1], "idFactory", "codeFactory", "Factories");
                    Insert_O();
                    Insert_OI();
                }
                else if (linea[0] == "LIN")
                {
                    id_pla = Select(linea[1], "idPlanet", "codeplanet", "Planets");
                    id_ref = Select(linea[2], "idReference", "codeReference", "References");
                }
                else if (linea[0] == "QTYLIN")
                {
                    quant = linea[2];
                }
                else if (linea[0] == "DTMLIN")
                {
                    fecha_ent = linea[1];
                    Insert_OD();
                }
            }
            file.Close();
        }



        private void countLines(string name, string folder)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(folder);
            while ((file.ReadLine()) != null)
            {
                counter++;
            }
            file.Close();
        }

        private void Insert_O()
        {
            DateTime fecha_ord = DateTime.ParseExact(ord_date, "yyyyMMdd", null);
            Order o = new Order
            {
                codeOrder = order,
                dateOrder = fecha_ord,
                IdPriority = short.Parse(order_id_type),
                IdFactory = short.Parse(id_fac)
            };
            db.Orders.Add(o);
            db.SaveChanges();

            string cons = "select top 1 idOrder from orders order by idOrder desc";
            ord_id = con.PortarPerConsulta(cons).Tables[0].Rows[0][0].ToString();

        }

        private void Insert_OD()
        {
            DateTime fecha_entrega = DateTime.ParseExact(fecha_ent, "yyyyMMdd", null);
            OrdersDetail od = new OrdersDetail
            {
                idOrder = short.Parse(ord_id),
                idPlanet = short.Parse(id_pla),
                idReference = short.Parse(id_ref),
                Quantity = short.Parse(quant),
                DeliveryDate = fecha_entrega,
            };
            db.OrdersDetails.Add(od);
            db.SaveChanges();
        }

        private void Insert_OI()
        {
            OrderInfo oi = new OrderInfo
            {
                idOrder = short.Parse(ord_id),
                idAgency = short.Parse(id_ag),
                idOperationalArea = short.Parse(id_op_a)
            };
            db.OrderInfoes.Add(oi);
            db.SaveChanges();
        }

        private string Select(string have, string want, string give, string table)
        {
            string consulta = "select " + want + " from [dbo].[" + table + "] where " + give + " = '" + have + "'";
            return con.PortarPerConsulta(consulta).Tables[0].Rows[0][0].ToString();
        }

        private void uploadFileToFtpServer(string filepath, string name)
        {
            string ftpServer = appconfig.Get("ftpServer");
            string nameDownload = appconfig.Get("nameDownload");
            string user = appconfig.Get("user"); ;
            string passwd = appconfig.Get("passwd");

            byte[] fileContents;

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer + "/" + name);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(user, passwd);


            using (StreamReader sourceStream = new StreamReader(@filepath))
            {
                fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            }

            request.ContentLength = fileContents.Length;

            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
            }
        }

        public string ConnectFtpserver()
        {
            string ftpServer = appconfig.Get("ftpServer");
            string nameDownload = appconfig.Get("nameDownload");
            string user = appconfig.Get("user"); ;
            string passwd = appconfig.Get("passwd");

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential(user, passwd);

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                return "Connect Ftp server Complete, status " + response.StatusDescription;
            }
        }



        public bool listdocuments()
        {
            string ftpServer = appconfig.Get("ftpServer");
            string nameDownload = appconfig.Get("nameDownload");
            string user = appconfig.Get("user"); ;
            string passwd = appconfig.Get("passwd");

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential(user, passwd);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            if (countfiles())
            {
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();

                return true;            
            } else {
                return false;
            }
        }

        public bool countfiles()
        {
            string ftpServer = appconfig.Get("ftpServer");
            string nameDownload = appconfig.Get("nameDownload");
            string user = appconfig.Get("user"); ;
            string passwd = appconfig.Get("passwd");

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential(user, passwd);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader counter = new StreamReader(responseStream);

            if (counter.ReadLine() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getFileFromFPTServer(string namedocument)
        {
            string ftpServer = appconfig.Get("ftpServer");
            string nameDownload = appconfig.Get("nameDownload");
            string user = appconfig.Get("user"); ;
            string passwd = appconfig.Get("passwd");

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer + "/" + namedocument);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(user, passwd);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader file_ = new StreamReader(responseStream);
            using (StreamWriter sw = File.CreateText(".\\" + namedocument))
            {
                sw.WriteLine(file_.ReadToEnd());
            }
            using (FtpWebResponse peticion = (FtpWebResponse)request.GetResponse())
            {
                return "Download File Complete, status " + peticion.StatusDescription;
            }
        }
    }
}
