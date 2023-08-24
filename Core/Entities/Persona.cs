using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Persona : BaseEntity
{
    public int IdPersona { get; set; }
    public string NombrePersona { get; set; }
    public DateTime FechaNac { get; set; }
    public int IdTipoPer { get; set; }
    public TipoPersona? TipoPersona { get; set; }
    public ICollection<ProductoPersona> ProductosPersonas { get; set; }
}
