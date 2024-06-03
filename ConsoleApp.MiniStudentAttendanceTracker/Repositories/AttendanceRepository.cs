namespace ConsoleApp.MiniStudentAttendanceTracker;

public class AttendanceRepository : IAttendanceRepository
{
    private readonly List<AttendanceRecord> _attendanceRecords = new List<AttendanceRecord>();

    public void AddAttendanceRecord(AttendanceRecord record)
    {
        _attendanceRecords.Add(record);
    }

    public IEnumerable<AttendanceRecord> GetAttendanceRecordsByStudent(int studentId)
    {
        return _attendanceRecords.Where(r => r.StudentId == studentId);
    }
}