using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double BalanceInicial = 11.99;
            double MontoDebito = 4.55;
            double ValorEsperado = 7.44;
            BankAccount account = new BankAccount("Bryan", BalanceInicial);

            // Act
            account.Debit(MontoDebito);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(ValorEsperado, actual, 0.001, "Cuenta con debito incorrecto");
        }
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            double BalanceInicial = 12;
            double MontoCredito = 4;
            double ValorEsperado = 16;
            BankAccount account = new BankAccount("Bryan", BalanceInicial);

            account.Credit(MontoCredito);

            double actual = account.Balance;
            Assert.AreEqual(ValorEsperado, actual, 0.001, "Cuenta con credito incorrecto");
        }
    }
}

