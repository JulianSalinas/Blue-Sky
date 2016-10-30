using blueskyapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace blueskyapi.Controllers
{
    public class MensajeController : ApiController
    {

        LinqToSqlDataContext linq = new LinqToSqlDataContext();


        [HttpGet]
        public List<Mensaje> GetMensajesProfesor(int idEstudiante, string idCurso) {

            var consulta = ( from mensaje in linq.MENSAJE
                             where mensaje.ESTUDIANTE == idEstudiante && mensaje.CURSO == idCurso
                             select mensaje );

            List<Mensaje> mensajes = new List<Mensaje>();
            foreach(var mensaje in consulta) {

                Estudiante est = new Estudiante() {
                    Nombre = mensaje.ESTUDIANTE1.NOMBRE,
                    Carnet = (int) mensaje.ESTUDIANTE1.CARNET,
                    Correo = mensaje.ESTUDIANTE1.CORREO
                };

                Profesor prof = new Profesor() {
                    Nombre = mensaje.PROFESOR1.NOMBRE,
                    Carnet = (int) mensaje.PROFESOR1.CARNET,
                    Correo = mensaje.PROFESOR1.CORREO
                };

                Curso cur = new Curso() {
                    Id = mensaje.CURSO1.ID,
                    Codigo = mensaje.CURSO1.CODIGO,
                    Profesor = (int) mensaje.CURSO1.PROFESOR,
                    Nombre = mensaje.CURSO1.NOMBRE,
                    NumGrupo = (int) mensaje.CURSO1.NGRUPO,
                    FechaInicio = mensaje.CURSO1.FECHA_INICIO,    
                };

                Mensaje mens = new Mensaje() {
                    Profesor = prof,
                    Estudiante = est,
                    Curso = cur,
                    Fecha = mensaje.FECHA,
                    Contenido = mensaje.CONTENIDO
                };

                mensajes.Add(mens);

            }

            return mensajes;

        }



    }
}
