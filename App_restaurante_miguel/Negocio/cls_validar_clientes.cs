using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_validar_clientes
    {
        private bool validar;
        public bool fnt_validar_clientes(string identificacion)
        {

            cls_funciones_clientes obj_validar = new cls_funciones_clientes();
            validar = obj_validar.Validar_Registro(identificacion);
            return validar;
        }

        public bool getValidar() { return this.validar; }
    }

    public class cls_validar_personal
    {
        private bool validar;
        public bool fnt_validar_personal(string identificacion) 
        {

            cls_funciones_personal obj_validar = new cls_funciones_personal();
            validar = obj_validar.Validar_Registro(identificacion);
            return validar;
        }

        public bool getValidar() { return this.validar; }
    }
}

