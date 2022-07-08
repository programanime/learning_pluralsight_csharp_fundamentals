using System;
using System.Text;

namespace app
{
    class Types
    {
        public static void sample(){
            Employee employee = new Employee();
            employee.Name = "daniel";
            employee.Wage = 10;
            employee.Work();
            Console.WriteLine(@"d\test");
            StringBuilder str=new StringBuilder("init");
            str.Append("other line");
            str.AppendLine("other line");
            DateTime now = DateTime.Parse("12/12/2022");
            if(long.TryParse("1", out long longOut)){
                Console.WriteLine($"si lo era {longOut}");
            }
            int b = 10;
            Console.WriteLine(sum(1,ref b));
            int param_a = 10;
            int param_b = 20;
            int result = 0;
            
            sum(param_a, param_b, out result);
            Console.WriteLine($"the sum is : {result}");
            result = userInfo(a:10, b:20, c:30);
        }
        
        public static void convertion(){
            Convert.ChangeType(10.0, typeof(int));
        }
        
        public static int sum(int a, ref int b)
        {
            return a + b;
        }
        
        public static int multiply(params int[] numbers){
            int suma = 0;
            foreach(var number in numbers){
                suma += number;
            }
            return suma;
        }
        
        public static void sum(int a, int b, out int result)
        {
            result = a + b;
            
        }
        
        enum EstadosAlumno{
            Matriculado,
            Activo,
            Suspendido,
            Insuficiente
        }
        
        
        public static int userInfo(int a, int b, int c = 0) => a+b+c;
        
        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType){
            if(employeeType == EmployeeType.Manager){
                Console.WriteLine("you are a manager");
            }
        }
        
        enum EmployeeType{
            Sales,
            Manager,
            Research,
            StoreManager
        }
        
        enum StoreType{
            PieCorner,
            Seating,
            Undefined
        }
        
        public struct Employee
        {
            public string  Name;
            public int Wage;
            
            public void Work(){
                Console.WriteLine($"{Name} is doing some work!");
            }
        }
    }
}