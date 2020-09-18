using System;
using System.Collections.Generic;

namespace DIARS_T1.Models
{
    public partial class Ciudad
    {
        public Ciudad()
        {
            Persona = new HashSet<Persona>();
        }

        public int IdCiudad { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Persona> Persona { get; set; }
    }
}
