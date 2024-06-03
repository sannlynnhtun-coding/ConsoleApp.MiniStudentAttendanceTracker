namespace ConsoleApp.MiniStudentAttendanceTracker;

public interface IAttendanceRepository
{
    void AddAttendanceRecord(AttendanceRecord record);
    IEnumerable<AttendanceRecord> GetAttendanceRecordsByStudent(int studentId);
}