
using OOPs;
using System.Runtime.CompilerServices;

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

        //Property p = new()
        //{
        //    _Marks = 34,
        //    _Total = 300
        //};
        //Console.WriteLine("MArks : "+p._Marks);
        //Console.WriteLine("Total : "+p._Total);

        //Encapsulation e = new();
        //e.One();
        //Encapsulation e2 = new()
        //{
        //    A = 200
        //};
        //Console.WriteLine(e2.A);
        //Encapsulation e3 = new()
        //{
        //    B = 300
        //};
        //Console.WriteLine(e3.B);

        //Child ch = new();
        //Console.WriteLine(ch.Sub(10, 8));
        //Console.WriteLine(ch.Add(2, 2, 2));
        //Console.WriteLine(ch.d);
        //Console.WriteLine(Child.e);
        //Child ch1 = new()
        //{
        //    A = 1000,
        //    B = 2000,
        //    C = 3000
        //};
        //Console.WriteLine(ch1.A);
        //Console.WriteLine(ch1.B);
        //Console.WriteLine(ch1.C);

        //GrandChild gc = new()
        //{
        //    A = 100,B=200
        //};
        //Console.WriteLine(GrandChild.c);
        //Console.WriteLine(gc.StaticPrivateVariable());
        //Console.WriteLine(gc.A);
        //Console.WriteLine(gc.B);
        //Console.WriteLine(gc.Add(10, 20));
        //Console.WriteLine(gc.Sub(10, 20));
        //Console.WriteLine(gc.Mul(10, 20));


        //Rectangle r = new();
        //r.GetParam1(4);
        //r.GetParam2(8);
        //r.AreaOfCircle();
        //r.AreaOfTraingle();
        //r.AreaOfRectangle();

        //Person p= new();
        //p.Legs("left", "right");
        //p.Legs();

        //Smartphone sm = new Laptop();
        //sm.Specs("Lenovo", "Windows");

        //Prototypes p = new Cat();
        //p.Sound();

        //ISpeak speak= new Dog();
        //speak.Greet();
        //speak.Speak();

        //for user purpose
        //IUser u = new MultipleInheritanceByInterface();
        //u.Signup();
        //u.Signin();
        //for admin purpose
        //IAdmin ad = new MultipleInheritanceByInterface();
        //ad.Dashboard();
        //ad.Analyze();
        //for Database administrator purpose
        //MultipleInheritanceByInterface DA = new MultipleInheritanceByInterface();
        //DA.Signup();
        //DA.Signin();
        //DA.Dashboard();
        //DA.Analyze();

        //only for user
        //IEndUser ie = new SecureMultipleInheritanceByInterface();
        //ie.Signup();
        //ie.Signin();
        //only for admin
        //IAdmininstrator aid = new SecureMultipleInheritanceByInterface();
        //aid.Dashboard();
        //aid.Analyze();
        //for any child
        //SecureMultipleInheritanceByInterface sc = new();
        //sc.Signup();
        //sc.Signin();

    }
}
