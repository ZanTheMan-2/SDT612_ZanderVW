using BobileStoreApp;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void MobileCode_NegativeValue_ShouldNotBeAdded()
        {
            // Arrange
            var form = new Form1();
            form.SetPhoneInput("-123", "TestMake", "10"); // Negative mobile code
            // Act
            form.AddPhoneFromInput();
            // Assert
            Assert.IsFalse(form.phones.Any(p => p.MobileCode == -123), "Negative mobile code should not be added.");
        }
        [TestMethod]    
        public void MobileCode_ValidValue_ShouldBeAdded()
        {
            // Arrange
            var form = new Form1();
            form.SetPhoneInput("123", "TestMake", "10"); // Valid mobile code
            // Act
            form.AddPhoneFromInput();
            // Assert
            Assert.IsTrue(form.phones.Any(p => p.MobileCode == 123), "Valid mobile code should be added.");
        }
        [TestMethod]
        public void Quantity_NegativeValue_ShouldNotBeAdded()
        {
            // Arrange
            var form = new Form1();
            form.SetPhoneInput("123", "TestMake", "-10"); // Negative quantity
            // Act
            form.AddPhoneFromInput();
            // Assert
            Assert.IsFalse(form.phones.Any(p => p.quantity == -10), "Negative quantity should not be added.");
        }
        [TestMethod]
        public void Quantity_ValidValue_ShouldBeAdded()
        {
            // Arrange
            var form = new Form1();
            form.SetPhoneInput("123", "TestMake", "10"); // Valid quantity
            // Act
            form.AddPhoneFromInput();
            // Assert
            Assert.IsTrue(form.phones.Any(p => p.quantity == 10), "Valid quantity should be added.");
        } [TestMethod]
        public void Make_ValidValue_ShouldBeAdded()
        {
            // Arrange
            var form = new Form1();
            form.SetPhoneInput("123", "TestMake", "10"); // Valid make
            // Act
            form.AddPhoneFromInput();
            // Assert
            Assert.IsTrue(form.phones.Any(p => p.make == "TestMake"), "Valid make should be added.");
        }
    }
}
