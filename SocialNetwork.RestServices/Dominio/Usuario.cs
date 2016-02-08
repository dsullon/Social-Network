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
    }
}