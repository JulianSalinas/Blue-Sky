using blueskyapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace blueskyapi.Controllers
{
    public class AsignacionController : ApiController
    {

        LinqToSqlDataContext linq = new LinqToSqlDataContext();


        [HttpGet]
        public List<Asignacion> GetAsignacionesCurso(string idCurso) {

            var consulta = ( from asignacion in linq.ASIGNACION
                             where asignacion.CURSO == idCurso
                             select asignacion );

            List<Asignacion> asignaciones = new List<Asignacion>();
            foreach(var asignacion in consulta) {
                Asignacion asig = new Asignacion() {
                    Id = asignacion.ID,
                    Curso = asignacion.CURSO,
                    Nombre = asignacion.NOMBRE,
                    Tipo = asignacion.TIPO,
                    MedioEntrega = asignacion.MEDIO_ENTREGA,
                    Porcentaje = asignacion.PORCENTAJE,
                    FechaEntrega = asignacion.FECHA_ENTREGA,
                    Descripcion = asignacion.DESCRIPCION
                };
                asignaciones.Add(asig);
            }

            return asignaciones;

        }

    }
}
