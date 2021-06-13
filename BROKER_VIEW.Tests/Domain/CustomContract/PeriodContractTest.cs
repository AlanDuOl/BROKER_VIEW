using System;
using BROKER_VIEW.Domain.CustomContracts;
using Xunit;
using System.Linq;

namespace BROKER_VIEW.Tests
{
    public class PeriodContractTest
    {
        public PeriodContract contract { get; set; }
        public PeriodContractTest()
        {
            contract = new PeriodContract();
        }

        [Fact]
        public void ExpectedLength()
        {
            // arrange
            string inputValue = "0";
            int length = 2;
            string expectedPropName = "Month.Value";
            string expectedErrorMessage = $"Comprimento inválido: {inputValue.Length}";
            // act
            contract.ExpectedLength(expectedPropName, inputValue, length);
            // assert
            Assert.Equal(1, contract.Notifications.Count);
            Assert.Equal(expectedPropName, contract.Notifications.ToList()[0].Key);
            Assert.Equal(expectedErrorMessage, contract.Notifications.ToList()[0].Message);
        }
    }
}
