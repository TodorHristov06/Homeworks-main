using ATMapp.Controller;
using ATMapp.Model;
using ATMapp.View;

namespace ATMtest
{
    public class Tests
    {
        private ATMcontroller ATMcontrollerTest;
        private ATMmodel ATMmodelTest;

        [SetUp]
        public void Setup()
        {
            ATMmodelTest = new ATMmodel();
            ATMcontrollerTest = new ATMcontroller();
        }

        //model
        [Test]
        public void TestBalanceAfterDeposit()
        {
            // Arrange
            double initialBalance = ATMmodelTest.Balance;
            double depositAmount = 100;

            // Act
            ATMmodelTest.Deposit(depositAmount);

            // Assert
            double finalBalance = ATMmodelTest.Balance;
            Assert.AreEqual(initialBalance + depositAmount, finalBalance);
        }

        [Test]
        public void TestBalanceAfterWithdraw()
        {
            // Arrange
            double initialBalance = ATMmodelTest.Balance;
            double withdrawAmount = 50;

            // Act
            bool result = ATMmodelTest.Withdraw(withdrawAmount);

            // Assert
            double finalBalance = ATMmodelTest.Balance;
            if (result)
            {
                Assert.GreaterOrEqual(finalBalance, 0);
            }
            else
            {
                Assert.AreEqual(initialBalance, finalBalance);
            }
        }
        [Test]
        public void TestBalanceNotNegativeAfterDeposit()
        {
            // Arrange
            double initialBalance = ATMmodelTest.Balance;
            double depositAmount = -50;

            // Act
            ATMmodelTest.Deposit(depositAmount);

            // Assert
            double finalBalance = ATMmodelTest.Balance;
            Assert.AreEqual(initialBalance, finalBalance);
        }

        [Test]
        public void TestBalanceNotNegativeAfterMultipleDeposits()
        {
            // Arrange
            double initialBalance = ATMmodelTest.Balance;
            double depositAmount1 = 100;
            double depositAmount2 = -50;

            // Act
            ATMmodelTest.Deposit(depositAmount1);
            ATMmodelTest.Deposit(depositAmount2);

            // Assert
            double finalBalance = ATMmodelTest.Balance;
            Assert.AreEqual(initialBalance + depositAmount1, finalBalance);
        }
    }
}