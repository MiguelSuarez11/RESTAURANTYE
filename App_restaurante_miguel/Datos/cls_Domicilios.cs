using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_Domicilios
    {




        private string str_nombre;

        private DataTable dt;




        public void fnt_Cargardomi(string id)
        {
            string sql = "select tbl_pedidos.FKId_tbl_personal_DOM as 'Id' , tbl_pedidos.PKN_pedido as 'Pedido asignado' from tbl_pedidos \r\nwhere\r\ntbl_pedidos.FKId_tbl_personal_DOM = '"+id+"' and\r\ntbl_pedidos.PKN_pedido";
            cls_conexion objConecta = new cls_conexion();
            objConecta.fnt_conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objConecta.conex);
                dt = new DataTable();
                MySqlDataAdapter Data = new MySqlDataAdapter(comando);
                Data.Fill(dt);


            }
            catch (Exception)
            {
                objConecta.fnt_Desconectar();
            }
        }





        public void fnt_consultar(string id)
        {

            String sql = " select tbl_pedidos.FKId_tbl_personal_DOM as 'Id' , tbl_pedidos.PKN_pedido as 'Pedido asignado' from tbl_pedidos \r\nwhere\r\ntbl_pedidos.FKId_tbl_personal_DOM = '" + id + "' and\r\ntbl_pedidos.PKN_pedido";
            cls_conexion obj_Conectar = new cls_conexion();

            obj_Conectar.fnt_conectar();

            MySqlCommand comando = new MySqlCommand(sql, obj_Conectar.conex);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                str_nombre = reader["Pedido asignado"].ToString();



            }
            else
            {
            }
            obj_Conectar.fnt_Desconectar();
        }
        public string getNombre() { return this.str_nombre; }
        public DataTable getDt() { return dt; }

    }
}
