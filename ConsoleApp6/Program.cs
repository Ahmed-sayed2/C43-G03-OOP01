using System;
using System.ComponentModel;
using System.Numerics;
using System.Xml.Linq;

namespace ConsoleApp6
{
    enum WeekDays : byte
    {
    sunday=1, monday,tueseday,wednesday,thursday,friday,saturday
    
    }
    enum Season : byte
    {
        Spring=1, Summer, Autumn, Winter

    }
    enum Colors : byte
    {
        Red=1, Green, Blue

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //for (int i = 1; i <=7; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            #endregion
            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] person = new Person[3];
            //person[0] = new Person() { Name = "Ahmed", Id = 10 };
            //person[1] = new Person() { Name = "mohamed", Id = 11 };
            //person[2] = new Person() { Name = "sayed", Id = 12 };
            //foreach (Person p in person)
            //{
            //    Console.WriteLine($" Id={p.Id} Name={p.Name}\n");
            //}
            #endregion
            #region 3.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //string S;
            //bool b;
            //Season season;
            //Again: Console.WriteLine("enter season");
            //S = Console.ReadLine();
            //b=Enum.TryParse(S,true ,out season);
            //if (b)
            //{
            //    switch (season) { 
            //    case Season.Spring:
            //            Console.WriteLine("spring march to may");
            //            break;
            //    case Season.Winter:
            //            Console.WriteLine("winter December to February");
            //            break;
            //    case Season.Summer:
            //            Console.WriteLine("summer june to august ");
            //            break;
            //    case Season.Autumn:
            //            Console.WriteLine("autumn September to November ");
            //            break;
            //    default: 
            //            Console.WriteLine("Wrong Season");
            //            goto Again;
            //    }
            //}
            //else
            //    goto Again;
            #endregion
            #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //    string S;
            //    bool b;
            //    Colors color;
            //Again: Console.WriteLine("enter Color");
            //    S = Console.ReadLine();
            //    b = Enum.TryParse(S, true, out color);
            //    if (b)
            //    {
            //        if (color == Colors.Red || color == Colors.Blue || color == Colors.Green)
            //            Console.WriteLine("it's primary color");
            //        else
            //            Console.WriteLine("it's not primary color");

            //    }
            //    else
            //        goto Again;

            #endregion

            #region 6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //     bool f1,f2;int x, y;
            //     Point p = new Point();
            //again:Console.WriteLine("enter x");
            //     f1 = int.TryParse(Console.ReadLine(),out x);
            //     Console.WriteLine("enter y");
            //     f2 = int.TryParse(Console.ReadLine(), out y);
            //     if (f1 && f2)
            //     {
            //         p.X = x;
            //         p.Y = y;
            //         Console.WriteLine($"the distance between x and y is{p.GetDistance()}");
            //     }
            //     else
            //         goto again;
            #endregion
            #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //string name="";int age,MinAge=int.MaxValue;bool b;
            //Person2[] p2=new Person2[3];
            //Console.WriteLine(p2.Length);
            //for (int i= 0; i < p2.Length; i++)
            //{
            //    Console.WriteLine("enter name ");
            //    name=Console.ReadLine();
            //    again: Console.WriteLine("enter age ");
            //    b=int.TryParse(Console.ReadLine(), out age);
            //    if (b)
            //        p2[i].Age=age;
            //    else
            //        goto again;
            //}
            //foreach (Person2 p in p2) 
            //{
            //    if (p.Age < MinAge)
            //    {
            //        MinAge = p.Age;
            //        name = p.Name;
            //    }
            //}
            //Console.WriteLine($"Name {name} MinAge is {MinAge} ");
            #endregion
            #region 8.Create a struct named Rectangle that represents a rectangle with the following fields:width(type: double height(type: double)
            double w, h;bool b1, b2;
            Reactangle re = new Reactangle();
           Again: Console.WriteLine("enter width");
            b1 = double.TryParse(Console.ReadLine(), out w);
            Console.WriteLine("enter Height");
            b2 = double.TryParse(Console.ReadLine(), out h);
            if (b1 && b2)
            {
                re.Width=w;
                re.Height=h;
                re.DisplayInfo();
            }
            else
                goto Again;

            #endregion



        }
    }
   
    }
