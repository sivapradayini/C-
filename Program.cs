using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Using Available Data Types in C#");
            Console.WriteLine("--------------------");
            sbyte a = 126;
            Console.WriteLine("sbyte " + a); 
            Console.WriteLine(a.GetType());

            Console.WriteLine("--------------------");

            short b = - 32700;
            Console.WriteLine("short " + b); 
            Console.WriteLine(b.GetType());
            Console.WriteLine("--------------------");
            int c = 29;
            Console.WriteLine("int " + c); 
            Console.WriteLine(c.GetType());
            Console.WriteLine("--------------------");


            long d = 575755454;
            Console.WriteLine( " long " + d); 
            Console.WriteLine("--------------------");

            
            bool bl = true;    
            Console.WriteLine(bl.GetType()); 
            Console.WriteLine(bl);
                
           
            Console.WriteLine("--------------------");

            ushort f = 655;
            Console.WriteLine("ushort " + f); 
            Console.WriteLine(f.GetType()); 
             Console.WriteLine("--------------------");

            uint g = 56;
            Console.WriteLine("ulong " + g);
            Console.WriteLine(g.GetType()); 
             Console.WriteLine("--------------------");

            ulong h = 5656565;
            Console.WriteLine("ulong " + h); 
            Console.WriteLine(h.GetType());
            Console.WriteLine("--------------------");

            float u = 343875859f;
            Console.WriteLine("float " + u); 
            Console.WriteLine(u.GetType());
            Console.WriteLine("--------------------");

            double v = 99595959.686868d;
            Console.WriteLine("double " + v); 
            Console.WriteLine(v.GetType());
            Console.WriteLine("--------------------");
            decimal r = 45.788m;
            Console.WriteLine("decimal " + r); 
            Console.WriteLine(r.GetType());
            Console.WriteLine("--------------------");

            char rat = 'R';
            Console.WriteLine("char " + rat); 
            Console.WriteLine(rat.GetType());
            Console.WriteLine("--------------------");

            string name = "Sivapradayini";
            Console.WriteLine("string" + name);
            Console.WriteLine(name.GetType()); 

            Console.WriteLine("--------------------");

            object obj;
            obj = 20; 
            Console.WriteLine("object" + obj); 
            Console.WriteLine(obj.GetType());


            Console.WriteLine("Hello World!");
        }
    }
}
