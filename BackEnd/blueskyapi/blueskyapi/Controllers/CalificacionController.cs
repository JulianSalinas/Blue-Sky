using blueskyapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace blueskyapi.Controllers
{
    public class CalificacionController : ApiController
    {

        LinqToSqlDataContext linq = new LinqToSqlDataContext();


        [HttpGet]
        public List<Calificacion>GetCalificaciones(string idAsignacion) {

            var consulta = ( from calificacion in linq.ASIGNACION_ESTUDIANTE
                             where calificacion.ASIGNACION == idAsignacion
                             select calificacion );
            List<Calificacion> calificaciones = new List<Calificacion>();
            foreach(var calificacion in consulta) {

                Estudiante est = new Estudiante() {
                    Nombre = calificacion.ESTUDIANTE1.NOMBRE,
                    Carnet = (int) calificacion.ESTUDIANTE1.CARNET,
                    Correo = calificacion.ESTUDIANTE1.CORREO
                };

                Asignacion asig = new Asignacion() {
                    Id = calificacion.ASIGNACION1.ID,
                    Nombre = calificacion.ASIGNACION1.NOMBRE,
                    Curso = calificacion.ASIGNACION1.CURSO,
                    Tipo = calificacion.ASIGNACION1.TIPO,
                    Porcentaje = calificacion.ASIGNACION1.PORCENTAJE,
                    MedioEntrega = calificacion.ASIGNACION1.MEDIO_ENTREGA,
                    FechaEntrega = calificacion.ASIGNACION1.FECHA_ENTREGA,
                    Descripcion = calificacion.ASIGNACION1.DESCRIPCION
                };

                Calificacion cal = new Calificacion() {
                    Estudiante = est,
                    Asignacion = asig,
                    Value = (float) calificacion.CALIFICACION,
                    PorcentajeObtenido = (float) calificacion.PORCENTAJE_OBTENIDO
                };

                calificaciones.Add(cal);
            }

            return calificaciones;


        }



    }
}
