using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}