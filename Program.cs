using System;
using System.Data;


class Program
{
    static void Main(string[] args)
    {
      Apple a1=new Apple("Россия","ранетка",135.2,"Круглая","барбос",21.3,true);
       Apple a2=new Apple("Россия","ранетка",135.2,"Круглая","барбос",21.3,false);
       DateTime datasbora=new DateTime(2015, 7, 20);
       
       Berry b1=new Berry("Азейборджан", "Черешня", 55.23, "Круглая", Color.красный, datasbora,true);
       a1.DisplayInfo();
       a2.DisplayInfo();
       b1.DisplayInfo();
    }
}