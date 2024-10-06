public class Math
{
    public int a;
    public int b;
    public float c;
    public float d;
    public int e;
    public Math(int a, int b)
    {
        this.a = a;
        this.b = b;

    }
    public Math(float c, float d)
    {
        this.c = c;
        this.d = d;
    }
    public Math(int e)
    {
        this.e = e;
    }
    public int add(int a, int b)
    {
        return a + b;
    }
    public int sub(int a, int b)
    {
        return a - b;
    }


    public int mul(int a, int b)
    {
        return a * b;
    }

    public int div(int a, int b)
    {
        return a / b;
    }
    public float div2(float c, float d)
    {
        return c / d;
    }
    public int dividend(int a, int b)
    {
        return a % b;
    }
    public int square(int a)
    {
        return a * a;
    }
    public int type(int e)
    {
        if (e % 2 == 0)
        {
            Console.WriteLine("The number is even");
            return 0;


        }
        else
        {
            Console.WriteLine("The number is odd");
            return 1;

        }


    }
}
