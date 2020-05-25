using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    
    public class PhotoModel
    {
        public int Id{ get; set; }
        public int OwnerId { get; set; }
        public string Path { get; set; }
    }
}