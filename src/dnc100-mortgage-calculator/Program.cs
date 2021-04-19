using System;
using System.Text.RegularExpressions;

namespace dnc100_mortgage_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage;
            double principal, interestRate, monthlyPayment;
            int term, period;
            // Use .WriteLine to greet the user
            Console.WriteLine("Hello User");
            // Use a mix of WriteLine and ReadLine to obtain the mortgage attributes (Making sure to typecast)
            Console.WriteLine("What is your loan amount?");
            string loan, rate, terM, paymentFrequency;
            loan = Console.ReadLine();
            string parsedLoan = Regex.Replace(loan, "[^0-9]", "");
            Console.Clear();
            Console.WriteLine($"LOAN AMOUNT: {parsedLoan}");
            Console.WriteLine("What is your intrest rate?");
            rate = Console.ReadLine();
            string parsedRate = Regex.Replace(rate, "[^0-9]", "");
            Console.Clear();

            Console.WriteLine($"LOAN AMOUNT: {parsedLoan} \r\nINTREST RATE : {parsedRate} ");
            Console.WriteLine("How many years is your mortgage?");
            terM = Console.ReadLine();
            string parsedTerm = Regex.Replace(terM, "[^0-9 + . + ,]", "");
            Console.Clear();

            Console.WriteLine($"LOAN AMOUNT: {parsedLoan} \r\nINTREST RATE : {parsedRate} \r\nMORTGAGE TERM: {parsedTerm}");
            Console.WriteLine("Enter 1) for monthly payments \n\r Enter 2) for bi-monthly payments.");
            paymentFrequency = Console.ReadLine();
            string parsedPaymentFrequency = Regex.Replace(terM, "[^0-9 + . + ,]", "");
            Console.Clear();

            // Create a new Mortgage with the given attributes;
            new Mortgage(double principle, double interest, int term, int period)

            // Use the Mortgage functions to calculate the monthly payment

            // Use WriteLine to output the monthly payment
        }
    }
}
