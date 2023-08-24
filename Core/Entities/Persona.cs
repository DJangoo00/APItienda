using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Persona
    {
        public int Id { get; set;}
        public int IdPersona { get; set;}
        public string NombrePersona { get; set;}
        public DateTime FechaNac { get; set;}
        public int IdTipoPer { get; set;}
    }
}