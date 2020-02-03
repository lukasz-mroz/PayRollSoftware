using System;

namespace PayRollSoftware
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
  // contains information about each staff in the company
  class Staff
  {
    private float hourlyRate;
    private int hWorked;

    public float TotalPay { get; protected set; }
    public float BasicPay { get; private set; }
    public string NameOfStaff { get; private set; }
    public int HoursWorked { get; }

    public Staff(string name,float rate)
    {
      NameOfStaff = name;
      hourlyRate = rate;
    }

    public virtual void CalculatePay()
    {
      Console.WriteLine("Calculating Pay...");
      var sum = hWorked * hourlyRate;
    }



  }













  class Manager 
  {

  }
  class Admin
  {

  }
  class FileReader
  {

  }
  class PaySlip
  {

  }

}
