using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListItem.API.Models
{
    public class ListItem
    {

        public int ListItemID { get; set; }
        public string Description { get; set; }
        public string PriorityClass { get; set; }
        public string PriorityNumber { get; set; }

    }
}