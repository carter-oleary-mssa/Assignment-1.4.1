Point P1 = new Point(0, 0);
Point P2 = new Point(2, 3);

if (P1.x < P2.x)
{
    Console.WriteLine("P2 is to the right of P1");
}
else if (P1.x == P2.x)
    Console.WriteLine("P2 is aligned with P1");
else 
    Console.WriteLine("P2 is to the left of P1");