using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Region : BaseEntity
{
    public string Nombre { get; set; }
    public int IdEstadoFk { get; set; }
    public Estado? Estado { get; set; }
}
