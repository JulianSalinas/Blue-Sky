using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blueskyapi.Models
{
    public class Sesion
    {
        private Usuario usuario;
        private string mensaje;

        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                this.usuario = value;
            }
        }

        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                this.mensaje = value;
            }
        }
    }


}