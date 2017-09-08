using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RousersNet.Models
{
    public class Image
    {
        public virtual int ImageId { get; set; }

        public virtual string Name { get; set; }

        public virtual UserImageFile userImage { get; set; }

        public virtual Catagory Catagory { get; set; }

        public virtual User UploadedBy { get; set; }


    }
}