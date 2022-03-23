using System;
using System.Data;
using Gtk;

namespace EjemploMVC_GTK.Datos
{
    public class Conexion
    {
        #region atributos
        private string cadena = String.Empty;
        private MysqlConnection con { get; set; }
        private MysqlComman sqlCommand { get; set; }
        private IDataReader idr { get; set; }
        #endregion

        #region Metodos
        public string CadenaConexion()
        {
            MysqlConnectionStringBuilder sb = new MysqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "pa";
            sb.Database = "prueba";
            sb.Password = "1234";

            return sb.ConnectionString;
         }

        public void Abrirconexion() {
            MessageDialog ms = null;
            if(con.State == ConnectionState.Open)
            {
                return;           
            }
            else {
                con.ConnectionString = cadena;
                try {
                    ms. new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Se conectó a la BD");

                    ms.Run();
                    ms.Destroy();
                }catch(Exception e)
                {


                }
        }
        public Conexion()
        {
        }
    }
}
