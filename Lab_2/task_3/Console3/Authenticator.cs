using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    public class Authenticator
    {
        private static Authenticator instance;
        private static readonly object lockObject = new object();

        private Authenticator() { }

        public static Authenticator GetInstance()
        {
            // Перевірка, чи є вже створений екземпляр класу
            if (instance == null)
            {
                // Захищаємо доступ до створення нового екземпляру за допомогою lock
                lock (lockObject)
                {
                    // Ще раз перевіряємо, чи є екземпляр null, бо може бути, що інший потік вже створив його
                    if (instance == null)
                    {
                        instance = new Authenticator();
                    }
                }
            }
            return instance;
        }

        public void Authenticate()
        {
            Console.WriteLine("Authentication successful.");
        }
    }
}
