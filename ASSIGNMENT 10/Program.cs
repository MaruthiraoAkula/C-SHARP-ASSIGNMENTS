using DataModels;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Mapping;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment12
{
    interface IShape
    {
        string ShapeName { get; }
        double Area { get; set; }
        double Circumference { get; set; }
        int TotalSides { get; }

    }
    
    public abstract class Baseclass : IShape
    {
        public double height;

        public abstract double Area { get; set; }
        public abstract double Circumference { get; set; }
        public abstract int TotalSides { get; }
        public abstract string ShapeName { get; }
    }

    public class Circleclass : Baseclass
    {
        
            public double radius;
            const double pi = 3.14;
            public override double Area
            {
              get
                {
                    return pi * radius * radius;
                }
                set
                {
                    radius = value;
                }
            }
            public override double Circumference
            {
                get
                {
                    return 2 * pi * radius;
                }
                set
                {
                    radius = value;
                }
            }
            public override string ShapeName
            {
                get
                {
                    return "Circle";
                }
            }
        
            public override int TotalSides
            {
                get
                {
                    return 0;
                }

            }
      

    }
    public class Triangleclass : Baseclass
    {
        public double triangleBase;
        public double leftside;
        public double rightside;
        public override double Area
        {
            get
            {
                return triangleBase * height / 2;
            }
            set
            {
                Area = value;
            }
        }
        public override double Circumference
        {
            get
            {
                return triangleBase + leftside + rightside;
            }
            set
            {
                Circumference = value;
            }
        }
        public override string ShapeName
        {
            get
            {
                return "Triangle";
            }
        }
        public override int TotalSides
        {
            get
            {
                return 3;
            }
        }
    }
    public class Squareclass : Baseclass
    {
        public int sides;
        public override double Area
        {
            get
            {
                return 4 * sides;
            }
            set
            {
                Area = value;
            }
        }
        public override double Circumference
        {
            get
            {
                return sides * sides;
            }
            set
            {
                Circumference = sides;
            }
        }
        public override string ShapeName
        {
            get
            {
                return "Square";
            }

        }
        public override int TotalSides
        {
            get
            {
                return 4;
            }
        }
    }
    
    public class Rectangleclass : Baseclass
    {
        public double length;
        public double breadth;
        public override double Area
        {
            get
            {
                return length * breadth;
            }
            set
            {
                Area = value;
            }
        }
        public override double Circumference
        {
            get
            {
                return 2 * (length + breadth);
            }
            set
            {
                Circumference = value;
            }
        }
        public override string ShapeName
        {
            get
            {
                return "Rectangle";
            }
        }
        public override int TotalSides
        {
            get
            {
                return 4;
            }
        }

    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            
                Console.WriteLine("Choose one option\n1. Circle\n2. Rectangle\n3. Square\n4. Triangle\n");

                int option = Convert.ToInt32(Console.ReadLine());
                Baseclass obj = null;

                switch (option)
                {

                    case 1:
                        double radius;
                        Console.WriteLine("Enter radius");

                        radius = Convert.ToDouble(Console.ReadLine());
                        obj = new Circleclass()
                        {
                            radius = radius
                        };
                        break;

                    case 2:
                        double length;
                        double breadth;
                        Console.WriteLine("Enter length");

                        length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter breadth");

                        breadth = Convert.ToDouble(Console.ReadLine());
                        obj = new Rectangleclass()
                        {
                            length = length,
                            breadth = breadth
                        };
                        break;
                    case 3:
                        double sideofsquare;
                        Console.WriteLine("Enter the side of the square");

                        sideofsquare = Convert.ToDouble(Console.ReadLine());
                        obj = new Squareclass()
                        {
                            sides = (int)sideofsquare
                        };
                        break;

                    case 4:
                        double trianglebase;
                        double height;
                        double Leftside;
                        double rightside;
                        Console.WriteLine("Enter trianglebase of a triangle");

                        trianglebase = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the height");

                        height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the leftside");

                        Leftside = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Rightside");

                        rightside = Convert.ToDouble(Console.ReadLine());

                        obj = new Triangleclass()
                        {
                            triangleBase = trianglebase,
                            height = height,
                            leftside = Leftside,
                            rightside = rightside,
                        };
                        break;

                    default:
                        Console.WriteLine("Enter valid option");
                        break;
                }
            
            
            if (obj != null)
            {
                Console.WriteLine("Area of Circle is : {0}", obj.Area);
                Console.WriteLine("Circumference of Circle : {0}", obj.Circumference);
                Console.WriteLine("Shape Name is : {0} ", obj.ShapeName);
                Console.WriteLine("Total Sides is : {0}", obj.TotalSides);
                try
                {
                    using (var db = new ShapesDB())
                    {

                        var c = new ShapesDetails1();
                        c.Area = obj.Area;
                        c.Circumference = obj.Circumference;
                        c.TotalSides = obj.TotalSides;
                        c.ShapeName = obj.ShapeName;
                        db.Insert(c);
                        Console.WriteLine("Inserted");

                    }
                    // using LINQ TO SQL Template

                    /*var Ob = @"Data Source=.;Initial Catalog=Shapes;Integrated Security=True";
                     var d = new DataClasses1DataContext();
                     var c = new Shapes_detail();
                       c.ShapeName = obj.ShapeName;
                            c.Area = obj.Area;
                   c.Circumference = obj.Circumference;
                      c.TotalSides = obj.TotalSides;
                     d.Shapes_details.InsertOnSubmit(c);
                     d.SubmitChanges();*/

                    // using SQL
                    /*SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Shapes;Integrated Security=True");
                    connection.Open();
                    Console.WriteLine("Database connected Successfully");
                    SqlCommand command = new SqlCommand("Insert into Shapes_details Values('" + obj.ShapeName + "','"+obj.Area+"','"+obj.Circumference+"','"+obj.TotalSides+"')");
                    command.Connection = connection;
                    if (connection.State == ConnectionState.Open)
                    {
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("Data Inserted Successfully");
                    connection.Close();*/

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid Shape");
            }
        }
    }
}