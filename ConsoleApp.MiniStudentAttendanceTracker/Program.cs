using ConsoleApp.MiniStudentAttendanceTracker;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<IStudentRepository, StudentRepository>()
    .AddSingleton<IAttendanceRepository, AttendanceRepository>()
    .AddSingleton<AttendanceService>()
    .BuildServiceProvider();

var attendanceService = serviceProvider.GetService<AttendanceService>()!;

var student1 = new Student { Id = 1, Name = "John Doe" };
var student2 = new Student { Id = 2, Name = "Jane Smith" };

var studentRepository = serviceProvider.GetService<IStudentRepository>()!;
studentRepository.AddStudent(student1);
studentRepository.AddStudent(student2);

attendanceService.MarkAttendance(1, DateTime.Now, true);
attendanceService.MarkAttendance(2, DateTime.Now, false);

DisplayAttendanceRecords(attendanceService, 1);
DisplayAttendanceRecords(attendanceService, 2);

static void DisplayAttendanceRecords(AttendanceService attendanceService, int studentId)
{
    var records = attendanceService.GetAttendanceByStudent(studentId);

    Console.WriteLine($"Attendance records for student {studentId}:");
    foreach (var record in records)
    {
        Console.WriteLine($"Date: {record.Date}, Present: {record.IsPresent}");
    }
}
