using System;
using System.Text;

namespace Console5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            var editor = new TextEditor("");

            while (true)
            {
                Console.WriteLine("Оберіть операцію:");
                Console.WriteLine("1. Додати або редагувати текст");
                Console.WriteLine("2. Зберегти");
                Console.WriteLine("3. Відмінити");
                Console.WriteLine("4. Вивести документ");
                Console.WriteLine("5. Повернутися до збереження");
                Console.WriteLine("6. Вийти");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        editor.Type();
                        break;
                    case "2":
                        editor.Save();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Зміни успішно збережено.");
                        Console.ResetColor();
                        break;
                    case "3":
                        editor.Undo();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Відмінено останню дію.");
                        Console.ResetColor();
                        break;
                    case "4":
                        editor.Print();
                        break;
                    case "5":
                        if (editor.GetHistoryCount() > 0)
                        {
                            Console.WriteLine("Оберіть збереження, до якого хочете повернутися:");
                            for (int i = 0; i < editor.GetHistoryCount(); i++)
                            {
                                Console.WriteLine($"{i + 1}. {editor.GetHistoryDate(i)}");
                            }
                            int restoreChoice;
                            while (!int.TryParse(Console.ReadLine(), out restoreChoice) || restoreChoice < 1 || restoreChoice > editor.GetHistoryCount())
                            {
                                Console.WriteLine("Введіть коректний номер збереження.");
                            }
                            editor.Restore(restoreChoice - 1);
                        }
                        else
                        {
                            Console.WriteLine("Немає збережень для відновлення.");
                        }
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }

                Console.WriteLine(); // Переведення рядка для наступного виведення опцій
            }
        }
    }
}
