namespace StudentLibrary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }

        public Student(int id, string name, int age, double gpa)
        {
            if (gpa < 0 || gpa > 4.0)
                throw new ArgumentException("GPA must be between 0.0 and 4.0");

            Id = id;
            Name = name;
            Age = age;
            GPA = gpa;
        }
    }
}

