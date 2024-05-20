namespace LINQ;

// WAP to make a list for student and display record whose address
// is kathmandu 
class Program
{

    class Student {
        public string Name {get; set;}
        public string Address {get; set;}

        public string Gender {get; set;}
    }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        Student s1 = new Student();
        s1.Name="Sandesh Humagain"; s1.Address = "Koteshwor"; s1.Gender = "Male";
        students.Add(s1);

        Student s2 = new Student();
        s2.Name = "Sita Mandal"; s2.Address = "Janakpur"; s2.Gender = "Female";
        students.Add(s2);

        Student s3 = new Student();
        s3.Name = "Kukku Kali"; s3.Address = "Mumbai"; s3.Gender = "Female";
        students.Add(s3);

        Student s4 = new Student();
        s4.Name = "Anita Bari"; s4.Address = "Dhading"; s4.Gender = "Female";
        students.Add(s4);

        var result = from a in students where a.Gender == "Female" orderby a.Name ascending select a;

        foreach(Student student in result){
            Console.WriteLine($"Name: {student.Name}, Address: {student.Address}, Gender: {student.Gender}");
        }

    }
}
