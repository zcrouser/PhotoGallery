using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RousersNet.Models
{
    public class Catagory
    {
        public virtual int CatagoryId { get; set; }

        public virtual string Name { get; set; }

        public virtual CatagoryImageFile Image { get; set; }
    }
}