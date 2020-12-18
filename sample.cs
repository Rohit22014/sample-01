using System;
using System.Collections.Generic;
using System.IO;

class Shapes

  {
    // Builder uses a complex series of steps

    public void Construct(ShapeBuilder shapeBuilder)
    {
      shapeBuilder.addFill();
      shapeBuilder.addStroke();
      shapeBuilder.addStrokeWidth();
    }
  }
 
  /// <summary>

  /// The 'Builder' abstract class

  /// </summary>

  abstract class ShapeBuilder

  {
    protected Shape shape;
 
    // Gets vehicle instance

    public Shape Shape
    {
      get { return shape; }
    }
 
    // Abstract build methods

    public abstract void addFill();
    public abstract void addStroke();
    public abstract void addStrokeWidth();
  }
 
  /// <summary>

  /// The 'ConcreteBuilder1' class

  /// </summary>

  class CircleBuilder : ShapeBuilder

  {
    public CircleBuilder()
    {
      shape = new Shape("Circle");
    }
 
    public override void addFill()
    {
      Console.WriteLine("Circle fill");
      var a = Console.ReadLine();
      shape["fill"] = a;
    }
 
    public override void addStroke()
    {
      Console.WriteLine("Circle stroke");
      var a = Console.ReadLine();
      shape["stroke"] = a;
    }
 
    public override void addStrokeWidth()
    {
      Console.WriteLine("Circle stroke-width");
      var a = Console.ReadLine();
      shape["stroke-width"] = a;
    }
  }
class EllipseBuilder : ShapeBuilder

{
  public EllipseBuilder()
  {
    shape = new Shape("Ellipse");
  }
 
  public override void addFill()
  {
    Console.WriteLine("Ellipse fill");
    var a = Console.ReadLine();
    shape["fill"] = a;
  }
 
  public override void addStroke()
  {
    Console.WriteLine("Ellipse stroke");
    var a = Console.ReadLine();
    shape["stroke"] = a;
  }
 
  public override void addStrokeWidth()
  {
    Console.WriteLine("Ellipse stroke-width");
    var a = Console.ReadLine();
    shape["stroke-width"] = a;
  }
}
class LineBuilder : ShapeBuilder

{
  public LineBuilder()
  {
    shape = new Shape("Line");
  }
 
  public override void addFill()
  {
    Console.WriteLine("Line fill");
    var a = Console.ReadLine();
    shape["fill"] = a;
  }
 
  public override void addStroke()
  {
    Console.WriteLine("Line stroke");
    var a = Console.ReadLine();
    shape["stroke"] = a;
  }
 
  public override void addStrokeWidth()
  {
    Console.WriteLine("Line stroke-width");
    var a = Console.ReadLine();
    shape["stroke-width"] = a;
  }
}
class PathBuilder : ShapeBuilder

{
  public PathBuilder()
  {
    shape = new Shape("Path");
  }
 
  public override void addFill()
  {
    Console.WriteLine("Path fill");
    var a = Console.ReadLine();
    shape["fill"] = a;
  }
 
  public override void addStroke()
  {
    Console.WriteLine("Path stroke");
    var a = Console.ReadLine();
    shape["stroke"] = a;
  }
 
  public override void addStrokeWidth()
  {
    Console.WriteLine("Path stroke-width");
    var a = Console.ReadLine();
    shape["stroke-width"] = a;
  }
}
class PolygonBuilder : ShapeBuilder

{
  public PolygonBuilder()
  {
    shape = new Shape("Polygon");
  }
 
  public override void addFill()
  {
    Console.WriteLine("Polygon fill");
    var a = Console.ReadLine();
    shape["fill"] = a;
  }
 
  public override void addStroke()
  {
    Console.WriteLine("Polygon stroke");
    var a = Console.ReadLine();
    shape["stroke"] = a;
  }
 
  public override void addStrokeWidth()
  {
    Console.WriteLine("Polygon stroke-width");
    var a = Console.ReadLine();
    shape["stroke-width"] = a;
  }
}
class PolylineBuilder : ShapeBuilder

{
  public PolylineBuilder()
  {
    shape = new Shape("Polyline");
  }
 
  public override void addFill()
  {
    Console.WriteLine("Polyline fill");
    var a = Console.ReadLine();
    shape["fill"] = a;
  }
 
  public override void addStroke()
  {
    Console.WriteLine("Polyline stroke");
    var a = Console.ReadLine();
    shape["stroke"] = a;
  }
 
  public override void addStrokeWidth()
  {
    Console.WriteLine("Polyline stroke-width");
    var a = Console.ReadLine();
    shape["stroke-width"] = a;
  }
}
class RectangleBuilder : ShapeBuilder

{
  public RectangleBuilder()
  {
    shape = new Shape("Rectangle");
  }
 
  public override void addFill()
  {
    Console.WriteLine("Rectangle fill");
    var a = Console.ReadLine();
    shape["fill"] = a;
  }
 
  public override void addStroke()
  {
    Console.WriteLine("Rectangle stroke");
    var a = Console.ReadLine();
    shape["stroke"] = a;
  }
 
  public override void addStrokeWidth()
  {
    Console.WriteLine("Rectangle stroke-width");
    var a = Console.ReadLine();
    shape["stroke-width"] = a;
  }
}

/// <summary>

  /// The 'Product' class

  /// </summary>

  class Shape
  {
    private string _shapeType;
    private Dictionary<string,string> _shape = 
      new Dictionary<string,string>();
 
    // Constructor

    public Shape(string shapeType)
    {
      this._shapeType = shapeType;
    }
 
    // Indexer

    public string this[string key]
    {
      get { return _shape[key]; }
      set { _shape[key] = value; }
    }

    public void addToTXT()
    {
      Console.WriteLine("Enter id of shape to add style");
      string path = "./sample.txt";
      string line = null;
      string id = Console.ReadLine();
      string line_to_delete = String.Format(@"id=""{0}"" ", id);
      string strSearchText = line_to_delete;
      string strOldText;
      string newstring = "";
      string n = "";
      StreamReader sr = File.OpenText(path);
      while ((strOldText = sr.ReadLine()) != null)
      {
        if (!strOldText.Contains(strSearchText))
        {
          n += strOldText + Environment.NewLine; 
        }
        else
        {
          strOldText = strOldText.Substring(0,strOldText.Length - 2);
          string first =@" style = """;
          var second = @"fill : " +  _shape["fill"] + "; stroke: " + _shape["stroke"] + "; stroke-width: " + _shape["stroke-width"] + "";
          string third = "\"/>";
          newstring = strOldText +first + second + third;
        }
      }
      sr.Close();
      File.WriteAllText(path, n);
      File.AppendAllText(path, newstring + Environment.NewLine);
    }
  }