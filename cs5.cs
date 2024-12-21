using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jkhjkg
{
    class Money
    {
        protected int wholePart;
        protected int centsPart;

        public Money(int wholePart, int centsPart)
        {
            this.wholePart = wholePart;
            this.centsPart = centsPart;
        }

        public void SetValues(int whole, int cents)
        {
            wholePart = whole;
            centsPart = cents;
        }

        public void Display()
        {
            Console.WriteLine($"Сума: {wholePart}.{centsPart:D2}");
        }
    }

    class Product : Money
    {
        private string productName;

        public Product(string name, int wholePart, int centsPart) : base(wholePart, centsPart)
        {
            productName = name;
        }

        public void ReducePrice(int reduction)
        {
            if (reduction >= 0)
            {
                wholePart -= reduction;
                if (wholePart < 0)
                {
                    wholePart = 0;
                    centsPart = 0;
                }
            }
        }

        public void ShowProduct()
        {
            Console.WriteLine($"Продукт: {productName}");
            Display();
        }
    }

    // Завдання 2: Клас Device та похідні класи
    class Device
    {
        protected string name;
        protected string characteristics;

        public Device(string name, string characteristics)
        {
            this.name = name;
            this.characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Звук пристрою");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Назва пристрою: {name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Опис: {characteristics}");
        }
    }

    class Kettle : Device
    {
        public Kettle(string characteristics) : base("Чайник", characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Шипіння води в чайнику");
        }
    }

    class Microwave : Device
    {
        public Microwave(string characteristics) : base("Мікрохвильовка", characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Звук мікрохвильової печі");
        }
    }

    class Car : Device
    {
        public Car(string characteristics) : base("Автомобіль", characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Звук автомобіля");
        }
    }

    class Steamboat : Device
    {
        public Steamboat(string characteristics) : base("Пароплав", characteristics) { }

        public override void Sound()
        {
            Console.WriteLine("Гудок пароплава");
        }
    }

    // Завдання 3: Клас MusicalInstrument та похідні класи
    abstract class MusicalInstrument
    {
        protected string name;
        protected string characteristics;

        public MusicalInstrument(string name, string characteristics)
        {
            this.name = name;
            this.characteristics = characteristics;
        }

        public abstract void Sound();
        public void Show() => Console.WriteLine($"Назва інструменту: {name}");
        public void Desc() => Console.WriteLine($"Опис: {characteristics}");
        public abstract void History();
    }

    class Violin : MusicalInstrument
    {
        public Violin(string characteristics) : base("Скрипка", characteristics) { }

        public override void Sound() => Console.WriteLine("Звук скрипки");
        public override void History() => Console.WriteLine("Скрипка була створена у XVI столітті в Італії.");
    }

    class Trombone : MusicalInstrument
    {
        public Trombone(string characteristics) : base("Тромбон", characteristics) { }

        public override void Sound() => Console.WriteLine("Звук тромбона");
        public override void History() => Console.WriteLine("Тромбон з'явився у XV столітті в Європі.");
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele(string characteristics) : base("Укулеле", characteristics) { }

        public override void Sound() => Console.WriteLine("Звук укулеле");
        public override void History() => Console.WriteLine("Укулеле походить з Португалії і була популяризована на Гаваях.");
    }

    class Cello : MusicalInstrument
    {
        public Cello(string characteristics) : base("Віолончель", characteristics) { }

        public override void Sound() => Console.WriteLine("Звук віолончелі");
        public override void History() => Console.WriteLine("Віолончель виникла у XVI столітті.");
    }

    // Завдання 4: Абстрактний клас Worker та похідні класи
    abstract class Worker
    {
        public abstract void Print();
    }

    class President : Worker
    {
        public override void Print() => Console.WriteLine("Президент: керівник компанії.");
    }

    class Security : Worker
    {
        public override void Print() => Console.WriteLine("Охоронець: забезпечує безпеку.");
    }

    class Manager : Worker
    {
        public override void Print() => Console.WriteLine("Менеджер: керує проектами.");
    }

    class Engineer : Worker
    {
        public override void Print() => Console.WriteLine("Інженер: розробляє технічні рішення.");
    }

    // Головний клас для тестування
    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1
            Product product = new Product("Молоко", 5, 50);
            product.ShowProduct();
            product.ReducePrice(2);
            product.ShowProduct();

            // Завдання 2
            Kettle kettle = new Kettle("Чайник на 2 літри");
            kettle.Sound();
            kettle.Show();
            kettle.Desc();

            // Завдання 3
            Violin violin = new Violin("Дерев'яний музичний інструмент");
            violin.Sound();
            violin.Show();
            violin.Desc();
            violin.History();

            // Завдання 4
            Worker president = new President();
            Worker security = new Security();
            Worker manager = new Manager();
            Worker engineer = new Engineer();

            president.Print();
            security.Print();
            manager.Print();
            engineer.Print();
        }
    }
}