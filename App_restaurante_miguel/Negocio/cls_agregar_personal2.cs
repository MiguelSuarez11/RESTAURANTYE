using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_agregar_personal2
    {
        private string usuario;
        private string contraseña;
        private string id;
        private int estado;
        private int rol;



        public cls_agregar_personal2(

         string usuario,
         string contraseña,
         string id,
         int estado, int rol)
        {

           this.usuario = usuario;
            this.contraseña = contraseña;
            this.id = id;
            this.estado = estado;
            this.rol = rol;
            {

                {
                    cls_funciones_personal obj_Guardar_personal2 = new cls_funciones_personal();

                    obj_Guardar_personal2.fnt_Guardar2(usuario, contraseña, id, estado, rol);


                }
            }


        }

    }
}
