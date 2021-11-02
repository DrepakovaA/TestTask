using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Entities
{
    public class Image : BaseEntity
    {
        public string ImageTitle { get; set; }
        public double Size { set; get; }//размер фото (если пиксели?)
        public string Date { set; get; }//string(Convert)?Дата
        public ushort Price { set; get; }// стоимость
        public int Number { set; get; } //количество покупок
        public string Nickname { set; get; }//ник
        public byte[] ImageData { get; set; }

       
    }
}
