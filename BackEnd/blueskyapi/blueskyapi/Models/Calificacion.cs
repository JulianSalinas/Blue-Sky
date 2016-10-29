using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blueskyapi.Models
{
    public class Calificacion
    {

        private Estudiante _estudiante;
        private Asignacion _asignacion;
        private float _porcentajeObtenido;
        private float _calificacion;

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

        public Asignacion Asignacion
        {
            get
            {
                return _asignacion;
            }

            set
            {
                this._asignacion = value;
            }
        }

        public float PorcentajeObtenido
        {
            get
            {
                return _porcentajeObtenido;
            }

            set
            {
                this._porcentajeObtenido = value;
            }
        }

        public float Value
        {
            get
            {
                return _calificacion;
            }

            set
            {
                this._calificacion = value;
            }
        }
    }
}