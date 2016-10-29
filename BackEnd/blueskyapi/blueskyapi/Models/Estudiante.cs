
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blueskyapi.Models
{
    public class Estudiante
    {

        private int _carnet;
        private string _nombre;
        private string _correo;

        public int Carnet
        {
            get
            {
                return _carnet;
            }

            set
            {
                this._carnet = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                this._nombre = value;
            }
        }

        public string Correo
        {
            get
            {
                return _correo;
            }

            set
            {
                this._correo = value;
            }
        }
    }
}