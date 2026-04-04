using Day5;




Point3D[] points =
{
    new Point3D(5, 2, 3),
    new Point3D(3, 5, 6),
    new Point3D(9, 8, 9),
    new Point3D(3, 8, 9),
    new Point3D(3, 5, 9)
};

Array.Sort(points);

Console.WriteLine("Sorted Points");
foreach (Point3D point in points)
{
    Console.WriteLine(point.ToString());
}

Console.WriteLine($"\nCloning point: {points[0].ToString()}");
Point3D cloned_point = (Point3D)points[0].Clone();
Console.WriteLine($"Cloned point: {cloned_point.ToString()}");



