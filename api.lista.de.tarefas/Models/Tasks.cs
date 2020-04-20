using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace todoWebApi.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        public string Task { get; set; }
        public Boolean Done { get; set; }
    }
}
