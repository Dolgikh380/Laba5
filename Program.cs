using System;
using System.Data;


class Program
{
    static void Main(string[] args)
    {
      Apple a1=new Apple("Россия","ранетка",135.2,"Круглая","барбос",21.3,true );
       Console.WriteLine(a1.sort);
       Apple a2=new Apple("Россия","ранетка",135.2,"Круглая","барбос",21.3,true );
       DateTime datasbora=new DateTime(02/12/1993);
       Berry b1=new Berry("Hhmfdkjfd","fjhnvdkj", 25.32,"gfhbdkjfg",Color.красный, datasbora, true );
       Console.WriteLine(b1.datasbora);
    }
}