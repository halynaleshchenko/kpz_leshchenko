using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.UTF8;

            // Приклад використання фабричного методу
            SubscriptionFactory factory1 = new WebSite();
            Subscription subscription1 = factory1.CreateSubscription();
            System.Console.WriteLine("Підписка створена через веб-сайт:");
            System.Console.WriteLine($"Щомісячна плата: {subscription1.MonthlyFee}, Мінімальний термін підписки: {subscription1.MinimumSubscriptionPeriod} місяців");
            System.Console.WriteLine("Доступні канали:");
            foreach (var channel in subscription1.AvailableChannels)
            {
                System.Console.WriteLine(channel);
            }

            SubscriptionFactory factory2 = new MobileApp();
            Subscription subscription2 = factory2.CreateSubscription();
            System.Console.WriteLine("\nПідписка створена через мобільний додаток:");
            System.Console.WriteLine($"Щомісячна плата: {subscription2.MonthlyFee}, Мінімальний термін підписки: {subscription2.MinimumSubscriptionPeriod} місяців");
            System.Console.WriteLine("Доступні канали:");
            foreach (var channel in subscription2.AvailableChannels)
            {
                System.Console.WriteLine(channel);
            }

            SubscriptionFactory factory3 = new ManagerCall();
            Subscription subscription3 = factory3.CreateSubscription();
            System.Console.WriteLine("\nПідписка створена через дзвінок менеджера:");
            System.Console.WriteLine($"Щомісячна плата: {subscription3.MonthlyFee}, Мінімальний термін підписки: {subscription3.MinimumSubscriptionPeriod} місяців");
            System.Console.WriteLine("Доступні канали:");
            foreach (var channel in subscription3.AvailableChannels)
            {
                System.Console.WriteLine(channel);
            }
        }
    }

}