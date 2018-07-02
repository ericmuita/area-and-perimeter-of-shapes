using System;

namespace ERIC_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string username,user_name,Password,pass_word,Square,Rectangle,Circle,Sphere,Shape,Area,Perimeter,AREA_OR_PERIMETER;
            double square,rectangle,circle,sphere,length,width,radius,SQUARE,RECTANGLE,CIRCLE;
            const double pie=3.142;
            Square="square";
            Rectangle="rectangle";
            Circle="circle";
            Sphere="sphere";
            Area="area";
            Perimeter="perimeter";
            Console.WriteLine("Please Enter User Name(3 Trials Remaining)");
            username=Console.ReadLine();
            Console.Clear();
            user_name="ericndegwa";
            if(username==user_name||username!=user_name)
            {
                Console.WriteLine("Please Enter Password");
                Password=Console.ReadLine();
                Console.Clear();
                pass_word="microsoft";
                if(Password==pass_word&&username==user_name)
                {
                    Console.WriteLine("AREA & PERIMETER OF SHAPES");
                    Console.WriteLine("Please Enter Area or Perimeter(use lower case)");
                    AREA_OR_PERIMETER=Console.ReadLine();
                    Console.Clear();
                    if(AREA_OR_PERIMETER==Area)
                    {
                     Console.WriteLine("Please Enter Any Of The Following Shapes:");
                     Console.WriteLine(">square");
                     Console.WriteLine(">rectangle");
                     Console.WriteLine(">circle");
                     Console.WriteLine(">sphere");
                     Shape=Console.ReadLine();
                     if(Shape==Square)
                     {
                         Console.WriteLine("Please Enter The Length");
                         length=Convert.ToDouble(Console.ReadLine());
                         Console.Clear();
                         square=length*length;
                         Console.WriteLine($"The Area Of The Square is {square}");
                     }
                         else if(Shape==Rectangle)
                         {
                             Console.WriteLine("Please Enter The Length");
                             length=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             Console.WriteLine("Please Enter The Width");
                             width=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             rectangle=length*width;
                             Console.WriteLine($"The Area Of The Rectangle is {rectangle}");
                         }
                         else if(Shape==Circle) 
                         {
                             Console.WriteLine("Please Enter The Radius");
                             radius=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             circle=pie*radius*radius;
                             Console.WriteLine($"The Area Of The Circle is {circle}");
                         }
                         else if(Shape==Sphere)
                         {
                             Console.WriteLine("Please Enter The Radius");
                             radius=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             sphere=4*pie*radius*radius;
                             Console.WriteLine($"The Area Of The Sphere is {sphere}");
                         }
                         else
                         {
                             Console.WriteLine("Shape Not Valid !");
                             Console.WriteLine("Please Enter A Valid Shape");
                         }
                    }
                    else if(AREA_OR_PERIMETER==Perimeter)
                    {
                     Console.WriteLine("Please Enter Any Of The Following Shapes:");
                     Console.WriteLine(">square");
                     Console.WriteLine(">rectangle");
                     Console.WriteLine(">circle");
                     Shape=Console.ReadLine(); 
                     Console.Clear();
                     if(Shape==Square)
                     {
                         Console.WriteLine("Please Enter The Length");
                         length=Convert.ToDouble(Console.ReadLine());
                         Console.Clear();
                         SQUARE=4*length;
                         Console.WriteLine($"The Perimeter Of The Square is {SQUARE}");
                     }
                         else if(Shape==Rectangle)
                         {
                             Console.WriteLine("Please Enter The Length");
                             length=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             Console.WriteLine("Please Enter The Width");
                             width=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             RECTANGLE=2*(length+width);
                             Console.WriteLine($"The Perimeter Of The Rectangle is {RECTANGLE}");
                         }
                         else if(Shape==Circle) 
                         {
                             Console.WriteLine("Please Enter The Radius");
                             radius=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             CIRCLE=2*pie*radius;
                             Console.WriteLine($"The Area Of The Circle is {CIRCLE}");
                         }
                         else
                         {
                             Console.WriteLine("Shape Not Valid !");
                             Console.WriteLine("Please Enter A Valid Shape");
                         } 
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input !");
                        Console.WriteLine("Please Enter Area or Perimeter");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Wrong User Name or Password !");
                    Console.WriteLine("Please Enter User Name Again(2 Trials Remaining)");
                    username=Console.ReadLine();
                    Console.Clear();
                    user_name="ericndegwa";
                    if(username==user_name||username!=user_name)
                 {
                    Console.WriteLine("Please Enter Password");
                    Password=Console.ReadLine();
                    Console.Clear();
                    pass_word="microsoft";
                    if(Password==pass_word&&username==user_name)
                    {
                      
                    Console.WriteLine("AREA & PERIMETER OF SHAPES");
                    Console.WriteLine("Please Enter Area or Perimeter(use lower case)");
                    AREA_OR_PERIMETER=Console.ReadLine();
                    Console.Clear();
                    if(AREA_OR_PERIMETER==Area)
                    {
                     Console.WriteLine("Please Enter Any Of The Following Shapes:");
                     Console.WriteLine(">square");
                     Console.WriteLine(">rectangle");
                     Console.WriteLine(">circle");
                     Console.WriteLine(">sphere");
                     Shape=Console.ReadLine();
                     Console.Clear();
                     if(Shape==Square)
                     {
                         Console.WriteLine("Please Enter The Length");
                         length=Convert.ToDouble(Console.ReadLine());
                         Console.Clear();
                         square=length*length;
                         Console.WriteLine($"The Area Of The Square is {square}");
                     }
                         else if(Shape==Rectangle)
                         {
                             Console.WriteLine("Please Enter The Length");
                             length=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             Console.WriteLine("Please Enter The Width");
                             width=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             rectangle=length*width;
                             Console.WriteLine($"The Area Of The Rectangle is {rectangle}");
                         }
                         else if(Shape==Circle) 
                         {
                             Console.WriteLine("Please Enter The Radius");
                             radius=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             circle=pie*radius*radius;
                             Console.WriteLine($"The Area Of The Circle is {circle}");
                         }
                         else if(Shape==Sphere)
                         {
                             Console.WriteLine("Please Enter The Radius");
                             radius=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             sphere=4*pie*radius*radius;
                             Console.WriteLine($"The Area Of The Sphere is {sphere}");
                         }
                         else
                         {
                             Console.WriteLine("Shape Not Valid !");
                             Console.WriteLine("Please Enter A Valid Shape");
                         }
                    }
                    else if(AREA_OR_PERIMETER==Perimeter)
                    {
                     Console.WriteLine("Please Enter Any Of The Following Shapes:");
                     Console.WriteLine(">square");
                     Console.WriteLine(">rectangle");
                     Console.WriteLine(">circle");
                     Shape=Console.ReadLine(); 
                     Console.Clear();
                     if(Shape==Square)
                     {
                         Console.WriteLine("Please Enter The Length");
                         length=Convert.ToDouble(Console.ReadLine());
                         Console.Clear();
                         SQUARE=4*length;
                         Console.WriteLine($"The Perimeter Of The Square is {SQUARE}");
                     }
                         else if(Shape==Rectangle)
                         {
                             Console.WriteLine("Please Enter The Length");
                             length=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             Console.WriteLine("Please Enter The Width");
                             width=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             RECTANGLE=2*(length+width);
                             Console.WriteLine($"The Perimeter Of The Rectangle is {RECTANGLE}");
                         }
                         else if(Shape==Circle) 
                         {
                             Console.WriteLine("Please Enter The Radius");
                             radius=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             CIRCLE=2*pie*radius;
                             Console.WriteLine($"The Area Of The Circle is {CIRCLE}");
                         }
                         else
                         {
                             Console.WriteLine("Shape Not Valid !");
                             Console.WriteLine("Please Enter A Valid Shape");
                         } 
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input !");
                        Console.WriteLine("Please Enter Area or Perimeter");
                    }
                    }
                  else
                {
                    Console.WriteLine("Wrong User Name or Password !");
                    Console.WriteLine("Please Enter User Name Again(1 Trial Remaining)");
                    username=Console.ReadLine();
                    Console.Clear();
                    user_name="ericndegwa";
                    if(username==user_name||username!=user_name)
                {
                    Console.WriteLine("Please Enter Password");
                    Password=Console.ReadLine();
                    Console.Clear();
                    pass_word="microsoft";
                    if(Password==pass_word&&username==user_name)
                {
                    
                    Console.WriteLine("AREA & PERIMETER OF SHAPES");
                    Console.WriteLine("Please Enter Area or Perimeter(use lower case)");
                    AREA_OR_PERIMETER=Console.ReadLine();
                    Console.Clear();
                    if(AREA_OR_PERIMETER==Area)
                    {
                     Console.WriteLine("Please Enter Any Of The Following Shapes:");
                     Console.WriteLine(">square");
                     Console.WriteLine(">rectangle");
                     Console.WriteLine(">circle");
                     Console.WriteLine(">sphere");
                     Shape=Console.ReadLine();
                     Console.Clear();
                     if(Shape==Square)
                     {
                         Console.WriteLine("Please Enter The Length");
                         length=Convert.ToDouble(Console.ReadLine());
                         Console.Clear();
                         square=length*length;
                         Console.WriteLine($"The Area Of The Square is {square}");
                     }
                         else if(Shape==Rectangle)
                         {
                             Console.WriteLine("Please Enter The Length");
                             length=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             Console.WriteLine("Please Enter The Width");
                             width=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             rectangle=length*width;
                             Console.WriteLine($"The Area Of The Rectangle is {rectangle}");
                         }
                         else if(Shape==Circle) 
                         {
                             Console.WriteLine("Please Enter The Radius");
                             radius=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             circle=pie*radius*radius;
                             Console.WriteLine($"The Area Of The Circle is {circle}");
                         }
                         else if(Shape==Sphere)
                         {
                             Console.WriteLine("Please Enter The Radius");
                             radius=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             sphere=4*pie*radius*radius;
                             Console.WriteLine($"The Area Of The Sphere is {sphere}");
                         }
                         else
                         {
                             Console.WriteLine("Shape Not Valid !");
                             Console.WriteLine("Please Enter A Valid Shape");
                         }
                    }
                    else if(AREA_OR_PERIMETER==Perimeter)
                    {
                     Console.WriteLine("Please Enter Any Of The Following Shapes:");
                     Console.WriteLine(">square");
                     Console.WriteLine(">rectangle");
                     Console.WriteLine(">circle");
                     Shape=Console.ReadLine(); 
                     Console.Clear();
                     if(Shape==Square)
                     {
                         Console.WriteLine("Please Enter The Length");
                         length=Convert.ToDouble(Console.ReadLine());
                         Console.Clear();
                         SQUARE=4*length;
                         Console.WriteLine($"The Perimeter Of The Square is {SQUARE}");
                     }
                         else if(Shape==Rectangle)
                         {
                             Console.WriteLine("Please Enter The Length");
                             length=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             Console.WriteLine("Please Enter The Width");
                             width=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             RECTANGLE=2*(length+width);
                             Console.WriteLine($"The Perimeter Of The Rectangle is {RECTANGLE}");
                         }
                         else if(Shape==Circle) 
                         {
                             Console.WriteLine("Please Enter The Radius");
                             radius=Convert.ToDouble(Console.ReadLine());
                             Console.Clear();
                             CIRCLE=2*pie*radius;
                             Console.WriteLine($"The Area Of The Circle is {CIRCLE}");
                         }
                         else
                         {
                             Console.WriteLine("Shape Not Valid !");
                             Console.WriteLine("Please Enter A Valid Shape");
                         } 
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input !");
                        Console.WriteLine("Please Enter Area or Perimeter");
                    }
                }
                else
                {
                    Console.WriteLine("Three Times Exceeded !");
                }
                }
                }
                
                
                }
                }
                Console.ReadKey();
            }  
        }
    }
}

