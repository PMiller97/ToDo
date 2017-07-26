using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDo
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }
        [Display(Name ="Description")] //changes the view. so from TaskDescritpion --> Description
        public string TaskDescription { get; set; }
        public bool IsDone { get; set; }
        [Display(Name ="Due Date")]
        public DateTime DueDate { get; set; }

        [ForeignKey("List")] //has to match other class exaclty
        public int ListID { get; set; } //has to be identical to "ListID" from the List class
        public virtual List List { get; set; } // name navigation property the same as your class (navigation property is the second "List")
        //have to have a foreign key and a navigation key
    }
}