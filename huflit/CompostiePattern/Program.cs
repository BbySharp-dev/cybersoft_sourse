using System;
using System.Collections.Generic;

// Interface cho các loại nhân viên
interface IEmployee
{
    string Name { get; set; }
    string Dept { get; set; }
    string Designation { get; set; }
    void DisplayDetails();
}

// Nút lá - Đại diện cho nhân viên bình thường
class Employee : IEmployee
{
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Designation { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"\t{Name} làm việc ở bộ phận {Dept}. Chức vụ: {Designation}");
    }
}

// Nút composite - Đại diện cho quản lý (có nhân viên cấp dưới)
class CompositeEmployee : IEmployee
{
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Designation { get; set; }

    private List<IEmployee> subordinates = new List<IEmployee>();

    public void AddEmployee(IEmployee e)
    {
        subordinates.Add(e);
    }

    public void RemoveEmployee(IEmployee e)
    {
        subordinates.Remove(e);
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"\n{Name} làm việc ở bộ phận {Dept}. Chức vụ: {Designation}");
        foreach (IEmployee e in subordinates)
        {
            e.DisplayDetails();
        }
    }
}

// Chương trình chính
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Composite Pattern Demo ***");

        // Tạo giảng viên cho bộ môn Toán
        Employee mathTeacher1 = new Employee { Name = "M.Joy", Dept = "Toán", Designation = "Giảng viên" };
        Employee mathTeacher2 = new Employee { Name = "M.Roony", Dept = "Toán", Designation = "Giảng viên" };

        // Trưởng bộ môn Toán
        CompositeEmployee hodMaths = new CompositeEmployee { Name = "Mrs. S.Das", Dept = "Toán", Designation = "Trưởng bộ môn" };
        hodMaths.AddEmployee(mathTeacher1);
        hodMaths.AddEmployee(mathTeacher2);

        // Tạo giảng viên cho bộ môn CNTT
        Employee cseTeacher1 = new Employee { Name = "C.Sam", Dept = "CNTT", Designation = "Giảng viên" };
        Employee cseTeacher2 = new Employee { Name = "C.Jones", Dept = "CNTT", Designation = "Giảng viên" };
        Employee cseTeacher3 = new Employee { Name = "C.Marium", Dept = "CNTT", Designation = "Giảng viên" };

        // Trưởng bộ môn CNTT
        CompositeEmployee hodCompSc = new CompositeEmployee { Name = "Mr. V.Sarcar", Dept = "CNTT", Designation = "Trưởng bộ môn" };
        hodCompSc.AddEmployee(cseTeacher1);
        hodCompSc.AddEmployee(cseTeacher2);
        hodCompSc.AddEmployee(cseTeacher3);

        // Hiệu trưởng
        CompositeEmployee principal = new CompositeEmployee { Name = "Dr. S.Som", Dept = "Quản lý", Designation = "Hiệu trưởng" };
        principal.AddEmployee(hodMaths);
        principal.AddEmployee(hodCompSc);

        // Hiển thị cơ cấu tổ chức
        Console.WriteLine("\nCơ cấu tổ chức nhà trường:");
        principal.DisplayDetails();
    }
}
