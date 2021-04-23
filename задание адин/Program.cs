using System;
using System.Collections.Generic;


namespace задание_адин
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину");
            List<int> st = new List<int> { };
            Random rnd = new Random();
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                int a = rnd.Next(-10, 10);
                st.Add(a);
                Console.WriteLine(st[i] + " ");
            }

            int b = 0;
            for (int i = 0; i < st.Count; i++)
            {
                if (st[i] > 0)
                {
                    b = st[i];
                    break;
                }
            }

            if (b != 0)
            {
                for (int i = 0; i < st.Count; i++)
                {
                    if (st[i] < 0)
                    {
                        st.Insert(b, i + 1);
                    }
                }
            }

            for (int i = 0; i < st.Count; i++)
            {
                Console.WriteLine(st[i] + "");
            }
        }
    }
}