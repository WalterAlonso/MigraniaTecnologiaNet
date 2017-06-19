using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Migraine.Models
{
    public class Drink
    {
        public int id { get; set; }
        public int migraine_id { get; set; }
        public int drink_id { get; set; }
    }
}