using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DIARS_T1.Models
{
    public partial class Persona
    {

        
        public int IdPersona { get; set; }
       
        public string Nombre { get; set; }
       
        public string Apellido { get; set; }
       
        public string Dni{ get; set; }
       
        public DateTime? FachaNacimiento { get; set; }
       
        public string Genero { get; set; }
        
        public int? Ciudad { get; set; }
        
        public string Direccion { get; set; }
       
        public string Correo { get; set; }
       
        public string Usuario { get; set; }
       
        public string Contraseña { get; set; }

        public virtual Ciudad CiudadNavigation { get; set; }
    }
}
