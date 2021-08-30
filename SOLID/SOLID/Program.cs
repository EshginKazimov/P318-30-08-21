using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //string groupName = Console.ReadLine();
            //Group g1 = new Group { GroupName = groupName, GroupType = "Programming" };
            //Group g1 = new Group { GroupName = "P410", GroupType = "Programming" };
            //Student s1 = new Student("Fagan", "Eyvazov", g1);
            //Student s1 = new Student("Fagan", "Eyvazov", g1);
            //Student s1 = new Student("Fagan", "Eyvazov", g1);
            //Student s1 = new Student("Fagan", "Eyvazov", g1);
            //Student s1 = new Student("Fagan", "Eyvazov", g1);
            //Student s1 = new Student("Fagan", "Eyvazov", g1);
            //Student s1 = new Student("Fagan", "Eyvazov", g1);
            //Student s1 = new Student("Fagan", "Eyvazov", g1);
            //Student s1 = new Student("Fagan", "Eyvazov", g1);
            //Student s1 = new Student("Fagan", "Eyvazov", g1);

            //StoreFactory store = new StoreFactory(new FileStore());
        }

        static void CalculateArea(/*params object[] figures*/ params IFigure[] figures)
        {
            foreach (var item in figures)
            {
                //if (item is Square square)
                //{
                //    square.GetArea();
                //}
                //else if (item is Rectangle rectangle)
                //{
                //    rectangle.GetArea();
                //}
                item.GetArea();
            }
        }

        static void CalculateArea(Square square)
        {
            square.GetArea();
        }

        static void CalculateArea(Rectangle rectangle)
        {
            rectangle.GetArea();
        }
    }

    #region Single responsibility

    class Group
    {
        public string GroupName { get; set; }

        public string GroupType { get; set; }
    }

    class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public Group Group { get; set; }

        //public string GroupName { get; set; }

        //public string GroupType { get; set; }   

        public Student(string name, string surname, Group group)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }
    }

    #endregion

    #region Open/Closed principle
    //open to extend, closed to modify

    interface IFigure
    {
        int GetArea();
    }

    class Square : IFigure
    {
        public int Length { get; set; }

        public Square(int length)
        {
            Length = length;
        }

        public int GetArea()
        {
            return Length * Length;
        }
    }

    class Rectangle : IFigure
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int GetArea()
        {
            return Length * Width;
        }
    }

    #endregion

    #region Liskov substituation

    abstract class Fruit
    {

    }

    class Apple : Fruit
    {

    }

    class Orange : Fruit
    {

    }

    #endregion

    #region Interface segregation

    interface ICalculate
    {
        void Sum();
        void Difference();
        void Multiply();
        void Divide();
    }

    class Calculator : ICalculate
    {
        public void Difference()
        {
            throw new NotImplementedException();
        }

        public void Divide()
        {
            throw new NotImplementedException();
        }

        public void Multiply()
        {
            throw new NotImplementedException();
        }

        public void Sum()
        {
            throw new NotImplementedException();
        }
    }

    class Test : ISum, IDifference
    {
        public void Difference()
        {
            throw new NotImplementedException();
        }

        public void Sum()
        {
            throw new NotImplementedException();
        }
    }

    interface ISum
    {
        void Sum();
    }

    interface IDifference
    {
        void Difference();
    }

    #endregion

    #region Dependency inversion

    interface IDatabase
    {
        void Connect();
    }

    class Database : IDatabase
    {
        public void Connect()
        {

        }
    }

    class FileStore : IDatabase
    {
        public void Connect()
        {

        }
    }

    class StoreFactory
    {
        public StoreFactory(IDatabase db)
        {
            //Database db = new Database();
            db.Connect();
        }
    }

    #endregion
}
