namespace Interview_Prep
{
    using Interview_Prep.ROITI;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            //First
            Console.WriteLine(new FirstEx().Exe(new int[] { 10, 22, 11, -94, 33, 0, 5 }));

            //Second
            Console.WriteLine(new SecondEx().Exe("2 beers or not 12.3 beers"));

            //Third
            var p1 = new Person("Peter ", 15);
            var p2 = new Person("Ivan ", 23);

            Console.WriteLine(Person.Compare(p1, p2));

            //Forth

            //[1] select Id, Name from Departments
                  //inner join Employees as e on e.DepartmentId = null

            //[2] select Id, Name from Departments
                  //where select(Count(*) from Employees where DepartmentId = Id) < 3
                  

            //Fifth
            new Pyramid().Exe(10);
        }
    }

}
