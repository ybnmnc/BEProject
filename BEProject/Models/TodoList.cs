using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BEProject.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        [NotMapped]
        public int EntityId
        {
            get { return Id; }
            set { Id = value; }
        }
    }
}