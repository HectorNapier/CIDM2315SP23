namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        
        double totalGPA = 0;
        foreach (double gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;

        
        Console.WriteLine("The average GPA is: {0:F2}", averageGPA);
        foreach (KeyValuePair<string, double> pair in gradebook)
        {
            if (pair.Value > averageGPA)
            {
                Student.PrintInfo(pair.Key);
            }
        }
    }
}

class Student
{
    private int studentID;
    private string studentName;

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public static List<Student> studentList = new List<Student>();

    public static void PrintInfo(string name)
    {
        foreach (Student student in studentList)
        {
            if (student.studentName == name)
            {
                Console.WriteLine("Student ID: {0}, Student Name: {1}", student.studentID, student.studentName);
            }
        }
    }
}
