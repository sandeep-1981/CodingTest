using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing;

namespace UnitTestProject1
{
    [TestClass]
    public class OrderProcessing
    {
        ConfirmationType EnumType;


        
        [TestMethod]       
            private void CallFactory()
            {
                // Abstract Factory Call

                IConfirmationOrder ConfirmationService;
                ConfirmationFactory objConfirmationFactory = new ConfirmationFactory();
                ConfirmationService = objConfirmationFactory.GetConfirmationType(EnumType);
                Assert.IsTrue(EnumType.Equals(1) || EnumType.Equals(2) ||  EnumType.Equals(3) || EnumType.Equals(4) || EnumType.Equals(5));
        }
        
    }
}
