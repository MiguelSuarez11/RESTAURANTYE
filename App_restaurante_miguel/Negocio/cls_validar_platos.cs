using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_validar_platos
    {
        
            private bool validar;
            public bool fnt_validar(string codigo)
            {

                cls_funciones_restaurante obj_validar = new cls_funciones_restaurante();
                validar = obj_validar.Validar_Registro(codigo);
                return validar;
            }
            
            public bool getValidar() { return this.validar; }
        }



}

