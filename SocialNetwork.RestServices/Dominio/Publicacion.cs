using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.RestServices.Dominio
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public Privacidad Privacidad { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}