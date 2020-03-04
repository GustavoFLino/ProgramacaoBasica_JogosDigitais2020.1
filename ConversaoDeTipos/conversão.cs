using System;

namespace ConversaoDeTipos
{
    class conversão
    {
        static void Main(string[] args)
        {
            string a = "11", b = "2";

            int c = Convert.ToInt32(a) / Convert.ToInt32(b);

            Console.WriteLine(c);

            String d = Convert.ToString(c);

            Console.WriteLine(c.GetType());

            Console.WriteLine(d);

            Console.WriteLine(d.GetType());

     
        }
    }
}
