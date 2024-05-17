using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Console4
{
    public class Image
    {
        public void LoadImage(string href)
        {
            if (IsFile(href))
            {
                LoadFromFile(href);
            }
            else
            {
                LoadFromUrl(href);
            }
        }

        private bool IsFile(string href)
        {
            return !Uri.IsWellFormedUriString(href, UriKind.Absolute);
        }

        private void LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    // Загрузка картинки з файлової системи
                    Console.WriteLine($"Loading image from file: {filePath}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image from file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"File not found: {filePath}");
            }
        }

        private void LoadFromUrl(string url)
        {
            try
            {
                // Загрузка картинки з мережі
                Console.WriteLine($"Loading image from URL: {url}");
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(url);
                    // Обробка отриманих даних картинки
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image from URL: {ex.Message}");
            }
        }
    }
}
