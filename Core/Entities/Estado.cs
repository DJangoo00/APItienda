using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Estado
    {
        public int Id { get; set;}
        public string NombreEstado { get; set;}
        public int IdPaisFk { get; set;}
        
    }
}