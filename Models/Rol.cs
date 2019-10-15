using System;
using System.Collections.Generic;

namespace CRUD_MVC
{
    public partial class Rol
    {
        public decimal IdRol { get; set; }
        public string NombreRol { get; set; }
        public decimal FkRol { get; set; }

        public virtual Usuario FkRolNavigation { get; set; }
    }
}
