namespace Interview_Prep.ROITI
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public static bool Compare(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }
    }
}
