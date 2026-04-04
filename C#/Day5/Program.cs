using Day5;

void task1()
{
    Point3D P = new Point3D(10, 10, 10);
    Console.WriteLine($"tostring: {P.ToString()}");
    Console.WriteLine($"cast to string: {(string)P}");

    Point3D[] points = new Point3D[2];
    for(int i=0; i<points.Length; i++)
    {
        Console.Write($"Enter point {i+1} x: ");
        double x = int.Parse( Console.ReadLine() );

        Console.Write($"Enter point {i+1} y: ");
        double y = int.Parse( Console.ReadLine() );

        Console.Write($"Enter point {i+1} z: ");
        double z = int.Parse( Console.ReadLine() );

        points[i] = new Point3D(x,y,z);
        Console.WriteLine("-------------------------------------------");
    }

    Console.WriteLine($"p1 == p2: {points[0] == points[1]}");
    Console.WriteLine($"p1 != p2: {points[0] != points[1]}");
    Console.WriteLine($"p1.equals(p2): {points[0].Equals(points[1])}");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("-------------------------------------------\n");
    
}

void task2()
{
    Console.Read();
    Console.WriteLine($"Add 1,2: {MyMath.Add(1, 2)}");
    Console.WriteLine("-------------------------------------------");

    Console.WriteLine($"Subtract 1,2: {MyMath.Subtract(1, 2)}");
    Console.WriteLine("-------------------------------------------");

    Console.WriteLine($"Multiply 1,2: {MyMath.Multiply(1, 2)}");
    Console.WriteLine("-------------------------------------------");

    Console.WriteLine($"Divide 1,2: {MyMath.Divide(1, 2)}");
    Console.WriteLine("-------------------------------------------");

    Console.WriteLine($"Divide 1,0: {MyMath.Divide(1, 0)}");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("-------------------------------------------\n");
    

}

void task3()
{
    Console.Read();
    NIC nic1 = NIC.GetInstance();
    NIC nic2 = NIC.GetInstance("a", "b", NICType.ETHERNET);

    Console.WriteLine($"nic1.hash == nice2.hash : {nic1.GetHashCode() == nic2.GetHashCode()}");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("-------------------------------------------\n");
    Console.Read();
}


void task4()
{
    Console.Read();
    Duration D = new Duration(1, 10, 15);
    Console.WriteLine("D (1, 10, 15)");
    Console.WriteLine($"Result: {D}");
    Console.WriteLine($"Expected: Hours: 1, Minutes :10 , Seconds :15\n");
    Console.WriteLine("------------------------------------------------------------");
    Duration D1 = new Duration(3600);
    Console.WriteLine("D1 (3600)");
    Console.WriteLine($"Result: {D1}");
    Console.WriteLine($"Expected: Hours: 1, Minutes: 0 , Seconds: 0\n");
    Console.WriteLine("------------------------------------------------------------");
    Duration D2 = new Duration(7800);
    Console.WriteLine("D2 (7800)");
    Console.WriteLine($"Result: {D2}");
    Console.WriteLine($"Expected: Hours: 2, Minutes: 10 , Seconds: 0\n");
    Console.WriteLine("------------------------------------------------------------");
    Duration D3 = new Duration(666);
    Console.WriteLine("D3 (666)");
    Console.WriteLine($"Result: {D3}");
    Console.WriteLine($"Expected: Minutes :11 , Seconds :6\n");
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("D4 = D1 + D2");
    Console.WriteLine($"D4 = {D1} + {D2}");
    Duration D4 = D1 + D2;
    Console.WriteLine($"D4 = {D4}\n");
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("D5 = D1 + 7800");
    Console.WriteLine($"D5 =  {D1} +  {D2}");
    Duration D5 = D1 + 7800;
    Console.WriteLine($"D5 = {D5}\n");
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("D6 = 666 + D3");
    Console.WriteLine($"D6 = {new Duration(666)} + {D3}");
    Duration D6 = 666 + D3;
    Console.WriteLine($"D6 = {D6}\n");
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("D7 = D1++");
    Console.WriteLine($"D7 = {D1}++");
    Duration D7 = D1++;
    Console.WriteLine($"D7 = {D7}");
    Console.WriteLine($"D1 = {D1}\n");
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("D8 = --D2");
    Console.WriteLine($"D8 = --{D2}");
    Duration D8 = --D2;
    Console.WriteLine($"D8 = {D8}\n");
    Console.WriteLine($"D2 = {D2}\n");
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("D1 -= D2");
    Console.WriteLine($"{D1} -= {D2}");
    D1 -= D2;
    Console.WriteLine($"D1 = {D1}\n");
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("if (D1 > D2)");
    if (D1 > D2) Console.WriteLine("True\n");
    else Console.WriteLine("False\n");
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("if (D1 <= D2)");
    if (D1 <= D2) Console.WriteLine("True\n");
    else Console.WriteLine("False\n");
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("if (D1)");
    if (D1) Console.WriteLine("True\n");
    else Console.WriteLine("False\n");
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("DateTime Obj = (DateTime)D2");
    DateTime Obj = (DateTime)D2;
    Console.WriteLine($"D2 = {D2}");
    Console.WriteLine($"obj = {Obj}\n");
    Console.WriteLine("------------------------------------------------------------");
}

task1();
task2();
task3();
task4();