using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blueskyapi.Models
{
    public class Mensaje
    {

        private Estudiante _estudiante;
        private Profesor _profesor;
        private Curso _curso;
        private DateTime _fecha;
        private string _contenido;

        public Estudiante Estudiante
        {
            get
            {
                return _estudiante;
            }

            set
            {
                this._estudiante = value;
            }
        }

        public Profesor Profesor
        {
            get
            {
                return _profesor;
            }

            set
            {
                this._profesor = value;
            }
        }

        public Curso Curso
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

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                this._fecha = value;
            }
        }

        public string Contenido
        {
            get
            {
                return _contenido;
            }

            set
            {
                this._contenido = value;
            }
        }
    }
}