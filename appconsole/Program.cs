using System;
using System.Linq;
using Utils = utils.Utils;
using Console = System.Console;

namespace app
{
    public struct Point
    {
        public int X;
        public int Y;
        
        public override String ToString()
        {
            return $"{X}, {Y}";
        }
    }
    
    class Program
    {
        public static void SwitchTest(){
            var name = "daniel";
            var originalAge = 10;
            
            var resultSiwtchWhen = originalAge switch {
                var tempAge when tempAge < 10 => "baby",
                var tempAge when tempAge >= 20 => "old man"
            };

            var result = name == "daniel" ? "gay" : "not gay";
            var age = name switch {
                "daniel" => 30,
                "alejandro" => 40,
                "yepes" => 50,
                _ => 0
            };
        }
        
        public static double ServiceScore { get; set; } = 8.0;
        
        static float test(float large){
            string[] coffeeTypes = {"mocha", "java"};
            decimal other = 10.0M;
            Console.WriteLine($"other {other}");
            var finalend = large*10.0f;
            Console.WriteLine(finalend.GetType());
            return finalend;
        }
        
        static void Main(string[] args)
        {
            // Clases.sample();
            // InterfacesSample.sample();
            PolygonSample.sample();
            // Types.sample();
            // test(10);
            
            // Console.WriteLine("the ne dof the world si : "+Utils.plus(1,2));
            // Console.WriteLine("i am here!");
            
            // for(int n = 0;n<args.Length;n++){
            //     Console.WriteLine("arg[{0}] = {1}", n, args[n]);
            // }
            
            // sample1();
            // sample2();
            // sample3();
            // GoThrowParents();
            // GetTypeFromBasicObject();
        }
        
        private static void GoThrowParents()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var type = numbers.GetType();
            do
            {
                Console.WriteLine(type.FullName);
                type = type.BaseType;
            }while(type != null);
        }
        
        private static void Aggregate()
        {
            
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            
            var sum = numbers.Aggregate(
                0, 
                (total, num) => total + num
            );
        }
        
        private static void GetTypeFromBasicObject()
        {
            int age = 1;
            var type = age.GetType();
            Console.WriteLine($" the type is {type}");
        }

        private static void sample1()
        {
            var sum = 0;
            var numbers = new int[]  { 1, 2, 3, 4, 5 };
            

            for(var n = 0; n < numbers.Length ; n++)
            {
                sum += numbers[n];
            }

            System.Console.WriteLine(sum);

        }
        
        public static void sample2(){
            var pt = new Point { X = 30, Y = 12 };
            Console.WriteLine(pt.ToString());
        }
        
        
        public static void sample3(){
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var type = numbers.GetType();
            Console.WriteLine(type);
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.BaseType);
        }
    }
}
