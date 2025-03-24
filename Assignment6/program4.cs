using System;

class BooleanCourse
{
    public string CourseName { get; }
    public bool IsPassed { get; }
    
    public BooleanCourse(string courseName, bool isPassed)
    {
        CourseName = courseName;
        IsPassed = isPassed;
    }
    
    public bool Passed() => IsPassed;
}

class GradedCourse
{
    public string CourseName { get; }
    public int Grade { get; }
    
    public GradedCourse(string courseName, int grade)
    {
        CourseName = courseName;
        Grade = grade;
    }
    
    public bool Passed() => Grade >= 2;
}

class Project
{
    private BooleanCourse course1, course2;
    private GradedCourse course3, course4;
    
    public Project(BooleanCourse c1, BooleanCourse c2, GradedCourse c3, GradedCourse c4)
    {
        course1 = c1;
        course2 = c2;
        course3 = c3;
        course4 = c4;
    }
    
    public bool Passed()
    {
        int passCount = (course1.Passed() ? 1 : 0) + (course2.Passed() ? 1 : 0) +
                        (course3.Passed() ? 1 : 0) + (course4.Passed() ? 1 : 0);
        return passCount >= 3;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Boolean Course 1 name: ");
        string bc1Name = Console.ReadLine();
        Console.Write("Did the student pass? (true/false): ");
        bool bc1Passed = bool.Parse(Console.ReadLine());

        Console.Write("Enter Boolean Course 2 name: ");
        string bc2Name = Console.ReadLine();
        Console.Write("Did the student pass? (true/false): ");
        bool bc2Passed = bool.Parse(Console.ReadLine());

        Console.Write("Enter Graded Course 1 name: ");
        string gc1Name = Console.ReadLine();
        Console.Write("Enter grade: ");
        int gc1Grade = int.Parse(Console.ReadLine());

        Console.Write("Enter Graded Course 2 name: ");
        string gc2Name = Console.ReadLine();
        Console.Write("Enter grade: ");
        int gc2Grade = int.Parse(Console.ReadLine());

        BooleanCourse bc1 = new BooleanCourse(bc1Name, bc1Passed);
        BooleanCourse bc2 = new BooleanCourse(bc2Name, bc2Passed);
        GradedCourse gc1 = new GradedCourse(gc1Name, gc1Grade);
        GradedCourse gc2 = new GradedCourse(gc2Name, gc2Grade);
        
        Project project = new Project(bc1, bc2, gc1, gc2);
        Console.WriteLine("Project Passed: " + project.Passed());
    }
}
