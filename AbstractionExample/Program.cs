using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFigure> figures = new List<IFigure>();
            double totalArea = 0;
            Console.Write("Number of figures: ");
            int figuresCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < figuresCount; i++)
                figures.Add(InputFigure()); //полиморфизъм - един тип на променливите, няколко типа на обектите
            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine("Perimeter of figure {0}: {1}", i + 1, figures[i].Perimeter());
                totalArea += figures[i].Area(); //абстракция (знаем какво прави метода, не знаем как го прави)
            }
            Console.WriteLine("Total area: {0}", totalArea);
        }
        static IFigure InputFigure()
        {
            Console.Write("Type of figure (circle or square): ");
            string type = Console.ReadLine();
            switch (type.ToLower())
            {
                case "circle":
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    return new Circle(radius); //Circle имплементира IFigure, така че можем да върнем обект от този клас
                case "square":
                    Console.Write("Side: ");
                    double side = double.Parse(Console.ReadLine());
                    return new Square(side); //Square имплементира IFigure, така че можем да върнем обект от този клас
                default:
                    Console.WriteLine("Cannot add figure of type \"{0}\"!", type);
                    return InputFigure(); //не можем да въведем фигура, даваме възможност за ново въвеждане
            }
        }
    }
}