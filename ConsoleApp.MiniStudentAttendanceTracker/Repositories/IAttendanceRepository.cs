namespace ConsoleApp.MiniStudentAttendanceTracker.Repositories;

public interface IAttendanceRepository
{
    void AddAttendanceRecord(AttendanceRecord record);
    IEnumerable<AttendanceRecord> GetAttendanceRecordsByStudent(int studentId);
}