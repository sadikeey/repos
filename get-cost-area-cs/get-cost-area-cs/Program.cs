using System;
class Rectangle
{
    public int height, width;
    public void getData()
    {
        Console.WriteLine("Enter height and width of the rectangle : ");
        height = Convert.ToInt32(Console.ReadLine());
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
    public int area()
    {
        int area = height * width;
        return area;
    }
class Cost : Rectangle
    {
        public int cost;

        public int getCost()
        {
            cost = area() * 50;
            return cost;
        }
        public void display()
        {
        Console.Write("Area of Rectangle : " + area());
        Console.WriteLine();
        Console.Write("Area of Rectangle : " + getCost());
        }
public static void Main(string[] args)
        {
            Cost cost = new Cost();
            cost.getData();
            cost.display();
        }
    }
}
