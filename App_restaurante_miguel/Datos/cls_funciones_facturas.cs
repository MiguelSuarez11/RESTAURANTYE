using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_funciones_facturas
    {
        private string str_identificacion;
        int int_N_pedido;
        private string str_mensaje;
        private DataTable dt;
        private Boolean bln_Estado;

        cls_conexion obj_conexion = new cls_conexion();
        public void fnt_Guardar2( int tipopago)
        {
            obj_conexion.fnt_conectar();
            String consulta = "insert into tbl_facturas( FKCodigo_tbl_tipopago) " +
                "values ('" + tipopago + "'  )";
            MySqlCommand comando = new MySqlCommand(consulta, obj_conexion.conex);
            MySqlDataReader lectura = comando.ExecuteReader();
            obj_conexion.fnt_Desconectar();
        }



        public void fnt_consultar(string str_identificacion)
        {

            String sql = " select   PKN_pedido  from tbl_pedidos where FKId_tbl_clientes = '" + str_identificacion + "'";
            cls_conexion obj_Conectar = new cls_conexion();
            obj_Conectar.fnt_conectar();
            MySqlCommand comando = new MySqlCommand(sql, obj_Conectar.conex);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
              
                int_N_pedido = Convert.ToInt16(reader["PKN_pedido"].ToString());
                str_mensaje = "Pedido encontrado";
            }
            else
            {
                str_mensaje = "No se encontraron pedidos";
            }
            obj_Conectar.fnt_Desconectar();
        }





        public void fnt_CargarTipoPago()
        {
            string sql = "select PKCodigo,Nombre from  tbl_tipopago";
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

        public DataTable getDt() { return dt; }
        public int getN_pedido() { return this.int_N_pedido; }
        public string getMensaje() { return str_mensaje; }
    }
}
