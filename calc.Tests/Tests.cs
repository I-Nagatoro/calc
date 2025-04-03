using NUnit.Framework;
using System;

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
        public void FloatNumSum()
        {
            var result = _calculator.Sum(new[] { "2.0", "3" });
            Assert.That(result, Is.EqualTo(2));
        }
        
        [Test]
        public void FloatNumMin()
        {
            var result = _calculator.Min(new[] { "2.0", "3" });
            Assert.That(result, Is.EqualTo(-1));
        }
         
        [Test]
        public void FloatNumMult()
        {
            var result = _calculator.Mult(new[] { "2.0", "3" });
            Assert.That(result, Is.EqualTo(6));
        }
                
        [Test]
        public void FloatNumDiv()
        {
            var result = _calculator.Div(new[] { "4.0", "2" });
            Assert.That(result, Is.EqualTo(2));
        }
                
        [Test]
        public void FloatNumCos()
        {
            var result = _calculator.Cos(new[] { "2.0" });
            Assert.That(result, Is.EqualTo("−0,41614683654"));
        }
                
        [Test]
        public void FloatNumSin()
        {
            var result = _calculator.Sin(new[] { "1.0" });
            Assert.That(result, Is.EqualTo("0,8414709848"));
        }
                
        [Test]
        public void FloatNumTg()
        {
            var result = _calculator.Tg(new[] { "1.0" });
            Assert.That(result, Is.EqualTo("1,55740772465"));
        }
                
        [Test]
        public void FloatNumCtg()
        {
            var result = _calculator.Ctg(new[] { "1.0" });
            Assert.That(result, Is.EqualTo("0.6420926159343306"));
        }
                
        [Test]
        public void NegativeNumberSum()
        {
            var result = _calculator.Sum(new[] { "-1", "2" });
            Assert.That(result, Is.EqualTo("1"));
        }
        
                
        [Test]
        public void NegativeNumberMin()
        {
            var result = _calculator.Min(new[] { "-1", "2" });
            Assert.That(result, Is.EqualTo("-3"));
        }
        
                
        [Test]
        public void NegativeNumberMult()
        {
            var result = _calculator.Sum(new[] { "-1", "2" });
            Assert.That(result, Is.EqualTo("-2"));
        }
        
        [Test]
        public void NegativeNumberDiv()
        {
            var result = _calculator.Div(new[] { "-1", "2" });
            Assert.That(result, Is.EqualTo("-0.5"));
        }
        [Test]
        public void Sum_TwoNumbers_ReturnsSum()
        {
            var result = _calculator.Sum(new[] { "2", "3" });
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Min_TwoNumbers_ReturnsDifference()
        {
            var result = _calculator.Min(new[] { "3", "1" });
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Mult_TwoNumbers_ReturnsProduct()
        {
            var result = _calculator.Mult(new[] { "3", "2" });
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Div_TwoNumbers_ReturnsQuotient()
        {
            var result = _calculator.Div(new[] { "6", "2" });
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Cos_ValidInput_ReturnsCosine()
        {
            var result = _calculator.Cos(new[] { "", "1" });
            Assert.That(result, Is.EqualTo(Math.Cos(1)).Within(0.0001));
        }

        [Test]
        public void Sin_ValidInput_ReturnsSine()
        {
            var result = _calculator.Sin(new[] { "", "1" });
            Assert.That(result, Is.EqualTo(Math.Sin(1)).Within(0.0001));
        }

        [Test]
        public void Tg_ValidInput_ReturnsTangent()
        {
            var result = _calculator.Tg(new[] { "", "1" });
            Assert.That(result, Is.EqualTo(Math.Tan(1)).Within(0.0001));
        }

        [Test]
        public void Ctg_ValidInput_ReturnsCotangent()
        {
            var result = _calculator.Ctg(new[] { "", "1" });
            Assert.That(result, Is.EqualTo(1/Math.Tan(1)).Within(0.0001));
        }

        [Test]
        public void Calculator_EmptyString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Calculator(""));
        }

        [Test]
        public void Calculator_WhitespaceString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Calculator("   "));
        }

        [Test]
        public void Calculator_InvalidOperation_ThrowsInvalidOperationException()
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
            Assert.Throws<DivideByZeroException>(() => _calculator.Div(new[] { "5", "0" }));
        }

        [Test]
        public void Cos_EmptyInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Cos(new[] { "", "" }));
        }

        [Test]
        public void Sin_InvalidInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Sin(new[] { "", "abc" }));
        }
        
        [Test]
        public void Sin_InvalidInput2_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Sin(new[] { "abc", "" }));
        }

        [Test]
        public void Ctg_UndefinedValue_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Ctg(new[] { "", (Math.PI/2).ToString() }));
        }

        [Test]
        public void Calculator_Addition_CallsSumMethod()
        {
            Assert.That(_calculator.Sum(new[] { "2", "3" }), Is.EqualTo(5));
        }

        [Test]
        public void Calculator_Subtraction_CallsMinMethod()
        {
            Assert.That(_calculator.Min(new[] { "2", "3" }), Is.EqualTo(-2));
        }

        [Test]
        public void Calculator_Multiplication_CallsMultMethod()
        {
            Assert.That(_calculator.Mult(new[] { "2", "3" }), Is.EqualTo(6));
        }

        [Test]
        public void Calculator_Division_CallsDivMethod()
        {
            Assert.That(_calculator.Div(new[] { "2", "3" }), Is.EqualTo(6));
        }

        [Test]
        public void Calculator_Cosine_CallsCosMethod()
        {
            Assert.That(_calculator.Cos(new[] { "2", "3" }), Is.EqualTo(6));
        }

        [Test]
        public void Calculator_Sine_CallsSinMethod()
        {
            Assert.That(_calculator.Sin(new[] { "2", "3" }), Is.EqualTo(6));
        }

        [Test]
        public void Calculator_Tangent_CallsTgMethod()
        {
            Assert.That(_calculator.Tg(new[] { "2", "3" }), Is.EqualTo(6));
        }

        [Test]
        public void Calculator_Cotangent_CallsCtgMethod()
        {
            Assert.That(_calculator.Ctg(new[] { "2", "3" }), Is.EqualTo(6));
        }
    }
}