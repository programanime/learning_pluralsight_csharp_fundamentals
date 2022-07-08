using System;

namespace app
{
    public class Employee{
        public string firstName;
        public string lastName;
        public string email;
        public string name;
        public int numberOfHoursWorked;
        public int wage;
        public double hourlyRate;
        public DateTime birthDay;
        public EmployeeType employeeType;
        
        public string Name {
            get {
                return name; 
            }
            set {
                name = value;
            }
        }
        
        public Employee(string firstName, string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
        public void PerformWork(){
            const double daysOfWeek = 10;
            numberOfHoursWorked++;
            Console.WriteLine($"the age for {numberOfHoursWorked}");
        }
        
        public virtual void myMethod(){
            
        }
        
        
    }
    
    public enum EmployeeType{
        Sales=10,
        Manager=20,
        Research=30,
        StoreManager=30
    }
    
    
    public class Manager : Employee{
        public Manager(string firstName, string lastName, double? rate):base(firstName,lastName)
        {
            
        }
        
        
        public override sealed void myMethod(){
            
        }
    }
    
    interface IEmployee{
        int GetWage(){
            return 0;
        }
        
        void GetName();
    }
    
    public class Human:Animal
    {
        public override void Move(){
            
        }
    }

    
    public abstract class Animal{
        public abstract void Move();
        public void Born(){
            Console.WriteLine("this is mine");
        }
    }
    
    public class Other:IEmployee{
        public void GetName(){
            
        }
    }
    
    
    
    public sealed class Senior{
        
    }
    
    class Clases
    {
        #region My first region
        public static void sample()
        {
            Console.WriteLine(Guid.NewGuid().ToString());
            string? employee = null;
            int? age = 10;
            Console.WriteLine(employee ?? "the employee is null");
            Console.WriteLine(EmployeeType.Sales.GetTypeCode());
            Console.WriteLine(age.HasValue);
            Console.WriteLine(age.Value);
            Console.WriteLine("this is the sample for string");
            GC.Collect();
        }
        #endregion
    }
}