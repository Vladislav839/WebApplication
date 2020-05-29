using System.Collections.Generic;
using Microsoft.AspNetCore.Routing.Matching;

namespace WebApp.Models
{
    public class Dialog
    {
        public int Id { get; set; }
        public int FirstPersonId { get; set; }
        public int SecondPersonId { get; set; }
    }
}