using blueskyapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace blueskyapi.Controllers
{
    public class CursoController : ApiController
    {

        LinqToSqlDataContext linq = new LinqToSqlDataContext();

        [HttpGet]
        public List<Curso> GetCursos (int idProfesor) {

            var consulta = ( from curso in linq.CURSO
                             where idProfesor == (int) curso.PROFESOR
                             select curso );

            List<Curso> cursos = new List<Curso>();
            foreach (var curso in consulta) {
                Curso cur = new Curso() {
                    Id = curso.ID,
                    Codigo = curso.CODIGO,
                    Nombre = curso.NOMBRE,
                    NumGrupo = (int) curso.NGRUPO,
                    Profesor = (int) curso.PROFESOR,
                    FechaInicio = curso.FECHA_INICIO,
                    Estudiantes = GetEstudiantesCurso(curso.ID)
                };
                cursos.Add(cur);
            }

            return cursos;

        }

        private List<Estudiante> GetEstudiantesCurso(string idCurso) {

            var consulta = ( from estudianteCurso in linq.CURSO_ESTUDIANTE
                             where idCurso == estudianteCurso.CURSO
                             select estudianteCurso);

            List<Estudiante> estudiantes = new List<Estudiante>();
            foreach ( var estudiante in consulta ) {
                Estudiante est = new Estudiante() {
                    Carnet = (int) estudiante.ESTUDIANTE1.CARNET,
                    Nombre = estudiante.ESTUDIANTE1.CORREO,
                    Correo = estudiante.ESTUDIANTE1.CORREO
                };
                estudiantes.Add(est);

            }

            return estudiantes;

        }


    }
}
