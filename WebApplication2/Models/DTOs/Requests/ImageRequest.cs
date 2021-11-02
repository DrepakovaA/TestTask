using Microsoft.AspNetCore.Http;

namespace WebApplication2.Models.DTOs.Requests
{
    public class ImageRequest
    {
        public IFormFile Image { get; set; }
        public double Size { set; get; }//размер фото (если пиксели?)
        public string Date { set; get; }//string(Convert)?Дата
        public ushort Price { set; get; }// стоимость
        public int Number { set; get; } //количество покупок
        public string Nickname { set; get; }//ник

    }
}
