namespace ConsoleApp.MiniStudentAttendanceTracker.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly List<Student> _students = new List<Student>();

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public Student GetStudent(int id)
    {
        return _students.FirstOrDefault(s => s.Id == id);
    }

    public IEnumerable<Student> GetAllStudents()
    {
        return _students;
    }
}