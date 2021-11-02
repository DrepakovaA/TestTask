using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Entities
{
    public class Image : BaseEntity
    {
        public string ImageTitle { get; set; }
        public double Size { set; get; }
        public string Date { set; get; }
        public ushort Price { set; get; }
        public int Number { set; get; } 
        public string Nickname { set; get; }
        public byte[] ImageData { get; set; }

       
    }
}
