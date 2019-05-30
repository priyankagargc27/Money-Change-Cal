using System;

namespace MoneyChangeCal {
    class Program {
        static void Main () {
            Console.WriteLine ($"Enter the receipt number");
            decimal receipt = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine ("Enter the amount you want to change:");
            decimal price = Convert.ToDecimal (Console.ReadLine ());
            Console.WriteLine ($"The Calculated Change for this receipt {receipt}:");
            Console.WriteLine ("-----------------------------------------");

            // Console.WriteLine($"The Calculated Price is: {price}");

            Change change = new Change (price);

            Console.WriteLine ($"Hundred Dollar Bills: {change.HundredDollarBills}");
            Console.WriteLine ("-----------------------------------------");

            Console.WriteLine ($"Fifty Dollar Bills: {change.FiveDollarBills}");
            Console.WriteLine ("-----------------------------------------");

            Console.WriteLine ($"Twenty Dollar Bills: {change.TwentyDollarBills}");
            Console.WriteLine ("-----------------------------------------");

            Console.WriteLine ($"Ten Dollar Bills: {change.TenDollarBills}");
            Console.WriteLine ("-----------------------------------------");

            Console.WriteLine ($"Five Dollar Bills: {change.FiveDollarBills}");
            Console.WriteLine ("-----------------------------------------");

            Console.WriteLine ($"Dollar Bills: {change.DollarBills}");
            Console.WriteLine ("-----------------------------------------");

            Console.WriteLine ($"Quarters: {change.Quarters}");
            Console.WriteLine ("-----------------------------------------");

            Console.WriteLine ($"Dimes: {change.Dimes}");
            Console.WriteLine ("-----------------------------------------");

            Console.WriteLine ($"Nickels: {change.Nickels}");
            Console.WriteLine ("-----------------------------------------");

            Console.WriteLine ($"Pennies: {change.Pennies}");
            Console.WriteLine ("-----------------------------------------");

        }
    }

    public class Change {
        public int HundredDollarBills { get; }
        public int FiftyDollarBills { get; }
        public int TwentyDollarBills { get; }
        public int TenDollarBills { get; }
        public int FiveDollarBills { get; }
        public int DollarBills { get; }
        public int Quarters { get; }
        public int Dimes { get; }
        public int Nickels { get; }
        public int Pennies { get; }

        public Change (decimal price) {
            HundredDollarBills = (int) (price / 100);
            price %= 100;

            FiftyDollarBills = (int) (price / 50);
            price %= 50;

            TwentyDollarBills = (int) (price / 20);
            price %= 20;

            TenDollarBills = (int) (price / 10);
            price %= 10;

            FiveDollarBills = (int) (price / 5);
            price %= 5;

            DollarBills = (int) (price / 1);
            price %= 1;

            Quarters = (int) (price / .25m);
            price %= .25m;

            Dimes = (int) (price / .10m);
            price %= .10m;

            Nickels = (int) (price / .05m);
            price %= .05m;

            Pennies = (int) (price / .01m);
        }
    }
}