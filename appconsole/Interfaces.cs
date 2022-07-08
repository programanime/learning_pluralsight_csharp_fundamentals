using System;
using System.Collections.Generic;

namespace app
{
    public class Student:IComparable
    {
        public Student(int id){
            this.Id = id;
        }
        
        public int Id { get; set; }
        
        public int CompareTo(object obj){
            var other = (Student)obj;
            if(this.Id > other.Id){
                return 1;
            }else if(this.Id < other.Id){
                return -1;
            }else{
                return 0;
            }
        }
    }
    
    public class Child: Animalcito,ISome,ISomeOther{
        public void GiveBonus(){
            
        }
        
        public void GiveAnotherBonus(){
            
        }
        
        public override void Move(){
            
        }
    }
    
    public interface ISome{
        void GiveBonus();
    }
    
    public interface ISomeOther{
        void GiveAnotherBonus();
    }
    
    public abstract class Animalcito{
        public abstract void Move();
        public void Born(){
            Console.WriteLine("this is mine");
        }
    }
    
    class InterfacesSample
    {
        public static void sample()
        {
            Console.WriteLine("this is the sample for string");
            List<Student> students = new List<Student>();
            students.Add(new Student(1));
            students.Add(new Student(4));
            students.Add(new Student(3));
            students.Add(new Student(2));
            students.Sort();
            
            foreach(Student student in students){
                Console.WriteLine(student.Id);
            }
            
        }
    }
}