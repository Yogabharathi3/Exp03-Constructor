# Exp03-Constructor
## Aim: 
To write a C# program to calculate the salary of an employee by passing the name, designation, noofexperience, basic salary and insurance amount through constructor.

## Algorithm:
### Step1 :

Initialize the program with the system library.

### Step2 :

Define the Employee Class and set it as public.

### Step3 :

Define the variables.

### Step4 :

Write a parameterized constructor under the class Employee.

### Step5 :

Define a function to calculate the salary.
### Step6 :

Define the display() function to print the output.

## Program :

### DEVELOPED BY : YOGABHARATHI S
### REGISTER NO : 212222230179

```
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
```

## Output:
![alt text](<Screenshot 2024-03-04 133219.png>)
## Result:
Thus, a C# program is written to calculate the salary of an employee using a constructor is implemented and the output is verified.
