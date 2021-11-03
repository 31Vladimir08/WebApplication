﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebApplication.Middleware
{
    [XmlRoot(ElementName = "Images")]
    public class Images
    {
        public Images()
        {
            Pictures = new List<ImageClass>();
        }

        public List<ImageClass> Pictures { get; set; }
    }
}
