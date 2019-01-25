using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;


namespace CalculatorTest
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input4point2and2point3_Returns6point5()
            {
                //Arrange
                double number1 = 4.2;
                double number2 = 2.3;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }



            [Test]
            public void GetAddition_Input5point1and3point6_Returns9point7()
            {
                //Arrange
                double number1 = 5.1;
                double number2 = 3.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input2point2and4point3_Returns6point5()
            {
                //Arrange
                double number1 = 2.2;
                double number2 = 4.3;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            [Test]
            public void GetSubtraction_Input8point1and4point0_Returns4point1()
            {
                //Arrange
                double number1 = 8.1;
                double number2 = 4.0;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            [Test]
            public void GetSubtraction_Input6point2and3point2_Returns3point0()
            {
                //Arrange
                double number1 = 6.2;
                double number2 = 3.2;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            [Test]
            public void GetSubtraction_Input5point2and3point2_Returns2point0()
            {
                //Arrange
                double number1 = 5.2;
                double number2 = 3.2;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            [Test]
            public void GetMultiplication_Input3point5and7point2_Returns25point2()
            {
                //Arrange
                double number1 = 3.5;
                double number2 = 7.2;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            [Test]
            public void GetMultiplication_Input3point2and2point4_Returns7point68()
            {
                //Arrange
                double number1 = 3.2;
                double number2 = 2.4;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            [Test]
            public void GetMultiplication_Input8point1and3point2_Returns25point92()
            {
                //Arrange
                double number1 = 8.1;
                double number2 = 3.2;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            [Test]
            public void GetDivision_Input6and2_Returns3()
            {
                //Arrange
                double number1 = 6;
                double number2 = 2;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            [Test]
            public void GetDivision_Input12and6_Returns2()
            {
                //Arrange
                double number1 = 12;
                double number2 = 2;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            [Test]
            public void GetDivision_Input9and3_Returns3()
            {
                //Arrange
                double number1 = 9;
                double number2 = 3;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
        }
    }
}

