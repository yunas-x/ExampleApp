using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example_App;

namespace ExampleAppTests
{
    [TestClass]
    public class ExampleClassTest
    {
        [TestMethod]
        [DataRow(null)]
        public void ToString_InputIsNull_ReturnEmptyString(string str)
        {
            //Arrange
            ExampleClass exampleClass = new ExampleClass(null);

            //Act
            string result = exampleClass.ToString();

            //Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        [DataRow("Input")]
        [DataRow("Put")]
        public void ToString_InputIsNotNull_ReturnString(string str)
        {
            //Arrange
            ExampleClass exampleClass = new ExampleClass(str);

            //Act
            string result = exampleClass.ToString();

            //Assert
            Assert.AreEqual(str, result);
        }
    }
}
