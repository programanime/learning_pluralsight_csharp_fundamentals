using System;
namespace app
{
    #region concrete inheritance
        public class ConcreteRegularPolygon
        {
            public int NumbersOfSides { get; set; }
            public int SideLength { get; set; }
            
            public ConcreteRegularPolygon(int numbersOfSides, int sideLength){
                this.NumbersOfSides = numbersOfSides;
                this.SideLength = sideLength;
            }
            
            public double GetPerimeter(){
                return this.NumbersOfSides * this.SideLength;
            }
            
            
            public virtual double GetArea(){
                throw new NotImplementedException();
            }
        }
    #endregion
    
    #region abstractInheritance
        public abstract class AbstractRegularPolygon
        {
            public int NumbersOfSides { get; set; }
            public int SideLength { get; set; }
            
            public AbstractRegularPolygon(int numbersOfSides, int sideLength){
                this.NumbersOfSides = numbersOfSides;
                this.SideLength = sideLength;
            }
            
            public double GetPerimeter(){
                return this.NumbersOfSides * this.SideLength;
            }
            
            
            public abstract double GetArea();
        }
    #endregion
    
    #region interfaceInherit
        interface IRegularPolygon{
            int NumbersOfSides { get; set; }
            int SideLength { get; set; }
            
            double GetArea();
            double GetPerimeter();
        }
    #endregion
    
    // public class Square:ConcreteRegularPolygon
    public class Square:IRegularPolygon
    {
        public int NumbersOfSides { get; set; }
        public int SideLength { get; set; }
            
         public Square(int sideLength)
         {
             this.NumbersOfSides = 4;
             this.SideLength = sideLength;
         }
         
         public double GetArea(){
            return this.SideLength * this.SideLength;
         }
         
         public double GetPerimeter(){
            return this.SideLength * 4;
         }
    }
    
    public class PolygonSample{
        public static void sample()
        {
            Console.WriteLine("PolygonSample");
            var square = new Square(100);
            Console.WriteLine(square.GetArea());
        }
    }
}