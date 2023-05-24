using Datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_Actualizar_plato
    {
        private Bitmap bmp;
        private string str_Codigo;
        private string str_nombre;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;
        private string str_msn;

        public cls_Actualizar_plato(
           
         string str_Codigo,
         string str_nombre,
         string str_ingredientes,
         string str_valor,
        int int_tipo,
        int int_estado )
        {
            this.str_Codigo = str_Codigo;
            this.str_nombre = str_nombre;
            this.str_ingredientes = str_ingredientes;
            this.str_valor = str_valor;
            this.int_tipo = int_tipo;
            this.int_estado = int_estado;
            if (str_Codigo == "" || str_nombre == "" || str_ingredientes == "" || str_valor == "" )
            {
                str_msn = "Debe ingresar toda la unformacion requerida";
            }
            else
            {
                cls_funciones_restaurante obj_Guardar = new cls_funciones_restaurante();
                obj_Guardar.fnt_Actualizar(str_Codigo, str_nombre, str_ingredientes, str_valor, int_tipo, int_estado);
                str_msn = "  El Plato " + str_nombre + "  ha sido actualizado";

            }



        }
        public string getMsn() { return str_msn; }
    }
}

