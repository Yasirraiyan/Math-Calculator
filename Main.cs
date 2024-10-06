class program
{


    public static void Main(string[] args)
    {
        Math m = new Math(4, 2);
        Console.WriteLine(m.add(4, 2));
        Console.WriteLine(m.sub(4, 2));

        Console.WriteLine(m.mul(4, 2));
        Console.WriteLine(m.div(4, 2));

        Console.WriteLine(m.dividend(4, 2));

        Console.WriteLine(m.dividend(4, 3));
        Console.WriteLine(m.square(5));
        Math m2 = new Math(4, 3);
        Console.WriteLine(m2.div2(4, 3));
        Math m3 = new Math(8);
        Console.WriteLine(m3.type(8));
        Math m4 = new Math(65);
        Console.WriteLine(m4.type(65));



    }
}
