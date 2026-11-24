
using System;

// A subcontractor has the contractor details plus shift and pay information.
public class Subcontractor : Contractor
{
    public int Shift { get; set; }
    public double HourlyPayRate { get; set; }
    public float HoursWorked { get; set; }

    public Subcontractor(string name, int contractorNumber, DateTime startDate,
                         int shift, double hourlyPayRate, float hoursWorked)
        : base(name, contractorNumber, startDate)
    {
        Shift = shift;
        HourlyPayRate = hourlyPayRate;
        HoursWorked = hoursWorked;
    }

    // Calculate total pay, including a 3% increase for the night shift.
    public float CalculatePay()
    {
        double totalPay = HourlyPayRate * HoursWorked;

        if (Shift == 2)
        {
            totalPay *= 1.03;
        }

        // The assignment asks for a method that returns a float.
        return (float)totalPay;
    }
}
