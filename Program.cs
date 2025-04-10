Point P1 = new Point(0, 0);
Point P2 = new Point(-4, 3);

Console.WriteLine($"Point 1: ({P1.X}, {P1.Y})");
Console.WriteLine($"Point 2: ({P2.X}, {P2.Y})");

if (P1.X < P2.X)
    Console.WriteLine("P2 is to the right of P1");
else if (P1.X == P2.X)
    Console.WriteLine("P2 is aligned with P1");
else 
    Console.WriteLine("P2 is to the left of P1");