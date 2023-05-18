using NUnit.Framework;

namespace GroceryCheckoutApp.nUnitTests
{
    public class CheckoutAppTests
    {

        private CheckoutApp _checkoutApp { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _checkoutApp = new CheckoutApp();
        }

        [Test]
        public void Scan_Test()
        {

            //Assign
            char sku = 'A';

            //Act
            _checkoutApp.Scan(sku);


            //Assert
            Assert.IsNotNull("B");
        }

        [Test]
        public void Calculate_Total_Test()
        {

            //Assign
            _checkoutApp.Scan('A');
            _checkoutApp.Scan('B');
            _checkoutApp.Scan('C');
            _checkoutApp.Scan('D');
            _checkoutApp.Scan('A');

            //Act
            var total = _checkoutApp.Total();


            //Assert
            Assert.AreEqual(165, total);
        }

        [Test]
        public void Calculate_Total_Test_After_Discout()
        {

            //Assign
            _checkoutApp.Scan('A');
            _checkoutApp.Scan('B');
            _checkoutApp.Scan('C');
            _checkoutApp.Scan('D');
            _checkoutApp.Scan('X');

            //Act
            var total = _checkoutApp.Total();


            //Assert
            Assert.AreEqual(57, total);
        }

    }
}