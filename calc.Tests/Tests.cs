using NUnit.Framework;

namespace CalcWithBugs.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private CalcWithBugs _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new CalcWithBugs();
        }

        [Test]
        public void Cos_TwoNumbers_ReturnsCos()
        {
            var result = _calculator.Cos(new[] { " ", "1" });
            Assert.That(result, Is.EqualTo(0.5403023058681398));
        }

        [Test]
        public void Sin_TwoNumbers_ReturnsSin()
        {
            var result = _calculator.Cos(new[] { " ", "1" });
            Assert.That(result, Is.EqualTo(0.8414709848078965));
        }

        [Test]
        public void Tg_TwoNumbers_ReturnsTg()
        {
            var result = _calculator.Tg(new[] { " ", "1" });
            Assert.That(result, Is.EqualTo(1.5574077246549023));
        }

        [Test]
        public void Ctg_TwoNumbers_ReturnsCtg()
        {
            var result = _calculator.Tg(new[] { " ", "1" });
            Assert.That(result, Is.EqualTo(0.6420926159343306));
        }


        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            var result = _calculator.Sum(new[] { "2", "3" });
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Minus_TwoNumbers_ReturnsMin()
        {
            var result = _calculator.Sum(new[] { "3", "1" });
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Div_TwoNumbers_ReturnsDiv()
        {
            var result = _calculator.Div(new[] { "6", "2" });
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Mult_TwoNumbers_ReturnsMult()
        {
            var result = _calculator.Mult(new[] { "3", "2" });
            Assert.That (result, Is.EqualTo(6));
        }

        [Test]
        public void Cos_EmptyInput_ThrowsException()
        {
            Assert.Throws<FormatException>(() => _calculator.Cos(new[] { "", "" }));
        }

        [Test]
        public void Sin_InvalidInput_ThrowsException()
        {
            Assert.Throws<FormatException>(() => _calculator.Sin(new[] { "", "abc" }));
        }

        [Test]
        public void Tg_EmptyInput_ThrowsException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => _calculator.Tg(new[] { "" }));
        }

        [Test]
        public void Calculator_EmptyString_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Calculator(""));
        }

        [Test]
        public void Calculator_SpaceString_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Calculator("   "));
        }

        [Test]
        public void Calculator_InvalidOperation_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => _calculator.Calculator("5^3"));
        }

        [Test]
        public void Sum_EmptyInput_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() => _calculator.Sum(new[] { "", "3" }));
        }

        [Test]
        public void Sum_InvalidNumberFormat_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() => _calculator.Sum(new[] { "abc", "3" }));
        }

        [Test]
        public void Div_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() =>
                _calculator.Div(new[] { "5", "0" }));
        }
    }
}