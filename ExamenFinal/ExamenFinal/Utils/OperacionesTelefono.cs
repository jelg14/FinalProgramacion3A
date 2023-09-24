using ExamenFinal.Clases;
using ExamenFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Utils
{
    internal class OperacionesTelefono : ITelefonos
    {
        string strConn = @"Server=localhost\SQLEXPRESS;DataBase=ExamenFinal;Trusted_Connection=true"; //agregar /SQLEXPRESS a la par de localhost si se utiliza sql server express
        DataSet ds = new DataSet();
        public DataSet GetAllTelefonos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "SELECT top 500 * FROM Telefonos";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(ds);
                    conn.Close();
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet GetTelefonoByGamma(string gamma)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "";
                    if (gamma == "XSs") select = "SELECT top 500 * FROM Telefonos WHERE Gamma = 'XSs'";
                    else if (gamma == "XSs Maxs") select = "SELECT top 500 * FROM Telefonos WHERE Gamma = 'XSs Maxs'";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(ds);
                    conn.Close();
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save(Telefono telefono)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Telefonos VALUES " +
                        "(@Marca, @Gamma, @PaisDeEnsamblaje, @precio, @porcentajeAincrementar" +
            ",@Color,@FechaDeRegistro)", conn);
                    insertCommand.Parameters.Add(new SqlParameter("Marca", telefono.Marca));
                    insertCommand.Parameters.Add(new SqlParameter("Gamma", telefono.Gamma));
                    insertCommand.Parameters.Add(new SqlParameter("PaisDeEnsamblaje", telefono.PaisDeEnsamblaje));
                    insertCommand.Parameters.Add(new SqlParameter("precio", telefono.precio));
                    insertCommand.Parameters.Add(new SqlParameter("porcentajeAincrementar", telefono.porcentajeAincrementar));
                    insertCommand.Parameters.Add(new SqlParameter("Color", telefono.color));
                    insertCommand.Parameters.Add(new SqlParameter("FechaDeRegistro", telefono.FechaDeRegistro));
                    insertCommand.ExecuteNonQuery();
                    Form1 fPrincipal = new Form1();
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
