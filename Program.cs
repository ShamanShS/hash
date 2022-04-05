using System;

namespace hash;

class hash
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Введите строку");
        string? s = Console.ReadLine();
        System.Console.WriteLine("Введите подстроку");
        string? p = Console.ReadLine();
        int[] fib = new int[10000];
            fib[0] = 1;
            fib[1] = 1;
        if (s.Length != 0 && p.Length !=0)
        {
            int hp = 0;
            for (int i = 0; i < p.Length; i++)
            {
                hp += (p[i])*Fibonacci(ref fib , p[i] - 'a' + 1)*(i+1); 
                //System.Console.WriteLine($"f ={Fibonacci(ref fib , i)}  p = {p[i] - 'a' + 1}  p = {p[i]} ");
            }
            for (int i = 0; i < s.Length - p.Length  + 1; i++)
            {
                int hs = 0;
                    for (int i1 = 0; i1 < p.Length; i1++)
                {
                    hs += s[i + i1]*Fibonacci(ref fib , s[i + i1] - 'a' + 1)*(i1+1); 
                    //System.Console.WriteLine($"f ={Fibonacci(ref fib , i + i1)}  p = {s[i + i1] - 'a' + 1} p = {p[i]} ");
                }
                if (hs == hp)
                {
                    System.Console.WriteLine(hp);
                    System.Console.WriteLine(hs);
                    System.Console.WriteLine($"s[{i + 1}...{i+p.Length}] = p");
                }
            }
            // foreach (var o in fib)
            // {
            //     System.Console.WriteLine(o);
            // }
        }
        else
        {
            System.Console.WriteLine("А строка или подстрока то пустая!!!");
        }
        // string r = "cock";
        // string rr = "kcoc";
        // int hr = 0;
        // int hrr = 0;
        // for (int i = 0; i < r.Length; i++)
        //     {
        //         hr += r[i] + Fibonacci(ref fib , r[i] - 'a' + 1)*(i+1); 
        //         //System.Console.WriteLine($"f ={Fibonacci(ref fib , i)}  p = {p[i] - 'a' + 1}  p = {p[i]} ");
        //     }
        // for (int i = 0; i < rr.Length; i++)
        //     {
        //         hrr += rr[i] + Fibonacci(ref fib , rr[i] - 'a' + 1)*(i+1); 
        //         //System.Console.WriteLine($"f ={Fibonacci(ref fib , i)}  p = {p[i] - 'a' + 1}  p = {p[i]} ");
        //     }
        // System.Console.WriteLine(hr);
        // System.Console.WriteLine(hrr);

    }

    static int Fibonacci (ref int[] fib , int t)
    {
        if (fib[t + 2] == 0)
        {
            fib[t + 2] = Fibonacci(ref fib, t - 1) + Fibonacci(ref fib, t - 2);
            return fib[t + 2];
        }
        else
        {
            return fib[t + 2];
        }
    }
}
