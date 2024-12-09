//Question 1 Start:
using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point();
        Point p2 = new Point(5, 10);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}


/*Why can't a struct inherit from another struct or class in C#?
In C#, structs are value types, and they are designed to be lightweight and efficient.
Allowing structs to inherit from other structs or classes would introduce complexity
and overhead that contradicts their purpose.
structs cannot inherit from other structs or classes Because
Memory Layout: Structs have a fixed memory layout,
and inheritance would complicate this layout, making it less efficient.

Performance: Inheritance introduces additional overhead, such as virtual method tables,
which would negate the performance benefits of using structs.
*/

//Question 1 End:




//Question 2 Start:
using System;

public class TypeA
{
    private int F;
    internal int G;
    public int H;

    public TypeA(int f, int g, int h)
    {
        F = f;
        G = g;
        H = h;
    }

    public int GetF()
    {
        return F;
    }

    public void SetF(int value)
    {
        F = value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TypeA obj = new TypeA(1, 2, 3);

        Console.WriteLine("Public H: " + obj.H);

        Console.WriteLine("Internal G: " + obj.G);

        Console.WriteLine("Private F: " + obj.GetF());
        obj.SetF(10);
        Console.WriteLine("Updated Private F: " + obj.GetF());
    }
}

/*How do access modifiers impact the scope and visibility of a class member?
Access modifiers in C# determine the visibility and accessibility
of class members (fields, methods, properties, etc.). Here's a brief overview:

Private: The member is accessible only within the same class.
It is not visible to other classes or code outside the class.

Internal: The member is accessible within the same assembly (project).
It is not visible to code in other assemblies.
*/

//Question 2 End:










//Qestion 3 Start:

using System;

public struct Employee
{
    private int EmpId;
    private string Name;
    private decimal Salary;

    public int EmployeeId
    {
        get { return EmpId; }
        set { EmpId = value; }
    }

    public string EmployeeName
    {
        get { return Name; }
        set { Name = value; }
    }

    public decimal EmployeeSalary
    {
        get { return Salary; }
        set { Salary = value; }
    }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();

        emp.EmployeeId = 1;
        emp.EmployeeName = "Fady Adel";
        emp.EmployeeSalary = 50000.00m;

        Console.WriteLine("Employee ID: " + emp.EmployeeId);
        Console.WriteLine("Employee Name: " + emp.EmployeeName);
        Console.WriteLine("Employee Salary: " + emp.EmployeeSalary);

        emp.SetName("Jane Doe");
        Console.WriteLine("Updated Employee Name: " + emp.GetName());
    }
}

/*Why is encapsulation critical in software design?
Encapsulation is a fundamental principle in software design for
Data Hiding: Encapsulation allows you to hide the internal state of an object
and only expose a controlled interface.
This prevents external code from directly accessing and
modifying the internal state, which can help maintain the integrity of the data.
*/

//Qestion 3 End:




//Question 4 Start:
using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x)
    {
        X = x;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(5);
        Console.WriteLine(p1);

        Point p2 = new Point(3, 7);
        Console.WriteLine(p2);
    }
}

/*What are constructors in structs?
Constructors in structs are special methods used to
initialize the struct's fields when an instance of the struct is created.
In C#, structs can have parameterized constructors, but they cannot
have a parameterless constructor (default constructor) that you define explicitly.
*/

//Question 4 End:






//Question 5 Start:
using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x)
    {
        X = x;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Point [X={X}, Y={Y}]";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(5);
        Point p2 = new Point(3, 7);
        Point p3 = new Point(10, 20);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
    }
}

/*How does overriding methods like ToString() improve code readability?
Overriding methods like ToString() improves code readability in Several Ways:

Clarity: By providing a meaningful string representation of an object, it becomes easier
to understand what the object represents when it is printed or logged.
This is especially useful for debugging and logging purposes.

Customization: You can customize the output to include relevant information
in a format that makes sense for your application.
This helps convey the object's state more effectively.
*/

//Question 5 End:









//Question 6 Start:
using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Point [X={X}, Y={Y}]";
    }
}

public class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(int empId, string name, decimal salary)
    {
        EmpId = empId;
        Name = name;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Employee [EmpId={EmpId}, Name={Name}, Salary={Salary}]";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p = new Point(1, 2);
        Employee e = new Employee(101, "John Doe", 50000m);

        Console.WriteLine("Before method call:");
        Console.WriteLine(p);
        Console.WriteLine(e);

        ModifyPoint(p);
        ModifyEmployee(e);

        Console.WriteLine("After method call:");
        Console.WriteLine(p);
        Console.WriteLine(e);
    }

    static void ModifyPoint(Point point)
    {
        point.X = 10;
        point.Y = 20;
    }

    static void ModifyEmployee(Employee employee)
    {
        employee.EmpId = 102;
        employee.Name = "Jane Doe";
        employee.Salary = 60000m;
    }
}


/*How does memory allocation differ for structs and classes in C#?
In C#, structs and classes have different memory allocation behaviors:

Structs (Value Types):

Memory Allocation: Structs are allocated on the stack
when they are local variables or fields of a class.
They are stored directly in the memory location where they are declared.

Copying: When a struct is passed to a method or assigned to another variable,
a copy of the entire struct is made.
This means changes to the copy do not affect the original struct.

Classes (Reference Types):

Memory Allocation: Classes are allocated on the heap,
and a reference to the object is stored in the variable.
The actual data is stored in the heap memory.

Copying: When a class instance is passed to a method or assigned to another variable,
only the reference (pointer) to the object is copied, not the object itself.
This means changes to the object through the reference affect the original object.
*/

//Question 6 End: