
using OOPs;

internal class Program
{
    public static void Main()
    {
        //StaticAndDynamic sd = new StaticAndDynamic();
        //Console.WriteLine(sd.Sub(10, 5));
        //Console.WriteLine(StaticAndDynamic.Add(10, 5));

        //Constructor c = new Constructor();

        //NonStaticConstructor n = new();
        //NonStaticConstructor n1 = new(10, 20);

        //CopyConstructor ct = new();
        //CopyConstructor tr = new(ct);

        //Property p = new()
        //{
        //    _Marks = 15
        //};
        //Console.WriteLine("Marks is : " + p._Marks);

        Property p = new()
        {
            _Marks = 34,
            _Total = 300
        };
        Console.WriteLine("MArks : "+p._Marks);
        Console.WriteLine("Total : "+p._Total);
    }
}