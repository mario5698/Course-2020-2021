using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTPServer;
namespace DownloadFromFtp
{
    public class Program
    {
        static void Main(string[] args)
        {
            FTP_Propierties ftp_p = new FTP_Propierties();

            string conectar, DocumentName,descarga;
            try
            {
                Console.WriteLine("You want to connect to the ftp server? (Y/N)");
                conectar = (Console.ReadLine()).ToString();
             
                if (conectar == "Y")
                {
                    Console.WriteLine(ftp_p.ConnectFtpserver());

                    if (!ftp_p.listdocuments())
                    {
                        Console.WriteLine("Any File On Server - Press any key to exit.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You want to Download any file? (Y/N)");
                        descarga = Console.ReadLine().ToString();
                        if (descarga == "Y")
                        {
                            Console.WriteLine("Type File Name");
                            DocumentName = Console.ReadLine().ToString();

                            try
                            {
                                Console.WriteLine(ftp_p.getFileFromFPTServer(DocumentName));
                                Console.WriteLine("Download Complete - Press any key to exit.");
                                Console.ReadKey();

                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error to Download File");
                                Console.WriteLine("Press any key to exit.");
                                Console.ReadKey();
                                throw;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error to Connect FTP Server");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                throw;
            }
        }
    }
}
