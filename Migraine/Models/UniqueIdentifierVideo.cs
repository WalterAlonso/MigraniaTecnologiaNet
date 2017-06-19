using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Migraine.Models
{
    public class UniqueIdentifierVideo
    {
        private static int identifierVideo = 0;

        private UniqueIdentifierVideo()
        {

        }

        public static int getNextIdVideo()
        {
            return identifierVideo += 1; 
        }
    }
}