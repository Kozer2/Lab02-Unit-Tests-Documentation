using Lab02_Unit_Tests_Documentation;
using System;
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

        [Fact(Skip = "Can't figure out how to test for exception")]
        public void bank_test_for_withdrawing_failing()
        {
            // arrange
            Program.Balance = 2000;
            decimal withDraw = 2001;

            // act
            decimal result = Program.Withdraw(withDraw);

            // assert
            /*Assert.Equal("ApplicationException", result.Message);*/
        } // end checking balance exception test

        [Fact(Skip = "Can't figure out how to test for exception")]
        public void bank_test_for_deposit_failing()
        {
            // arrange
            Program.Balance = 2000;
            decimal deposit = -1;

            // act
            decimal result = Program.Deposit(deposit);

            // assert
            /*Assert.Equal("ApplicationException", result.Message);*/
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
