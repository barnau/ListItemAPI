using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ListItem.API.Infrastructure
{
    public class ListItemDataContext : DbContext
    {
        public ListItemDataContext() : base("MyListItemDatabase")
        {

        }
        public IDbSet<Models.ListItem> ListItems { get; set; }
    }
}