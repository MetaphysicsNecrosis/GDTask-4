using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTask_4
{
    class CodeMeDecodeYou
    {
        const int mod = 256;
        static public char Coder(char c, int m)
        {
            return (char)(((int)(c) + m) % mod);
        }
        static public String Coder(String s, int m)
        {
            return String.Join("", (s.ToCharArray().Select(n => Coder(n, 5))).ToArray());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            s = CodeMeDecodeYou.Coder(s, 5);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
