using System;
class Student
{
   int age=20;
   string name="Pranay Hajre";
   void show()
    {
        Console.WriteLine("Name is: "+name);
        Console.WriteLine("Age is: "+age);
        Console.WriteLine("College name :  SSGMCE");
        Console.WriteLine("Brance name:   CSE");
         Console.WriteLine("Roll number:   63");



    }
   static void Main()
    { 
    // Student s=new Student();
    // s.show();
    // Array a=new Array();
    // a.Display_List();
    Monthly_Sales m=new Monthly_Sales();
    m.show_Sales();
    Console.WriteLine("----------------------------------------------------------------------------------------");
    Library l=new Library();
    l.show_books();

        
    } 
}    
