using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class main
{
    static void Main()
    {
        try
        {
            int a, b;
            Console.WriteLine("Введите а");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToInt32(Console.ReadLine());
            Utils.utils.add_numbers(a, b);
            Utils.utils.multiply_numbers(a, b);
        }
        catch (Exception e) { 
            Console.WriteLine(e.ToString());
        }
    }
}
