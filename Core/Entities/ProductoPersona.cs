using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class ProductoPersona
{
    public int IdProducto { get; set; }
    public Producto? Producto { get; set; }
    public int IdPersona { get; set; }
    public Persona? Persona { get; set; }
}
