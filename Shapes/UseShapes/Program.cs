using Shapes;

var shapes = new List<IShape>() { new Circle(2), new Triangle(1, 1, 1) };
// We could also create a Factory in Shapes library
foreach (var shape in shapes)
{
    Console.WriteLine($"Shape's area: {shape.GetArea():F2}");
}
