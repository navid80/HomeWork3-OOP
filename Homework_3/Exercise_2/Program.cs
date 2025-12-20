namespace Exercise_2
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            people.Add(new Student
            {
                Name = "Ali Miri",
                Age = 20,
                StudentId = "S123",
                Major = "Computer Science"
            });

            people.Add(new Professor
            {
                Name = "Dr. Sara Amini",
                Age = 45,
                ProfessorId = "P456",
                Subject = "Data Mining"
            });

            people.Add(new Student
            {
                Name = "Mina Ahmadi",
                Age = 22,
                StudentId = "S124",
                Major = "Mathematics"
            });

            people.Add(new Professor
            {
                Name = "Reza Keshavarz",
                Age = 52,
                ProfessorId = "4125",
                Subject = "Physics"
            });

            foreach (Person person in people)
            {
                Console.WriteLine(person.GetDetails());
            }
        }
    }
}
