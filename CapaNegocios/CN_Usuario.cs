using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class CN_Usuario
    {

        private CD_Usarios objcD_Usarios = new CD_Usarios();

        public List<Usuario> Listar()
        {
            return objcD_Usarios.Listar();
        }


    }
}
