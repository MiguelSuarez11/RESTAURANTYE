using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_funciones_personal
    {
        private DataTable dt;
        private string str_nombre;
        private string str_contacto;
        private string str_correo;
        private int int_rol;
        private int int_estado;
        private Boolean bln_Estado;
        private string str_msn; 
        public void fnt_CargarRol()
        {
            string sql = "select PKCodigo,Nombre from  tbl_rol";
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


        public void fnt_Guardar(
        string identificacion, string nombre, string contacto, string correo)
        {
            if (bln_Estado == false)
                try
                {
                    cls_conexion obj_conexion = new cls_conexion();
                    obj_conexion.fnt_conectar();
                    string comando = "insert into tbl_personal values(@PKId, @Nombre, @Contacto , @Correo )";
                    MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
                    cmd.Parameters.AddWithValue("@PKId", identificacion);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Contacto", contacto);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.ExecuteNonQuery();
                    obj_conexion.fnt_Desconectar();

                }
                catch { }
        }

        public void fnt_Guardar2(
       string usuario, string contraseña, string id, int estado, int rol)
        {
            if (bln_Estado == false)
            {
                cls_conexion obj_conexion = new cls_conexion();
                obj_conexion.fnt_conectar();
                string comando = "insert into tbl_usuarios values(@PKUsuario, @Contraseña, @FKId_tbl_personal, @FKCodigo_tbl_estado , @FKCpodgo_tbl_rol)";
                MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
                cmd.Parameters.AddWithValue("@PKUsuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                cmd.Parameters.AddWithValue("@FKId_tbl_personal", id);
                cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
                cmd.Parameters.AddWithValue("@FKCpodgo_tbl_rol", rol);
                cmd.ExecuteNonQuery();
                obj_conexion.fnt_Desconectar();


            }
        }




        public bool Validar_Registro(string identificacion)
        {
            bln_Estado = false;
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string consulta = "SELECT * FROM tbl_personal WHERE PKId = @PKId";
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


        public void fnt_CargarEstado()
        {
            string sql = " select PKCodigo, Descripcion from tbl_estado where PKCodigo >= 3 and PKCodigo <= 4";
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

        public void fnt_consultar(string identificacion)
        {

            String sql = " select   Nombre, Contacto, Correo   from tbl_personal where PKId = '" + identificacion + "'";
            cls_conexion obj_Conectar = new cls_conexion();

            obj_Conectar.fnt_conectar();

            MySqlCommand comando = new MySqlCommand(sql, obj_Conectar.conex);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                str_nombre = reader["Nombre"].ToString();
                str_contacto = reader["Contacto"].ToString();
                str_correo = reader["Correo"].ToString();
               
               
            }
            else
            {
                str_msn = "No se encontraron regsistros";
            }
            obj_Conectar.fnt_Desconectar();
        }

        public void fnt_consultar2(string identificacion)
        {

            String sql = " select   FKCodigo_tbl_estado , FKCpodgo_tbl_rol from tbl_usuarios where PKUsuario = '" + identificacion + "'";
            cls_conexion obj_Conectar = new cls_conexion();

            obj_Conectar.fnt_conectar();

            MySqlCommand comando = new MySqlCommand(sql, obj_Conectar.conex);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int_estado = Convert.ToInt16(reader["FKCodigo_tbl_estado"].ToString());
                int_rol = Convert.ToInt16(reader["FKCpodgo_tbl_rol"].ToString());

            }
            else
            {
                str_msn = "No se encontraron regsistros";
            }
            obj_Conectar.fnt_Desconectar();
        }

        public void fnt_Actualizar(
      string identificacion, string nombre, string contacto, string correo )
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_personal set Nombre=@Nombre, Contacto=@Contacto, Correo=@Correo " +
            " where PKId=@PKId";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKId", identificacion);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Contacto", contacto);
            cmd.Parameters.AddWithValue("@Correo", correo);       
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }


        public void fnt_Actualizar2( string identificacion, int estado , int rol)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_usuarios set FKCodigo_tbl_estado=@FKCodigo_tbl_estado,FKCpodgo_tbl_rol=@FKCpodgo_tbl_rol " +
            " where PKUsuario=@PKUsuario";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKUsuario", identificacion);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
            cmd.Parameters.AddWithValue("@FKCpodgo_tbl_rol", rol);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }



        public string getNombre() { return this.str_nombre; }
        public string getContacto() { return this.str_contacto; }
        public string getCorreo() { return this.str_correo; }
      
        public int getEstado() { return this.int_estado; }
        public int getRol() { return this.int_rol; }
        public DataTable getDt() { return dt; }
    }
}
