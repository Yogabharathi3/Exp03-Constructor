using System;

class Employee
{
    private string name;
    private string designation;
    private int experience;
    private double basicSalary;
    private double hra;
    private double ta;
    private double grosspay;
    private double insuranceAmount;



    public Employee(string name, string designation, int experience, double basicSalary, double insuranceAmount)
    {
        this.name = name;
        this.designation = designation;
        this.experience = experience;
        this.basicSalary = basicSalary;
        this.insuranceAmount = insuranceAmount;


        hra = 0.1 * basicSalary;
        ta = 0.2 * basicSalary;
        grosspay = 0.15 * basicSalary;
    }


    public double CalculateSalary()
    {
        return basicSalary + hra + ta + insuranceAmount - grosspay;
    }


    public void Display()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee Designation: " + designation);
        Console.WriteLine("Employee No of Experience: " + experience);
        Console.WriteLine("Employee Basic Salary: " + basicSalary);
        Console.WriteLine("Employee Insurance Amount: " + insuranceAmount);
        Console.WriteLine("Employee HRA: " + hra);
        Console.WriteLine("Employee TA: " + ta);
        Console.WriteLine("Employee GROSSPAY: " + grosspay);
        Console.WriteLine("Employee Salary: " + CalculateSalary());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee("Yogi", "Lawyer", 10000,4, 500);
        emp1.Display();
        Employee emp2 = new Employee("Jaya", "Engineer", 40000, 3, 2000);
        emp2.Display();
    }
}