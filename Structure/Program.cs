using System;

namespace Structure
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу, в которой создайте структуру с именем – Notebook(Блокнот), структура
        // должна содержать следующие поля: модель, производитель, цена.В структуре реализуйте
        //конструктор для инициализации полей и метод для вывода содержимого полей на экран.
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.ManufacturT();
            notebook.ModelT();
            notebook.CostT();
            notebook.InfoShow();
        }
    }
    struct Notebook {
        private int Model;
        private string Manufacturer;
        private int Cost;
        public void ManufacturT(){
            Console.Write("Введите название производителя телефона: ");
            string ManufacturT = Console.ReadLine();
            Manufacturer = ManufacturT;
        }
        public void ModelT()
        {
            Console.Write("Введите модель телефона: ");
            int ModelT = int.Parse(Console.ReadLine());
            Model = ModelT;
        }
        public void CostT(){
            Console.Write("Введите цену телефона: ");
            int CostT = int.Parse(Console.ReadLine());
            Cost = CostT;
        }
        public void InfoShow(){
            Console.WriteLine(Model + " - Модель телефона");
            Console.WriteLine(Manufacturer + " - Производитель телефона");
            Console.WriteLine(Cost + " - Цена телефона");
        }

    }

}
