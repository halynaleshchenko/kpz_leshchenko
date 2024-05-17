using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Console4
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new Image();

            // Посилання на фото з файлової системи
            string fileUrl = @"C:\Users\galin\Desktop\photo_2024-03-12_23-52-59.jpg";
            image.LoadImage(fileUrl);

            // Посилання на фото з мережі
            string webUrl = "https://i.pinimg.com/564x/11/6a/de/116adebe04a8dde378d1421eed4c9869.jpg";
            image.LoadImage(webUrl);
        }
    }
}
