using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blueskyapi.Models
{
    public class Curso
    {

        private string _id;
        private string _codigo;
        private int _numGrupo;
        private string _nombre;
        private int _profesor;
        private DateTime _fechaInicio;
        private List<Estudiante> _estudiantes;

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

        public string Codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                this._codigo = value;
            }
        }

        public int NumGrupo
        {
            get
            {
                return _numGrupo;
            }

            set
            {
                this._numGrupo = value;
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

        public int Profesor
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

        public DateTime FechaInicio
        {
            get
            {
                return _fechaInicio;
            }

            set
            {
                this._fechaInicio = value;
            }
        }

        public List<Estudiante> Estudiantes
        {
            get
            {
                return _estudiantes;
            }

            set
            {
                this._estudiantes = value;
            }
        }
    }
}