using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.RestServices.Dominio
{
    public enum Privacidad
    {
        Todos = 1,
        Amigos = 2,
        SoloYo = 3
    }

    public class Perfil
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Privacidad Privacidad { get; set; }
        public string Buscando { get; set; }
        public string Interes { get; set; }
        public string Educacion { get; set; }
        public string Hobbies { get; set; }
        public string Peliculas { get; set; }
        public string Artistas { get; set; }
        public string Libros { get; set; }
    }
}