using blueskyapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace blueskyapi.Controllers
{
    public class LoginController : ApiController
    {

        LinqToSqlDataContext linq = new LinqToSqlDataContext();

        [HttpGet]
        public Sesion LogIn (int carnet, string contrasenha) {

            List<Usuario> candidatos = new List<Usuario>();

            var usuario_1 = (   from profesor in linq.PROFESOR
                                where profesor.CARNET == carnet
                                select profesor );

            foreach (PROFESOR profesor in usuario_1) {
                Usuario usuario = new Usuario() {
                    Carnet = (int) profesor.CARNET,
                    Contrasenha = profesor.CONTRASENHA,
                    Correo = profesor.CORREO,
                    Nombre = profesor.NOMBRE,
                    Tipo = "Profesor"
                };
                candidatos.Add(usuario);
            }

            if(candidatos.Count == 0) {
                var usuario_2 = ( from estudiante in linq.ESTUDIANTE
                                    where estudiante.CARNET == carnet
                                    select estudiante);

                foreach (ESTUDIANTE estudiante in usuario_2 ) {
                    Usuario usuario = new Usuario() {
                        Carnet = (int) estudiante.CARNET,
                        Contrasenha = estudiante.CONTRASENHA,
                        Correo = estudiante.CORREO,
                        Nombre = estudiante.NOMBRE,
                        Tipo = "Estudiante"
                    };
                    candidatos.Add(usuario);
                }
            }

            if ( candidatos.Count == 0 )
                return null;

            Usuario usuario_3 = candidatos.ElementAt(0);
            if ( usuario_3.Contrasenha == contrasenha )
                return new Sesion() {
                    Usuario = candidatos.ElementAt(0),
                    Mensaje = "Bienvenido " + candidatos.ElementAt(0).Nombre
                };
            else
                return new Sesion() { Mensaje = "La contraseña no coincide" };

        }
    }
}
