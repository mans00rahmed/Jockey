using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Jockey.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
