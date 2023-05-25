using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_funciones_pedidos
    {

        private string str_identificacion;
        private string str_ingredientes;
        private string str_nombre;
        private double dbl_valor;
        private string str_fecha;
        private int int_estado;
        private Boolean bln_Estado;
        private string str_msn;
        private DataTable dt;
        private int int_ultima;


        cls_conexion obj_conexion = new cls_conexion();




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
        public void fnt_Cargarpersonal()
        {
            string sql = " select PKUsuario ,Nombre , Descripcion from tbl_estado where PKCodigo >= 5 and PKCodigo <= 7";
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

        public void fnt_CargarEstado()
        {
            string sql = " select PKCodigo, Descripcion from tbl_estado where PKCodigo >= 5 and PKCodigo <= 7";
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


        public void fnt_Registrar_Factura(int no_pedido, double subtotal ,double iva  ,  double total , int tipopago)
        {
            obj_conexion.fnt_conectar();
            String consulta = "insert into tbl_facturas(PKN_pedido_tbl_pedido,Subtotal,Iva ,Total , FKCodigo_tbl_tipopago) " +
                "values ('" + no_pedido + "' ,'" + subtotal + "' ,'" + iva + "' , '" + total + "' , '" + tipopago + "'  )";
            MySqlCommand comando = new MySqlCommand(consulta, obj_conexion.conex);
            MySqlDataReader lectura = comando.ExecuteReader();
            obj_conexion.fnt_Desconectar();
        
        }



        public void fnt_Registrar_Enc_Pedido(string id_cliente, double valor)
        {
            obj_conexion.fnt_conectar();
            String consulta = "insert into tbl_pedidos(FKId_tbl_clientes,Valor,Fecha , FKCodigo_tbl_estado) " +
                "values ('" + id_cliente + "' ,'" + valor + "' ,  current_date() ,1 )";
            MySqlCommand comando = new MySqlCommand(consulta, obj_conexion.conex);
            MySqlDataReader lectura = comando.ExecuteReader();
            obj_conexion.fnt_Desconectar();
            consultarUltimoPedido();
        }




        public void fnt_registrar_Det_pedido(int no_ped, double valor, int cant, int cod_ped)
        {
            obj_conexion.fnt_conectar();
            String consulta = "insert into tbl_det_pedido(FKN_pedido_tbl_pedidos,valor , cantida , FKCodigo_tbl_platos) " +
                "values ('" + no_ped + "',  '" + valor + "','" + cant + "','" + cod_ped + "')";
            MySqlCommand comando = new MySqlCommand(consulta, obj_conexion.conex);
            MySqlDataReader lectura = comando.ExecuteReader();
            obj_conexion.fnt_Desconectar();
            consultarUltimoPedido();

        }


        public void consultarUltimoPedido()
        {
            cls_conexion obj_Conectar = new cls_conexion();
            obj_Conectar.fnt_conectar();
            string SQLbuscar;
            SQLbuscar = "select max(PKN_pedido) as ultima from tbl_pedidos; ";
            MySqlCommand cmd = new MySqlCommand(SQLbuscar, obj_Conectar.conex);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader lectura = cmd.ExecuteReader();
            if (lectura.Read() == true)
            {
                this.int_ultima = Convert.ToInt16(lectura["ultima"].ToString());
            }
            obj_Conectar.fnt_Desconectar();
        }



        public void fnt_consultar(string identificacion)
        {

            String sql = " select   Valor, current_date(), FKCodigo_tbl_estado  from tbl_pedidod where FKId_tbl_clientes = '" + identificacion + "'";
            cls_conexion obj_Conectar = new cls_conexion();

            obj_Conectar.fnt_conectar();

            MySqlCommand comando = new MySqlCommand(sql, obj_Conectar.conex);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                dbl_valor = Convert.ToDouble( reader["Valor"].ToString());
                int_estado = Convert.ToInt16(reader["FKCodigo_tbl_estado"].ToString());
               
            }
            else
            {
                str_msn = "No se encontraron registros";
            }
            obj_Conectar.fnt_Desconectar();
        }

        public int getUltimoPedido() { return this.int_ultima; }
        public double getValor() { return dbl_valor; }
        public int getEstado() { return this.int_estado; }
    }
}
