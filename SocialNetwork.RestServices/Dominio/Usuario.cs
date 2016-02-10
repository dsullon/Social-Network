using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.RestServices.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nick { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Foto { get; set; }
        public bool EstaActivo { get; set; }
        public bool EnLinea { get; set; }
        public Perfil Perfil { get; set; }
        public DateTime FechaCreacion { get; set; }
        public ICollection<Publicacion> Publicacion { get; set; }
    }
}