using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "윤" + "인" + "성";
            Console.Write("Hello C#");
            int add = 2; // 이런 키워드는 특정 영역에서만 사용 x.
            int Alpha;

            // 주석

            /*
             *  여러 줄 주석
             * 
             */
            Console.WriteLine("Hello World");
            Console.Write("Hello World");
            Console.Write("Hello World");

            Console.Write(52);
            Console.WriteLine(7 % 3); // 정수로 나옴.
            Console.WriteLine('A');
            Console.WriteLine("A");

            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("가" + "나" + "다");

            // Console.WriteLine("안녕"[100]);

            Console.WriteLine(true);
            Console.WriteLine(true);
        }
    }
}
