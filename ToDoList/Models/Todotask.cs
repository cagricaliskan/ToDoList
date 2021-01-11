using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Todotask
    {
        public int TodotaskID { get; set; }
        [Required]
        public string TodotaskName { get; set; }

        public bool isDone { get; set; }

        public Todotask()
        {
            isDone = false;
        }
    }
}
