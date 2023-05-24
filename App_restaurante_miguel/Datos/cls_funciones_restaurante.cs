using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Datos
{
    public class cls_funciones_restaurante
    {
       
        private Bitmap bmp;
        private DataTable dt;
        private DataTable est;
        private string str_nombre;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;
        private byte[] imagen;
        private string str_msn;

        private Boolean bln_Estado;




        public void fnt_Guardar(
            string codigo, string nombre, string ingredientes, string valor, int tipo, int estado, byte[] imagen)
        {
        
            if (bln_Estado == false)
            {
                try
                    {
                    cls_conexion obj_conexion = new cls_conexion();
                    obj_conexion.fnt_conectar();
                    string comando = "insert into tbl_platos values(@PKCodigo, @Nombre, @ingredientes, @valor, @FKCodigo_tbl_tipo, @FKCodigo_tbl_estado , @imagen); ";
                    MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
                    cmd.Parameters.AddWithValue("@PKCodigo", codigo);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@ingredientes", ingredientes);
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@FKCodigo_tbl_tipo", tipo);
                    cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
                    cmd.Parameters.AddWithValue("@imagen", imagen);
                    cmd.ExecuteNonQuery();
                    obj_conexion.fnt_Desconectar();

                }
                catch (Exception) { this.str_msn = "plato ya registrado / problemas de conexion"; }
           
            }
    

        }

        public bool Validar_Registro(string codigo)
        {
            bln_Estado = false;
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string consulta = "SELECT * FROM tbl_platos WHERE PKCodigo = @PKCodigo";
            MySqlCommand cmd = new MySqlCommand(consulta, obj_conexion.conex);
            cmd.Parameters.AddWithValue("PKCodigo", codigo);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                // El registro ya existe
                obj_conexion.fnt_Desconectar();
                return true;


            }
            else
            {
                // El registro no existe

                obj_conexion.fnt_Desconectar();

                return false;

            }


        }


        public void fnt_consultar(string codigo)
        {
            bln_Estado = false;
            String sql = " select   Nombre, ingredientes, valor, FKCodigo_tbl_tipo, FKCodigo_tbl_estado , imagen from tbl_platos where PKCodigo = '" + codigo + "'";
            cls_conexion obj_Conectar = new cls_conexion();

            obj_Conectar.fnt_conectar();

            MySqlCommand comando = new MySqlCommand(sql, obj_Conectar.conex);
            MySqlDataReader reader = comando.ExecuteReader();
            
            if (reader.HasRows)
            {
                reader.Read();
                bln_Estado = true;
                MemoryStream ms = new MemoryStream((byte[])reader["imagen"]);
                bmp = new Bitmap(ms);
                str_nombre = reader["Nombre"].ToString();
                str_ingredientes = reader["ingredientes"].ToString();
                str_valor = reader["valor"].ToString();
                int_tipo = Convert.ToInt16(reader["FKCodigo_tbl_tipo"].ToString());
                int_estado = Convert.ToInt16(reader["FKCodigo_tbl_estado"].ToString());
                //Console.WriteLine("Nombre " + str_nombre);
                this.str_msn = "";
            }
            
            obj_Conectar.fnt_Desconectar();
        }


       




      



        public void fnt_CargarTipo()
        {
            string sql = "select PKCodigo,Nombre from  tbl_tipo";
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

      







        public void fnt_CargarEstado()
        {
            string sql = " select PKCodigo, Descripcion from tbl_estado where PKCodigo >= 1 and PKCodigo <= 2";
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



        public Bitmap getBmp() { return bmp; }
        public string getNombre() { return this.str_nombre; }
        public string getIngredientes() { return this.str_ingredientes; }
        public string getValor() { return this.str_valor; }
        public int getTipo() { return this.int_tipo; }
        public int getEstado() { return this.int_estado; }
        public string getMensaje() { return this.str_msn; }
    }




}


