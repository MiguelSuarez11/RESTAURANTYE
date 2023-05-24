using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class cls_agregar_platos
    {
        private string str_Codigo;
        private string str_nombre;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;
        private byte[] byt_imagen;
        private string str_msn;


        public cls_agregar_platos(
         string str_Codigo,
         string str_nombre,
         string str_ingredientes,
         string str_valor,
         int int_tipo,
         int int_estado , byte[] aByte)
       
        {
            this.str_Codigo = str_Codigo;
            this.str_nombre = str_nombre;
            this.str_ingredientes = str_ingredientes;
            this.str_valor = str_valor;
            this.int_tipo = int_tipo;
            this.int_estado = int_estado;
            this.byt_imagen = aByte;

            {
               
                   
                {
                    cls_funciones_restaurante obj_Guardar = new cls_funciones_restaurante();
                   
                    obj_Guardar.fnt_Guardar(str_Codigo, str_nombre, str_ingredientes, str_valor, int_tipo, int_estado, byt_imagen);
                   
                 

                }

            }


        }

        public string getMsn() { return str_msn; }










    }
    }
