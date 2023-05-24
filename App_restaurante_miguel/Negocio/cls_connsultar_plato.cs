using Datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class cls_connsultar_plato
    {
        private Bitmap bmp;
        private string str_Codigo;
        private string str_nombre;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;
        private string str_mensaje;



        public void fnt_Consultar(string Codigo)
        {
            if (str_Codigo == "" || str_nombre == "" || str_ingredientes == "" || str_valor == "")
            {
                str_mensaje = "Debe ingresar toda la unformacion requerida";
            }




            else
            {


                cls_funciones_restaurante obj_Consultar = new cls_funciones_restaurante();
                obj_Consultar.fnt_consultar(Codigo);
                bmp = obj_Consultar.getBmp();
                this.str_nombre = obj_Consultar.getNombre();
                this.str_ingredientes = obj_Consultar.getIngredientes();
                this.str_valor = obj_Consultar.getValor();
                this.int_tipo = obj_Consultar.getTipo();
                this.int_estado = obj_Consultar.getEstado();
                str_mensaje = obj_Consultar.getMensaje();

            }
        }
        public string getMensaje() { return this.str_mensaje; }
        public Bitmap getBmp() { return bmp; }

        public string getNombre() { return this.str_nombre; }
        public string getIngredientes() { return this.str_ingredientes; }
        public string getValor() { return this.str_valor; }
        public int getTipo() { return this.int_tipo; }
        public int getEstado() { return this.int_estado; }
  
    }
}

