using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_funciones_clientes
    {
        private DataTable dt;
        private string str_nombre;
        private string str_contacto;
        private string str_direccion;
        private string str_msn;
        private Boolean bln_Estado;






        public void fnt_Guardar(
         string identificacion, string nombre, string contacto, string direccion)
        {
            if (bln_Estado == false)
                try
                    {
                    cls_conexion obj_conexion = new cls_conexion();
                    obj_conexion.fnt_conectar();
                    string comando = "insert into tbl_clientes values(@PKId, @Nombre, @Contacto, @Direccion); ";
                    MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
                    cmd.Parameters.AddWithValue("@PKId", identificacion);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Contacto", contacto);
                    cmd.Parameters.AddWithValue("@Direccion", direccion);
                    cmd.ExecuteNonQuery();
                    obj_conexion.fnt_Desconectar();
                    
            }
                catch { }
        }

        public bool Validar_Registro(string identificacion)
        {
            bln_Estado = false;
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string consulta = "SELECT * FROM tbl_clientes WHERE PKId = @PKId";
            MySqlCommand cmd = new MySqlCommand(consulta, obj_conexion.conex);
            cmd.Parameters.AddWithValue("PKId", identificacion);
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

            public void fnt_consultar(string identificacion)
        {
           
            String sql = " select   Nombre, Contacto, Direccion  from tbl_clientes where PKId = '" + identificacion + "'";
            cls_conexion obj_Conectar = new cls_conexion();

            obj_Conectar.fnt_conectar();

            MySqlCommand comando = new MySqlCommand(sql, obj_Conectar.conex);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                str_nombre = reader["Nombre"].ToString();
                str_contacto = reader["Contacto"].ToString();
                str_direccion = reader["Direccion"].ToString();
                str_msn = "";
            }
            else
            {
                str_msn = "No se encontraron regsistros";
            }
            obj_Conectar.fnt_Desconectar();
        }


        public void fnt_Actualizar(
       string identificacion, string nombre, string contacto, string direccion)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_clientes set Nombre=@Nombre, contacto=@contacto, direccion=@direccion " +
            " where PKId=@PKId";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKId", identificacion);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@contacto", contacto);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }














        public DataTable getDt() { return dt; }

        public string getNombre() { return this.str_nombre; }
        public string getContacto() { return this.str_contacto; }
        public string getDireccion() { return this.str_direccion; }

        public string getMsn() { return str_msn; }
    }
}

