using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blueskyapi.Models
{
    public class Asignacion
    {

        private string _id;
        private string _curso;
        private string _nombre;
        private string _tipo;
        private string _medioEntrega;
        private decimal _porcentaje;
        private DateTime _fechaEntrega;
        private string _descripcion;

        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                this._id = value;
            }
        }

        public string Curso
        {
            get
            {
                return _curso;
            }

            set
            {
                this._curso = value;
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

        public string Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                this._tipo = value;
            }
        }

        public string MedioEntrega
        {
            get
            {
                return _medioEntrega;
            }

            set
            {
                this._medioEntrega = value;
            }
        }

        public decimal Porcentaje
        {
            get
            {
                return _porcentaje;
            }

            set
            {
                this._porcentaje = value;
            }
        }

        public DateTime FechaEntrega
        {
            get
            {
                return _fechaEntrega;
            }

            set
            {
                this._fechaEntrega = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                this._descripcion = value;
            }
        }
    }
}