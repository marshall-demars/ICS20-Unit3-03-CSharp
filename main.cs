// Created by: Marshall Demars
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double radiusSphere;
        double volumeSphere;

        // input
        Console.WriteLine("This program calculates the volume of a sphere.");
        Console.WriteLine("");
        Console.WriteLine("the formula for the volume is = 4/3 x π x r³");
        Console.WriteLine("");
        Console.WriteLine("please enter the measurements (km)");
        Console.WriteLine("");

        Console.Write("Input the measurement for the radius: ");
        radiusSphere = Convert.ToDouble(Console.ReadLine());

        // process
        volumeSphere = 4.0 / 3.0 * Math.PI * Math.Pow(radiusSphere, 3);

        // output
        Console.WriteLine("");
        Console.WriteLine("The volume of the sphere is: " + volumeSphere.ToString("0.00") + " km³");
        Console.WriteLine("\nDone.");
    }
}
