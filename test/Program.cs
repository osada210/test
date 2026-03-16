using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int MaxWorkDays { get; set; }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee();
        emp1.Id = 1;
        emp1.Name = "田中太郎";
        emp1.MaxWorkDays = 5;

        Employee emp2 = new Employee();
        emp2.Id = 2;
        emp2.Name = "鈴木花子";
        emp2.MaxWorkDays = 3;

        Employee emp3 = new Employee();
        emp3.Id = 3;
        emp3.Name = "佐藤次郎";
        emp3.MaxWorkDays = 4;

        Console.WriteLine($"ID:{emp1.Id} {emp1.Name} 最大勤務日数:{emp1.MaxWorkDays}日");
        Console.WriteLine($"ID:{emp2.Id} {emp2.Name} 最大勤務日数:{emp2.MaxWorkDays}日");
        Console.WriteLine($"ID:{emp3.Id} {emp3.Name} 最大勤務日数:{emp3.MaxWorkDays}日");
    }
}