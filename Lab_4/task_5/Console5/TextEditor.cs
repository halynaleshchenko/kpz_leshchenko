using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    class TextEditor
    {
        private TextDocument _document;
        private List<DocumentMemento> _history = new List<DocumentMemento>();

        public TextEditor(string content)
        {
            _document = new TextDocument(content);
        }

        public void Type()
        {
            Console.WriteLine("Оберіть операцію:");
            Console.WriteLine("1. Додати текст");
            Console.WriteLine("2. Редагувати існуючий текст");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введіть текст для додавання:");
                    var textToAdd = Console.ReadLine();
                    _document.Content += textToAdd;
                    break;
                case "2":
                    Console.WriteLine("Введіть новий текст для заміни:");
                    var newText = Console.ReadLine();
                    Console.WriteLine("Введіть позицію, з якої потрібно почати заміну:");
                    int position;
                    while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position > _document.Content.Length)
                    {
                        Console.WriteLine("Введіть коректну позицію.");
                    }
                    Console.WriteLine("Введіть кількість символів, які потрібно замінити:");
                    int length;
                    while (!int.TryParse(Console.ReadLine(), out length) || length <= 0 || position + length > _document.Content.Length)
                    {
                        Console.WriteLine("Введіть коректну кількість символів.");
                    }
                    _document.Content = _document.Content.Remove(position, length).Insert(position, newText);
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }


        public void Save()
        {
            var dateTimeNow = DateTime.Now;
            var memento = new DocumentMemento(_document.Content, dateTimeNow);
            _history.Add(memento);
        }

        public void Undo()
        {
            if (_history.Count > 1)
            {
                _history.RemoveAt(_history.Count - 1);
                var lastMemento = _history[_history.Count - 1];
                _document.Content = lastMemento.Content;
                Console.WriteLine($"Повернено до останнього збереження: {lastMemento.DateTime}.");
            }
            else
            {
                Console.WriteLine("Збереження відсутні.");
            }
        }

        public void Print()
        {
            Console.WriteLine(_document.Content);
        }

        public int GetHistoryCount()
        {
            return _history.Count;
        }

        public DateTime GetHistoryDate(int index)
        {
            return _history[index].DateTime;
        }

        public void Restore(int index)
        {
            if (_history.Count > 0)
            {
                var memento = _history[index];
                _document.Content = memento.Content;
                Console.WriteLine($"Повернено до збереження: {memento.DateTime}.");
            }
            else
            {
                Console.WriteLine("Збереження відсутні.");
            }
        }

        private class DocumentMemento
        {
            public string Content { get; }
            public DateTime DateTime { get; }

            public DocumentMemento(string content, DateTime dateTime)
            {
                Content = content;
                DateTime = dateTime;
            }
        }
    }
}
