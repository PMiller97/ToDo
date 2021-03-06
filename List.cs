﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDo
{
    public class List
    { 
        //CANNOT create new property here after controllers are made (scaffolded)
        [Key]
        public int ListID { get; set; }
        public string ListTitle { get; set; }
        public DateTime ListCreateDate { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}