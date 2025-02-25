using NUnit.Framework;
namespace HW03_16_6_1.Tests
{

    /// <summary>
    /// Класс тестов для калькулятора
    /// </summary>
    [TestFixture]
    public class CalculatorTests
    {
        /// <summary>
        /// Метод проверки корректного значения при сложении 2х чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        [TestCase(5, 5, 10)]
        [TestCase(-100, 100, 0)]
        [TestCase(65, 84, 149)]

        public void AdditionalCurrentValue(int a, int b, int c)
        {
            Calculator cl = new Calculator();
            Assert.That(cl.Additional(a, b), Is.EqualTo(c));
        }

        /// <summary>
        /// Метод проверки корректного значения при вычитании 2х чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        [TestCase(5, 5, 0)]
        [TestCase(0, 25, -25)]
        [TestCase(99, 1, 98)]

        public void SubtractionCurrentValue(int a, int b, int c)
        {
            Calculator cl = new Calculator();
            Assert.That(cl.Subtraction(a, b), Is.EqualTo(c));
        }

        /// <summary>
        /// Метод проверки корректного значени при умножении 2х чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        [TestCase(5, 5, 25)]
        [TestCase(10, 9, 90)]
        [TestCase(99, 9, 891)]

        public void MultiplyCurrentValue(int a, int b, int c)
        {
            Calculator cl = new Calculator();
            Assert.That(cl.Miltiplication(a, b), Is.EqualTo(c));
        }

        /// <summary>
        /// Метод проверки корректного занчения при умножении на 0
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        [TestCase(0, 5, 0)]
        [TestCase(10, 0, 0)]
        [TestCase(0, 0, 0)]

        public void MultiplyByZero(int a, int b, int c)
        {
            Calculator cl = new Calculator();
            Assert.That(cl.Miltiplication(a,b), Is.EqualTo(c));

        }

        /// <summary>
        /// Метод проверки корректного значения при делении
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        [TestCase(5, 5, 1)]
        [TestCase(10, 5, 2)]
        [TestCase(81, 9, 9)]

        public void DivideCurrentValue(int a, int b, int c)
        {
            Calculator cl = new Calculator();
            Assert.That(cl.Division(a, b), Is.EqualTo(c));
        }

        /// <summary>
        /// Метод проверки на исключение при делении на 0
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        [TestCase(-50,0)]
        [TestCase(60,0)]
        [TestCase(0,0)]
        public void DivideByZero(int a,int b)
        {
            Calculator cl = new Calculator();
            Assert.Throws<DivideByZeroException>(()=>cl.Division(a,b));
        }

    }
}
