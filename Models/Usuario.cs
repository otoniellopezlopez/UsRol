using System;
using System.Collections.Generic;

namespace CRUD_MVC
{
    public partial class Usuario
    {
        public Usuario()
        {
            Rol = new HashSet<Rol>();
        }

        public decimal IdUsuario { get; set; }
        public string ClaveUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string PasUsuario { get; set; }

        public virtual ICollection<Rol> Rol { get; set; }
    }
}
