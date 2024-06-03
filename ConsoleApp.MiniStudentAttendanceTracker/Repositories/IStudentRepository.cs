namespace ConsoleApp.MiniStudentAttendanceTracker;

public interface IStudentRepository
{
    void AddStudent(Student student);
    Student GetStudent(int id);
    IEnumerable<Student> GetAllStudents();
}