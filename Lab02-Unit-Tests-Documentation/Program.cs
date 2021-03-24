using System;

namespace Lab02_Unit_Tests_Documentation
{
    public class Program
    {
        public static decimal Balance = 2034;
        public static decimal referenceBalance = Balance;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to My ATM. An ATM of ATM Corp.");
            userInterface();
        } // end Main Method
         public static void userInterface()
        {
            string one = "View Balance";
            string two = "Withdraw";
            string three = "Deposit";

            Console.WriteLine("What would you like to do? Press 1 to View Balance, 2 to make a Withdraw, 3 to make a Deposit, and 4 to exit.");
            string userInput = Console.ReadLine();

            int userIntput = Convert.ToInt32(userInput);
            string screen = " ";
            if (userIntput == 1)
            {
                screen = one;
                Console.WriteLine($"You have entered: {userIntput}. Please wait while I load the {screen} page.");
                decimal userBalance = ViewBalance();
                Console.WriteLine($"Your Balance is: ${userBalance}.");
                userInterface();

            } // end if

            else if (userIntput == 2)
            {
                screen = two;
                Console.WriteLine($"You have entered: {userIntput}. Please wait while I load the {screen} page.");
                Console.WriteLine($"Please enter the amount you want to withdraw. Your balance is: ${Balance}.");
                decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                decimal withDrawn = Withdraw(withdrawAmount);
                
                Console.WriteLine($"You have withdrawn ${withdrawAmount}. Your new Balance is: ${withDrawn}.");
                userInterface();
            } // end else if

            else if (userIntput == 3)
            {
                screen = three;
                Console.WriteLine($"You have entered: {userIntput}. Please wait while I load the {screen} page.");
                Console.WriteLine($"Please enter the amount you want to Deposit.");
                decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                decimal userDeposit = Deposit(depositAmount);
                Console.WriteLine($"You have deposited ${depositAmount}. Your new Balance is: ${userDeposit}.");
                userInterface();
            } // end else if

            else if (userIntput == 4)
            {
                Console.WriteLine("Thank you for visiting My ATM. Have a nice day!");
            } // end else if

            else
            {
                Console.WriteLine("You did not enter a valid option. Please try again.");
                userInterface();
            } // end else 

        } // end User Interface method

        public static decimal ViewBalance()
        {

            return Balance;
        } // end View Balance Method 

        public static decimal Withdraw(decimal num)
        {
            
            if (num > Balance)
            {
                throw new ApplicationException($"You tried to withdraw {num} which is greater " +
                    $"than your balance of {Balance}!");
            } // end if
            else if (num < 0)
            {
                throw new ApplicationException($"You entered an Amount Less than 0!");
            } // end else if
            else
            {
                Balance = Balance - num;
            } // end else

            return Balance;
        } // end Withdraw method

        public static decimal Deposit(decimal num)
        {
            
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException(null, $"You entered an Amount Less than 0!") ;
            } // end if
            else
            {
                Balance = Balance + num;
                return Balance;
            } // end else
            
        } // end Deposit method
    }
}
