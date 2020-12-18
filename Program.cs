﻿using System;
using System.IO;

// Note: This core program is from:  https://refactoring.guru/design-patterns/factory-method/csharp/example
//       I did not write this program! Please refer to the code owner at link above.
//       However, I have adapted the program to use the same Shape example used earlier.

    // The Creator class declares the factory method that is supposed to return
    // an object of a Product class. The Creator's subclasses usually provide
    // the implementation of this method. 

    abstract class ShapeCreator
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract IShape FactoryMethod();
        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string ADD()
        {
            var shape = FactoryMethod();
            return shape.add();
        }

        public string DELETE()
        {
            var shape = FactoryMethod();
            shape.delete();
            return "shape deleted";
        }

        public string UPDATE()
        {
            var shape = FactoryMethod();
            shape.update();
            return "shape updated";

        }
    }

    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
   
    class RectangleFactory : ShapeCreator
    {
        public override IShape FactoryMethod()
        {
            return new RectangleShape();
        }
    }

    class CircleFactory : ShapeCreator
    {
        public override IShape FactoryMethod()
        {
            return new CircleShape();
        }
    }
    
    class EllipseFactory : ShapeCreator
    {
        public override IShape FactoryMethod()
        {
            return new EllipseShape();
        }
    }

    class LineFactory : ShapeCreator
    {
        public override IShape FactoryMethod()
        {
            return new LineShape();
        }
    }
    
    class PathFactory : ShapeCreator
    {
        public override IShape FactoryMethod()
        {
            return new PathShape();
        }
    }

    class PolygonFactory : ShapeCreator
    {
        public override IShape FactoryMethod()
        {
            return new PolygonShape();
        }
    }

    class PolylineFactory : ShapeCreator
    {
        public override IShape FactoryMethod()
        {
            return new PolylineShape();
        }
    }
    // The Product interface declares the operations that all concrete products
    // must implement.

    public interface IShape
    {

        public string add();
        public void delete();
        public void update();
    }

    // Concrete Products provide various implementations of the Product
    // interface.
  
    class RectangleShape : IShape
    {
        public string add()
        {
            Console.WriteLine("Rectangle id =");
            var id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle Height =");
            var height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle Width =");
            var width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle rx =");
            var rx = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle ry = ");
            var ry = Int32.Parse(Console.ReadLine());
            string dispSVG =
                String.Format(
                    @"<rect id=""{0}"" width=""{1}"" height=""{2}"" rx=""{3}"" ry = ""{4}""/>", id, height, width,
                    rx, ry);
            return "".PadLeft(3, ' ') + dispSVG; 
        }
        public void delete()
        {
            Console.WriteLine("Enter id of shape to delete");
            string path = "./sample.txt";
            string line = null;
            string id = Console.ReadLine();
            string line_to_delete = String.Format(@"id=""{0}"" ", id);
            string strSearchText = line_to_delete;
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(path);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(path, n);
        }
        public void update()
        {
            delete();
            add();
        }
    }

    class CircleShape : IShape
    {
        public string add()
        {
            Console.WriteLine("Circle id =");
            var id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Circle x =");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Circle y =");
            var y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Circle radius =");
            var r = Int32.Parse(Console.ReadLine());
            string dispSVG =
                String.Format(
                    @"<circle id=""{0}"" cx=""{1}"" cy=""{2}"" r=""{3}""/>", id, x, y,
                    r);
            return "".PadLeft(3, ' ') + dispSVG; 
        }

        public void delete()
        {
            Console.WriteLine("Enter id of shape to delete");
            string path = "./sample.txt";
            string line = null;
            string id = Console.ReadLine();
            string line_to_delete = String.Format(@"id=""{0}"" ", id);
            string strSearchText = line_to_delete;
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(path);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(path, n); 
        }

        public void update()
        {
            delete();
            add(); 
        }
        
    }

    class EllipseShape : IShape
    {
        public string add()
        {
            Console.WriteLine("Ellipse  id =");
            var id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ellipse  cx=");
            var cx = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ellipse  cy=");
            var cy = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ellipse rx =");
            var rx = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ellipse ry = ");
            var ry = Int32.Parse(Console.ReadLine());
            string dispSVG =
                String.Format(
                    @"<ellipse id=""{0}"" cx=""{1}"" cy=""{2}"" rx=""{3}"" ry=""{4}""/>", id, cx, cy,
                    rx, ry);
            return "".PadLeft(3, ' ') + dispSVG; 
        }

        public void delete()
        {
            Console.WriteLine("Enter id of shape to delete");
            string path = "./sample.txt";
            string line = null;
            string id = Console.ReadLine();
            string line_to_delete = String.Format(@"id=""{0}"" ", id);
            string strSearchText = line_to_delete;
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(path);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(path, n); 
        }

        public void update()
        {
            delete();
            add();
        }
    }

    class LineShape : IShape
    {
        public string add()
        {
            Console.WriteLine("Line  id =");
            var id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Line  x1=");
            var x1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Line  y1=");
            var y1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Line x2 =");
            var x2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Line y2 = ");
            var y2 = Int32.Parse(Console.ReadLine());
            string dispSVG =
                String.Format(
                    @"<line id=""{0}"" x1=""{1}"" y1=""{2}"" x2=""{3}"" y2 = ""{4}""/>", id, x1, y1,
                    x2, y2);
            return "".PadLeft(3, ' ') + dispSVG; 
        }

        public void delete()
        {
            Console.WriteLine("Enter id of shape to delete");
            string path = "./sample.txt";
            string line = null;
            string id = Console.ReadLine();
            string line_to_delete = String.Format(@"id=""{0}"" ", id);
            string strSearchText = line_to_delete;
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(path);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(path, n);  
        }

        public void update()
        {
            add();
            delete();
        }
    }
    
    class PathShape : IShape
    {
        public string add()
        {
            Console.WriteLine("path id =");
            var id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("path d =");
            var d = Int32.Parse(Console.ReadLine());
            string dispSVG =
                String.Format(
                    @"<path id=""{0}"" d = ""{1}""/>", id, d);
            return "".PadLeft(3, ' ') + dispSVG; 
        }

        public void delete()
        {
            Console.WriteLine("Enter id of shape to delete");
            string path = "./sample.txt";
            string line = null;
            string id = Console.ReadLine();
            string line_to_delete = String.Format(@"id=""{0}"" ", id);
            string strSearchText = line_to_delete;
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(path);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(path, n);
        }

        public void update()
        {
            delete();
            add();
        }
    }

    class PolylineShape : IShape
    {
        public string add()
        {
            Console.WriteLine("polyline id =");
            var id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("polyline points =");
            var points = Int32.Parse(Console.ReadLine());
            string dispSVG =
                String.Format(
                    @"<polyline id=""{0}"" points = ""{1}""/>", id, points);
            return "".PadLeft(3, ' ') + dispSVG;  
        }

        public void delete()
        {
            Console.WriteLine("Enter id of shape to delete");
            string path = "./sample.txt";
            string line = null;
            string id = Console.ReadLine();
            string line_to_delete = String.Format(@"id=""{0}"" ", id);
            string strSearchText = line_to_delete;
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(path);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(path, n); 
        }

        public void update()
        {
            delete();
            add();
        }
    }
    class PolygonShape : IShape
    {
        public string add()
        {
            Console.WriteLine("polygon id =");
            var id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("polygon points =");
            var points = Int32.Parse(Console.ReadLine());
            string dispSVG =
                String.Format(
                    @"<polygon id=""{0}"" points = ""{1}""/>", id, points);
            return "".PadLeft(3, ' ') + dispSVG; 
        }

        public void delete()
        {
            Console.WriteLine("Enter id of shape to delete");
            string path = "./sample.txt";
            string line = null;
            string id = Console.ReadLine();
            string line_to_delete = String.Format(@"id=""{0}"" ", id);
            string strSearchText = line_to_delete;
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(path);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(path, n); 
        }

        public void update()
        {
            delete();
            add();
        }
    }

    class ShapeClient
    {
        public void Main()
        {
            Console.WriteLine("options:");
            Console.WriteLine("C        Circle");
            Console.WriteLine("E        Ellipse");
            Console.WriteLine("L        Line");
            Console.WriteLine("P        Path");
            Console.WriteLine("PG       Polygon");
            Console.WriteLine("PL       Polyline");
            Console.WriteLine("R        Rectangle");
            string a = Console.ReadLine();
            if (a == "R")
            {
                ClientCode(new RectangleFactory());
            }
            else if (a == "C")
            {
                ClientCode(new CircleFactory());
            }
            else if (a == "E")
            {
                ClientCode(new EllipseFactory());
            }
            else if (a == "L")
            {
                ClientCode(new LineFactory());
            }
            else if (a == "P")
            {
                ClientCode(new PathFactory());
            }
            else if (a == "PG")
            {
                ClientCode(new PolygonFactory());
            }
            else if (a == "PL")
            {
                ClientCode(new PolylineFactory());
            }
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void ClientCode(ShapeCreator creator)
        {
            Console.WriteLine("options:");
            Console.WriteLine("add");
            Console.WriteLine("delete");
            Console.WriteLine("update");
            string path = "./sample.txt";
            if (!File.Exists(path))
            {
                File.CreateText(path);
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                var b = Console.ReadLine();
                if (b == "add")
                {
                    sw.Dispose();
                    sw.WriteLine(creator.ADD());
                }
                else if (b == "delete")
                {
                    sw.Dispose();
                    Console.WriteLine(creator.DELETE());
                }
                else if (b == "update")
                {
                    sw.Dispose();
                    Console.WriteLine(creator.UPDATE());
                }
                else
                {
                    Console.WriteLine("Not an input!");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("options:");
            Console.WriteLine("Add Shape");
            Console.WriteLine("Add Style");
            Console.WriteLine("Export");
            var input = Console.ReadLine();
            if (input == "Add Shape")
            {
                new ShapeClient().Main();
            }
            else if (input == "Add Style")
            {
                ShapeBuilder builder;
                Shapes shape = new Shapes();
                Console.WriteLine("options:");
                Console.WriteLine("C        Circle");
                Console.WriteLine("E        Ellipse");
                Console.WriteLine("L        Line");
                Console.WriteLine("P        Path");
                Console.WriteLine("PG       Polygon");
                Console.WriteLine("PL       Polyline");
                Console.WriteLine("R        Rectangle");
                String b = Console.ReadLine();
                if (b == "C")
                {
                    builder = new CircleBuilder();
                    shape.Construct(builder);
                    builder.Shape.addToTXT(); 
                }
                else if (b == "E")
                {
                    builder = new EllipseBuilder();
                    shape.Construct(builder);
                    builder.Shape.addToTXT(); 
                }
                else if (b == "R")
                {
                    builder = new RectangleBuilder();
                    shape.Construct(builder);
                    builder.Shape.addToTXT(); 
                }
                else if (b == "L")
                {
                    builder = new LineBuilder();
                    shape.Construct(builder);
                    builder.Shape.addToTXT(); 
                }
                else if (b == "P")
                {
                    builder = new PathBuilder();
                    shape.Construct(builder);
                    builder.Shape.addToTXT(); 
                }
                else if (b == "PG")
                {
                    builder = new PolygonBuilder();
                    shape.Construct(builder);
                    builder.Shape.addToTXT(); 
                }
                else if (b == "PL")
                {
                    builder = new PolylineBuilder();
                    shape.Construct(builder);
                    builder.Shape.addToTXT(); 
                }
                else
                {
                    Console.WriteLine("Not an input!");
                }
            }
            else if (input == "Export")
            {
                string path = "./sample.svg";
                if (!File.Exists(path))
                {
                    File.CreateText(path);
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(String.Format(@"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">"));
                }
                string content = File.ReadAllText("./sample.txt");
                File.AppendAllText("./sample.svg", content);
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(String.Format(@"</svg>"));
                }
            }
            else
            {
                Console.WriteLine("Not an input!");
            }
           
        }
    }
