using System;
using Lab02-ATM;
using Xunit;

namespace XUnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsBalance()
        {
            Assert.Equal(Lab02-ATM.Balance, Lab02-ATM.ViewBalance());
        }

        [Fact]
        public void ReturnsWithdrawalAmount()
        {
            Assert.Equal(20, Lab02-ATM.Withdraw(20));
        }

        [Fact]
        public void ReturnsBalanceAmount()
        {
            Assert.Equal(20, Lab02-ATM.Deposit(20));
        }
    }
}
