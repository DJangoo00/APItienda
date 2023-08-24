using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Producto : BaseEntity
{
    public int CodInterno { get; set; }
    public string Nombre { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
    public int Stock { get; set; }
    public double ValorVta { get; set; }
    public ICollection<ProductoPersona> ProductosPersonas { get; set; }
}
