using System;
using Lab02_Unit_Tests_Documentation;
using Xunit;

namespace BankTest
{
    public class UnitTest1
    {
        [Fact]
        public void bank_test_for_checking_balance()
        {
            // arrange
            Program.Balance = 2000;

            // act
            decimal result = Program.ViewBalance();

            // assert
            Assert.Equal(2000, result);
        } // end checking balance test


        [Fact]
        public void bank_test_for_withdrawing_passing()
        {
            // arrange
            Program.Balance = 2000;
            decimal withDraw = 500;

            // act
            decimal result = Program.Withdraw(withDraw);

            // assert
            Assert.Equal(1500, result);
        } // end checking withdraw test

        [Fact]
        public void bank_test_for_withdrawing_failing()
        {
            // arrange
            Program.Balance = 2000;
            decimal withDraw = 2001;

            // assert
            Assert.Throws<ApplicationException>(() =>
            {

                // act
                decimal result = Program.Withdraw(withDraw);
            });

            Assert.Equal(2000, Program.Balance);
        } // end checking balance exception test

        [Fact]
        public void bank_test_for_deposit_failing()
        {
            // arrange
            Program.Balance = 2000;
            decimal deposit = -1;

            // assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                // act
                decimal result = Program.Deposit(deposit);
            });

            Assert.Equal($"You entered an Amount Less than 0!", ex.Message);

            Assert.Equal(2000, Program.Balance);
        } // end checking balance test

        [Fact]
        public void bank_test_for_deposit_passing()
        {
            // arrange
            Program.Balance = 2000;
            decimal deposit = 500;

            // act
            decimal result = Program.Deposit(deposit);

            // assert
            Assert.Equal(2500, result);
        } // end checking deposit test


    }
}
