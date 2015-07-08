using System;
class ExamSchedule
{
    static void Main()
    {
        int startHours = int.Parse(Console.ReadLine());
        int startMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());
        startHours = startHours % 12;
        if (partOfDay == "PM")
        {
            startHours += 12;
        }
        DateTime start = new DateTime(2000, 1, 1, startHours, startMinutes, 0);
        DateTime endTime = start.AddHours(durationHours).AddMinutes(durationMinutes);
        Console.WriteLine("{0:hh:mm:tt}", endTime);
    }
}
