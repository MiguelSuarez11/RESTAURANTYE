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


        cls_conexion obj_conexion = new cls_conexion();


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



        public void fnt_Registrar_pedido()
        {
            obj_conexion.fnt_conectar();
            String consulta = "insert into tbl_pedidos( FKCodigo_tbl_estado ) " +
                "values ('6' )";
            MySqlCommand comando = new MySqlCommand(consulta, obj_conexion.conex);
            MySqlDataReader lectura = comando.ExecuteReader();
            obj_conexion.fnt_Desconectar();
          
        }

        public void fnt_Actualizar(
        string codigo, string nombre, string ingredientes, string valor, int tipo, int estado)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_platos set Nombre=@Nombre, ingredientes=@ingredientes, valor=@valor, " +
            "FKCodigo_tbl_tipo=@FKCodigo_tbl_tipo,FKCodigo_tbl_estado=@FKCodigo_tbl_estado where PKCodigo=@PKCodigo";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKCodigo", codigo);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@ingredientes", ingredientes);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_tipo", tipo);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }


        public void fnt_guardarseleccion(string id , int pedido)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_pedidos set FKId_tbl_personal_DOM=@FKId_tbl_personal_DOM ,  FKCodigo_tbl_estado=@FKCodigo_tbl_estado where FKId_tbl_personal_DOM=@FKId_tbl_personal_DOM";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@FKId_tbl_personal_DOM", id);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", pedido);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
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
