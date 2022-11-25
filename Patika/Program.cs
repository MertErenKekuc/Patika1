namespace patika
{
    public class degisken
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 1;
            uint b = 2;

            Console.WriteLine(a + b);

            short c = 3;
            ushort d = 4;

            string e = null;
            string f = "";
            string g = "mert";
            string h = "kekuc";

            Console.WriteLine(g + " " + h);
            string k = g + h;
            Console.WriteLine(k);

            char n = ' ';
            char o = 'k';
            Console.WriteLine(o);

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            DateTime dt2 = DateTime.Now.Date;
            Console.WriteLine(dt2);




        }
    }
}

