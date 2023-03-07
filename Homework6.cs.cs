using System;

class Program {
    static void Main(string[] args) 
    {
        Professor Alice = new Professor("Alice", "Java", 9000);
        Professor Bob = new Professor("Bob", "Math", 8000);
        Student Lisa = new Student("Lisa", "Java", 90);
        Student Tom = new Student("Tom", "Math", 80);

        Console.WriteLine("Professor {0} teaches {1}, and the salary is: {2}", Alice.ProfName, Alice.ClassTeach, Alice.GetSalary());
        Console.WriteLine("Professor {0} teaches {1}, and the salary is: {2}", Bob.ProfName, Bob.ClassTeach, Bob.GetSalary());
        Console.WriteLine("Student {0} enrolls {1}, and the grade is: {2}", Lisa.StudentName, Lisa.ClassEnroll, Lisa.GetGrade());
        Console.WriteLine("Student {0} enrolls {1}, and the grade is: {2}", Tom.StudentName, Tom.ClassEnroll, Tom.GetGrade());

        double salary_diff = Alice.GetSalary() - Bob.GetSalary();
        Console.WriteLine("The salary difference between {0} and {1} is: {2}", Alice.ProfName, Bob.ProfName, salary_diff);

        double total_grade = Lisa.GetGrade() + Tom.GetGrade();
        Console.WriteLine("The total grade of {0} and {1} is: {2}", Lisa.StudentName, Tom.StudentName, total_grade);

        Console.ReadLine();
    }
}

class Professor {
    public string ProfName { get; }
    public string ClassTeach { get; }
    private double salary;

    public Professor(string profName, string classTeach, double salary) {
        ProfName = profName;
        ClassTeach = classTeach;
        this.salary = salary;
    }

    public void SetSalary(double salary_amount) {
        salary = salary_amount;
    }

    public double GetSalary() {
        return salary;
    }
}

class Student {
    public string StudentName { get; }
    public string ClassEnroll { get; }
    private double studentGrade;

    public Student(string studentName, string classEnroll, double studentGrade) {
        StudentName = studentName;
        ClassEnroll = classEnroll;
        this.studentGrade = studentGrade;
    }

    public void SetGrade(double newGrade) {
        studentGrade = newGrade;
    }

    public double GetGrade() {
        return studentGrade;
    }
}
