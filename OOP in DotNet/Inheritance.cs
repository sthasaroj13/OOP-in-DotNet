// Inheritance  

//Admin is parent class
class Admin
{
    int id;
    String name;

    //made method to Accepet id and name
    internal void  Accept (int id,String name)
    {
        this.id = id;
        this.name = name;
    }
    // method to display id and name
   internal void Display() {
        Console.WriteLine("Id is {0} and the name is {1}", id, name);
            }
}


//chid class and inheritating from  parent class
class Employee:Admin
{
    double salary;
  internal  void Accept1(double salary)
    {
        this.salary = salary;
       
    }
    internal double GetSalary()
    {
        return salary;
    }
   internal void Display1()
    {
        Console.WriteLine("Salary is {0}",salary);
    }
    

    //public static void Main(String[] args)
    //{
    //    Employee emp = new Employee();
    //    emp.Accept(10001, "saroj shrestha");
    //    emp.Display();
    //    emp.Accept1(12000.01);
    //    emp.Display1();
    //}
}
class OtherStaff:Employee
{
    double allowance;
    void Accept2(double allowance)
    {
        this.allowance = allowance;
    }
    double GetAllowance()
    {
        return allowance;
    }
    void Display2() { 
    Console.WriteLine("Allowance  is : {0}",allowance);
    }
    void DisplayTotal()
    {
        double total = GetSalary()+ GetAllowance() ;
        Console.WriteLine("the total Salary including with allowance is :{0}",total);
    }

    public static void Main(String[] args) { 
    
    OtherStaff otherStaff = new OtherStaff();
        otherStaff.Accept(10001, "saroj shrestha");
        otherStaff.Display();
        otherStaff.Accept1(12000.01);
        otherStaff.Display1();
        otherStaff.Accept2(5000);
            otherStaff.Display2();
        otherStaff.DisplayTotal();
    }
}