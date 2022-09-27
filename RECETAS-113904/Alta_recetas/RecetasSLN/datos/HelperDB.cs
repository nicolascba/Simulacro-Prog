using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    internal class HelperDB
    {
        SqlConnection cnn;
        string cadena = "Data Source=DESKTOP-NJN09LF;Initial Catalog=recetas_db;Integrated Security=True";

        public HelperDB()
        {
           cnn = new SqlConnection(cadena);
        }

        public DataTable ConsultarSQL(string sp)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public int ProximaReceta()
        { 
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_PROXIMA_RECETA", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            cnn.Close();
            int nextId;
            if (param.Value != DBNull.Value)
                nextId = (int)param.Value;
            else
                nextId = 1;

            return nextId;
        }

        public bool CargarReceta(Receta receta)
        {
            bool aux = true;
            SqlTransaction trans = null;

            try
            {
                cnn.Open();
                trans = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_RECETA", cnn, trans);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@tipo_receta", receta.TipoReceta);
                cmdMaestro.Parameters.AddWithValue("@nombre", receta.Nombre);
                cmdMaestro.Parameters.AddWithValue("@cheff", receta.Cheff);

                SqlParameter param = new SqlParameter("@id_Receta", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(param);
                cmdMaestro.ExecuteNonQuery();
                int idReceta = (int)param.Value;

                SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", cnn, trans);
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                
                for (int i = 0; i < receta.Detalle.Count; i++)
                {
                    cmdDetalle.Parameters.Clear();

                    cmdDetalle.Parameters.AddWithValue("@id_receta", idReceta);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", receta.Detalle[i].Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@id_ingrediente", receta.Detalle[i].Ingrediente.IngredienteID);
                    cmdDetalle.ExecuteNonQuery();
                    
                    
                }
                trans.Commit();
                

            }
            catch(Exception ex)
            {
                trans.Rollback();
                aux = false;
            }
            finally
            {
                if(cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }


            return aux;
        }

        public DataTable ConsultarReceta(int tipo, string nombre)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_CONSULTAR_RECETAS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@tipo_receta", tipo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
    }
}
