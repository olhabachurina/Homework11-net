using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework11_net;


class Program
{
    static void Main()
    {
        Console.WriteLine("Exercise 1");
        int evenNumber = 6;
        int oddNumber = 7;

      
        Console.WriteLine($"{evenNumber} is odd: {evenNumber.IsOdd()}"); 
        Console.WriteLine($"{oddNumber} is odd: {oddNumber.IsOdd()}");   

        Console.WriteLine("Exercise 2");
        int evenNumber1 = 6;
        int oddNumber1 = 7;

        
        Console.WriteLine($"{evenNumber1} is even: {evenNumber1.IsEven()}"); 
        Console.WriteLine($"{oddNumber1} is even: {oddNumber1.IsEven()}");   



        Console.WriteLine("Exercise 7");
       
        Person[] people = {
            new Person("Petro", "Dodenko", 25),
            new Person("Anna", "Leonova", 30),
            new Person("Oleg", "Petrenko", 22),
            new Person("Olga", "Solovemko", 35)
        };

        


        var youngestPerson = people.OrderBy(person => person.Age).First();// Поиск человека с минимальным возрастом
        Console.WriteLine(

        $"Youngest person: {youngestPerson.FirstName} {youngestPerson.LastName}, Age: {youngestPerson.Age}");

       
        var oldestPerson = people.OrderByDescending(person => person.Age).First(); // Поиск человека с максимальным возрастом
        Console.WriteLine($"Oldest person: {oldestPerson.FirstName} {oldestPerson.LastName}, Age: {oldestPerson.Age}");

        
        double averageAge = people.AverageAge();// Вычисление среднего возраста с использованием extension method
        Console.WriteLine($"Average age: {averageAge}");
    




        Console.WriteLine("Exercise 8");
        Point3D[] points = new Point3D[]
        {
            new Point3D(1.0, 2.0, 3.0),
            new Point3D(4.0, 5.0, 6.0),
            new Point3D(7.0, 8.0, 9.0),
            
        };

        
        double maxDistance = 0;// Поиск максимального расстояния и информации о точках
        Point3D pointA = new Point3D();
        Point3D pointB = new Point3D();

        for (int i = 0; i < points.Length; i++) 
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                double distance = points[i].CalculateDistance(points[j]);
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    pointA = points[i];
                    pointB = points[j];
                }
            }
        }

        
        Console.WriteLine($"Maximum distance between points: {maxDistance}");// Вывод информации о точках и максимальном расстоянии
        Console.WriteLine($"point A: ({pointA.X}, {pointA.Y}, {pointA.Z})");
        Console.WriteLine($"point B: ({pointB.X}, {pointB.Y}, {pointB.Z})");




    }
}

