using System;
using System.Collections.Generic;

namespace задание_трэ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> st = new List<int> { };
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                st.Add(rnd.Next(0, 30));
                Console.Write(st[i] + " ");
            }
            Console.WriteLine();
            for(int i=0;i<st.Count;i++)
            {
                if((st[i]%3)==0)
                {
                    st.RemoveAt(i);
                }
            }
            for (int i = 0; i < st.Count; i++)
            {
                Console.Write(st[i] + " ");
            }
            Console.WriteLine();
            int last = st[0];
            for (int i = 1; i < st.Count; i++)
            {
                if(last==st[i])
                {
                    st.Insert(i + 1, 88);
                }
                last = st[i];
            }
            for (int i = 0; i < st.Count; i++)
            {
                Console.Write(st[i] + " ");
            }
        }
    }
}