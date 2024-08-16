Course matematicas = new Course("matematicas");
matematicas.setCode(1000);
Student jorge = new Student("jorge");
Console.WriteLine($"curso: {matematicas.name}");
Console.WriteLine($"codigo: {matematicas.getCode()}");
Console.WriteLine("!------Lista-----!");
matematicas.addStudent(jorge);

foreach(Student student in matematicas.getStudents()){
    Console.WriteLine($"alumno: {student.full_name}");
}

public class Course
{
    public string name { get; set;}
    private int code;
    private List<Student> students = new List<Student>();

    public Course(string name){
        this.name = name;
    }

    public void setCode(int code){
        this.code = code;
    }

    public int getCode()
    {
        return this.code;
    }

    public void addStudent(Student student)
    {
        this.students.Add(student);
    }

    public List<Student> getStudents()
    {
        return this.students;
    }
}

public class Student
{
    public string full_name {get; set;}

    public Student(string full_name)
    {
        this.full_name = full_name;
    }
}
