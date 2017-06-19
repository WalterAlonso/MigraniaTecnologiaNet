using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Migraine.Models
{
    public class Migraine
    {
        public int id { get; set; }
        public int pain_level { get; set; }
        public string audio_file { get; set; }
    }
}