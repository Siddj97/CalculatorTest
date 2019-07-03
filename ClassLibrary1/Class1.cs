using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp23;
namespace ClassLibrary1
{
  
        [TestFixture]
        public class Class1
        {



            [Test]
            public void GetAddition_Input8point7and1point8_Returns10point5()
            {

                //Arrange
                double number1 = 8.7;
                double number2 = 1.8;

                double expectedResult = number1 + number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetAddition_Input10point5and12point3_Returns22point8()
            {

                //Arrange
                double number1 = 10.5;
                double number2 = 12.3;

                double expectedResult = number1 + number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input7point7and6point7_Returns14point4()
            {

                //Arrange
                double number1 = 7.7;
                double number2 = 6.7;

                double expectedResult = number1 + number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetSubtraction_Input17point8and13point8_Returns4point0()
            {

                //Arrange
                double number1 = 17.8;
                double number2 = 13.8;

                double expectedResult = number1 - number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetSubtraction();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetSubtraction_Input22point5and20point5_Returns2point0()
            {

                //Arrange
                double number1 = 22.5;
                double number2 = 20.5;

                double expectedResult = number1 - number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetSubtraction();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetSubtraction_Input8point8and8point8_Returns0point0()
            {

                //Arrange
                double number1 = 8.8;
                double number2 = 8.8;

                double expectedResult = number1 - number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetSubtraction();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetMultiplication_Input2point8and7point5_Returns21point0()
            {

                //Arrange
                double number1 = 2.8;
                double number2 = 7.5;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetMultiplication();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }


            [Test]
            public void GetMultiplication_Input6oint9and9point6_Returns66point24()
            {

                //Arrange
                double number1 = 6.9;
                double number2 = 9.6;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetMultiplication();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetMultiplication_Input7point2and2point5_Returns18point0()
            {

                //Arrange
                double number1 = 7.2;
                double number2 = 2.5;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetMultiplication();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetDivision_Input10point0and2point0_Returns5point0()
            {

                //Arrange
                double number1 = 10.0;
                double number2 = 2.0;

                double expectedResult = number1 / number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetDivision();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetDivision_Input10point5and2point5_Returns4point2()
            {

                //Arrange
                double number1 = 10.5;
                double number2 = 2.5;

                double expectedResult = number1 / number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetDivision();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetDivision_Input25point0and5point0_Returns5point0()
            {

                //Arrange
                double number1 = 25.0;
                double number2 = 5.0;

                double expectedResult = number1 / number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetDivision();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input6point0and2point0_Returns3point0()
            {

                //Arrange
                double number1 = 6.0;
                double number2 = 2.0;

                double expectedResult = number1 / number2;

                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetDivision();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
        public void GetDivision_Input15point0and3point0_Returns5point0()
        {

            //Arrange
            double number1 = 15.0;
            double number2 = 3.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
              Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input1point0and3point0_Returns0point3()
        {

            //Arrange
            double number1 = 1;
            double number2 = 3;

             double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input2point0and1point0_Returns2point0()
        {

            //Arrange
            double number1 = 2.0;
            double number2 = 1.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input9point0and3point0_Returns3point0()
        {

            //Arrange
            double number1 = 9.0;
            double number2 = 3.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




    }
}


