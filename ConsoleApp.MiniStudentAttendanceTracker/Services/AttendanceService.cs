namespace ConsoleApp.MiniStudentAttendanceTracker.Services;

public class AttendanceService
{
    private readonly IStudentRepository _studentRepository;
    private readonly IAttendanceRepository _attendanceRepository;

    public AttendanceService(IStudentRepository studentRepository, IAttendanceRepository attendanceRepository)
    {
        _studentRepository = studentRepository;
        _attendanceRepository = attendanceRepository;
    }

    public void MarkAttendance(int studentId, DateTime date, bool isPresent)
    {
        var student = _studentRepository.GetStudent(studentId);
        if (student == null)
        {
            throw new ArgumentException("Student not found.");
        }

        var record = new AttendanceRecord
        {
            StudentId = studentId,
            Date = date,
            IsPresent = isPresent
        };

        _attendanceRepository.AddAttendanceRecord(record);
    }

    public IEnumerable<AttendanceRecord> GetAttendanceByStudent(int studentId)
    {
        return _attendanceRepository.GetAttendanceRecordsByStudent(studentId);
    }
}