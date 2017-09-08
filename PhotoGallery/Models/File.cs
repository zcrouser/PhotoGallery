using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RousersNet.Models
{
    public class File
    {
        public virtual Guid FileId { get; set; }

        public virtual string FileName { get; set; }

        public virtual string ContentType { get; set; }

        public virtual string ContentLocation { get; set; }
    }

    public class CatagoryImageFile : File { }

    public class UserImageFile : File { }

    public class ImagesFile : File { }

}