using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blueskyapi.Models
{
    public class Sesion
    {

        private int carnet;
        private string contrasenha;
        private string nombre;
        private string correo;
        private string tipo;

        public int Carnet
        {
            get
            {
                return carnet;
            }

            set
            {
                this.carnet = value;
            }
        }

        public string Contrasenha
        {
            get
            {
                return contrasenha;
            }

            set
            {
                this.contrasenha = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                this.correo = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                this.tipo = value;
            }
        }
    }
}