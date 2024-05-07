using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console4
{
    class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<Virus>();
        }

        // Реалізація клонування через глибоке копіювання
        public object Clone()
        {
            Virus clone = new Virus(Weight, Age, Name, Type);
            foreach (Virus child in Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }
            return clone;
        }

        // Перевизначений метод ToString для зручного виводу інформації про вірус
        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Age: {Age}, Weight: {Weight}";
        }
    }
}
