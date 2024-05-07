using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Спробуємо створити два екземпляри класу Authenticator
            Authenticator auth1 = Authenticator.GetInstance();
            Authenticator auth2 = Authenticator.GetInstance();

            // Перевіримо, чи обидва екземпляри вказують на один і той же об'єкт
            if (auth1 == auth2)
            {
                Console.WriteLine("auth1 і auth2 вказують на один і той же екземпляр класу Authenticator.");
            }
            else
            {
                Console.WriteLine("auth1 і auth2 вказують на різні екземпляри класу Authenticator.");
            }
        }
    }
}
