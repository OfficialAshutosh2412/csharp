
using OOPs;
using System.ComponentModel;
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

        //SealedClass sc = new();
        //sc.disply();

        //to hide child methods and expose parent's methods, jiska reference type uska method chalega
        //Bill b = new GstBill();
        //Console.WriteLine(b.cal(100));

        //to hide parent's methods and expose child methods. jiska reference type uska method chalega
        //GstBill gs = new GstBill();
        //Console.WriteLine(gs.cal(100)); 

        //MyCode m1 = new MyCode();
        //Console.WriteLine(m1.Div(10, 0));
        //Console.WriteLine("------------------------------------------------------------------");

        //FinallyKeyword m2 = new();
        //Console.WriteLine(m2.Div(10, 0));
        //Console.WriteLine("------------------------------------------------------------------");

        //NegativeNumber m3 = new();
        //Console.WriteLine(m3.GetNumber(-1));
        //Console.WriteLine("------------------------------------------------------------------");

        //NumberAcceptor m4 = new();
        //Console.WriteLine(m4.GetNumber(-1));
        //Console.WriteLine("------------------------------------------------------------------");

        //AgeAcceptor m5 = new();
        //Console.WriteLine(m5.GetAge(55));
        //Console.WriteLine("------------------------------------------------------------------");

        //NonGenericArrayList nal = new();
        //nal.show();

        //NonGenericHastTable hash = new();
        //hash.show();

        //NonGenericSortedList ns = new NonGenericSortedList();
        //ns.show();
        //GenericSortedList gs = new();
        //gs.show();

        //NonGenericStack stk = new();
        //stk.show();
        //stk.PopElement();
        //stk.show();

        //GenericStack stk = new();
        //stk.show();
        //stk.PopElement();
        //stk.show();

        //NonGenericQueue que = new();
        //que.show();
        //que.RemoveElement();
        //que.show();

        //GenericQueue que = new();
        //que.show();
        //que.RemoveElement();
        //que.show();

        //GenericList gl = new();
        //gl.show();
        //GenericListObject glo = new();
        //glo.show();

        //GenericDictionary gd = new();
        //gd.show();


        //DelegateClass deg = new();
        //Calculate calc = new Calculate(deg.Add);
        //calc += deg.Div;
        //calc += deg.Mul;
        //calc += deg.Sub;
        //calc(10, 2);

        //single cast
        //LatestDelegateExample deg = new();
        //Action<int, int> op = deg.Add;
        //op(10, 2);

        //Processor process = new();
        //OperationFunctions op = new();
        //process.Execute(10, 2, op.Add);
        //process.Execute(10, 2, op.Sub);

        //sinle thread
        //SingleThreadExample single = new();
        //ThreadStart ts = new ThreadStart(single.Display);
        //Thread t = new Thread(ts);
        //t.Start();


        //multi-threading in old csharp
        MultiThreadExample mt = new();
        //thread 1
        //ThreadStart t1 = new ThreadStart(mt.Display10);
        //Thread thread1 = new Thread(t1);
        //thread1.Start();
        //thread 2
        //ThreadStart t2 = new ThreadStart(mt.Display20);
        //Thread thread2 = new Thread(t2);
        //thread2.Start();

        //multi-threading in modern c sharp csharp
        //Thread t1 = new Thread(mt.Display10);
        //Thread t2 = new Thread(mt.Display20);
        //t1.Start();
        //t2.Start();

        //multi-threading in modern c sharp csharp shorter version
        //new Thread(mt.Display10).Start();
        //new Thread(mt.Display20).Start();

        //thread pausing in multi-threading
        Thread t1 = new(mt.Task1);
        Thread t2 = new(mt.Task2);
        Thread t3 = new(mt.Task3);
        t1.Start();
        t2.Start();
        //like a border waiting line. Threads t1 and t2 executed parallely as usual, but main thread is wait untill they finished then run t3
        t2.Join();
        t3.Start();

    }
}
