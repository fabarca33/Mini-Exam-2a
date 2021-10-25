using System;
using System.Linq;

class Program {
public static double CylinderVolume (double num1, double num2)
{
 double num3 = 0;

 num3 = 3.14 * num1 * num1 * num2;

 return num3;

}

  public static void Main (string[] args) {

    double volume = 0.0;

    Console.WriteLine ("Please enter the radius of the cylinder");

    double radius = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine ("Please enter the height of the cylinder");

    double height = Convert.ToDouble(Console.ReadLine());

    volume = CylinderVolume(radius, height);

    Console.WriteLine ("The volume of the cylinder is " +volume +" units.");
    

  }
}