using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Acceso_Dades
{
    public class Acceso
    {
        #region varibles globales 
        private string connectionString;
        private SqlConnection conexion;
        SqlDataAdapter adaptador;
        String query;
        DataSet dts;
        #endregion
        public Acceso()
        {
            connectionString = ConfigurationManager.ConnectionStrings["M_E_S_S_I.Properties.Settings.DarkCoreConnectionString"].ConnectionString;
            //conexion = new SqlConnection(connectionString);
        }
        #region Events 

        private void Conectar(string query)
        {
            conexion = new SqlConnection(connectionString);

            if (query != null && query != "")
                try
                {
                    if (query != null && query != "")
                    {
                        adaptador = new SqlDataAdapter(query, conexion);
                        if (conexion.State == ConnectionState.Closed) conexion.Open();
                    }
                }
                catch (SqlException)
                {

                }
        }
        public DataTable PortarTaula(string tabla)
        {
            dts = new DataSet();
            query = "select * from " + tabla;
            Conectar(query);
            adaptador.Fill(dts, tabla);
            conexion.Close();
            return dts.Tables[tabla];
        }

        public DataSet PortarPerConsulta(string consulta)
        {
            dts = new DataSet();
            Conectar(consulta);
            adaptador.Fill(dts);
            conexion.Close();
            return dts;
        }

        public bool Verficar_User(string consulta, string tabla)
        {
            dts = new DataSet();
            Conectar(consulta);
            adaptador.Fill(dts, tabla);
            return dts.Tables[tabla].Rows.Count > 0;
        }
        public void Actualitzar(string cons)
        {
            conexion.Close();
            conexion.Open();
            SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(cons, conexion);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adaptador);
            adaptador.Update(dts.Tables[0]);
            conexion.Close();
        }

        public void Ejecutar(string consult)
        {
            Conectar(consult);
            SqlCommand cmd = new SqlCommand(consult, conexion);
            cmd.ExecuteNonQuery();
        }

        public void Encriptar()
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection section = conf.GetSection("connectionStrings")
            as ConnectionStringsSection;

            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            conf.Save();
        }

    }
        #endregion

    }

