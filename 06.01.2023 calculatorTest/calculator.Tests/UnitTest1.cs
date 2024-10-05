namespace calculator.Tests
{
    public class Tests
    {
        //Addition

        [Test]
        public void TestAdditionOfPositiveNumbers()
        {
            double a = 5;
            double b = 10.3;

            double result = Arithmetics.Add(a, b);

            Assert.AreEqual(15.3, result);
        }

        [Test]
        public void TestAdditionOfNegativeNumbers()
        {
            double a = -5;
            double b = -10.3;

            double result = Arithmetics.Add(a, b);

            Assert.AreEqual(-15.3, result);
        }

        [Test]
        public void TestAdditionOfLongNumbers()
        {
            double a = int.MaxValue;
            double b = int.MaxValue;

            double result = Arithmetics.Add(a, b);

            Assert.AreEqual(4294967294, result);
        }

        [Test]
        public void TestAdditionOfPositiveAndNegativeNumbers()
        {
            double a = -1;
            double b = 2;

            double result = Arithmetics.Add(a, b);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestAdditionOfZeroAndNegativeNumbers()
        {
            double a = -1;
            double b = 0;

            double result = Arithmetics.Add(a, b);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void TestAdditionOfOppositeNumbers()
        {
            double a = -5;
            double b = 5;

            double result = Arithmetics.Add(a, b);

            Assert.AreEqual(0, result);
        }

        //Subtraction

        [Test]

        public void TestSubtractionOfTwoPossitiveNumbers()
        {
            double a = 5;
            double b = 6;

            double result = Arithmetics.Subtract(a, b);

            Assert.AreEqual(-1, result);
        }

        [Test]

        public void TestSubtractionOfTwoNegativeNumbers()
        {
            double a = -5;
            double b = -6;

            double result = Arithmetics.Subtract(a, b);

            Assert.AreEqual(1, result);
        }

        [Test]

        public void TestSubtractionOfZeroAndPossitiveNumbers()
        {
            double a = 0;
            double b = 6;

            double result = Arithmetics.Subtract(a, b);

            Assert.AreEqual(-6, result);
        }

        [Test]

        public void TestSubtractionOfZeroAndNegativeNumbers()
        {
            double a = 0;
            double b = -6;

            double result = Arithmetics.Subtract(a, b);

            Assert.AreEqual(6, result);
        }

        [Test]

        public void TestSubtractionOfTwoZeros()
        {
            double a = 0;
            double b = 0;

            double result = Arithmetics.Subtract(a, b);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestSubtractionOfLongNumbers()
        {
            double a = int.MinValue;
            double b = int.MinValue;

            double result = Arithmetics.Subtract(a, b);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestSubtractionOfOppositeNumbers()
        {
            double a = 4;
            double b = -6;

            double result = Arithmetics.Subtract(a, b);

            Assert.AreEqual(10, result);
        }

        //Multiplication

        [Test]
        public void TestMultiplicationOfPositiveNumbers()
        {
            double a = 2;
            double b = 2;

            double result = Arithmetics.Multiply(a, b);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void TestMultiplicationOfNegativeNumbers()
        {
            double a = -2;
            double b = -2;

            double result = Arithmetics.Multiply(a, b);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void TestMultiplicationOfPositiveAndNegativeNumbers()
        {
            double a = 2;
            double b = -2;

            double result = Arithmetics.Multiply(a, b);

            Assert.AreEqual(-4, result);
        }

        [Test]
        public void TestMultiplicationOfZeroAndNegativeNumbers()
        {
            double a = 0;
            double b = -2;

            double result = Arithmetics.Multiply(a, b);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMultiplicationOfZeroAndPositiveNumbers()
        {
            double a = 0;
            double b = 2;

            double result = Arithmetics.Multiply(a, b);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMultiplicationOfTwoZeros()
        {
            double a = 0;
            double b = 0;

            double result = Arithmetics.Multiply(a, b);

            Assert.AreEqual(0, result);
        }

        //Dividation

        [Test]
        public void TestDividationOfPositiveNumbers()
        {
            double a = 4;
            double b = 2;

            double result = Arithmetics.Divide(a, b);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestDividationOfSmallerAndBiggerNumbers()
        {
            double a = 2;
            double b = 4;

            double result = Arithmetics.Divide(a, b);

            Assert.AreEqual(0.5, result);
        }

        [Test]
        public void TestDividationOfNegativeNumbers()
        {
            double a = -4;
            double b = -2;

            double result = Arithmetics.Divide(a, b);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestDividationOfBigNumbers()
        {
            double a = 1233456;
            double b = 8;

            double result = Arithmetics.Divide(a, b);

            Assert.AreEqual(154182, result);
        }

        //Power

        [Test]
        public void TestPowerOfPossitiveNumbers()
        {
            double a = 2;
            double b = 4;

            double result = Arithmetics.Power(a, b);

            Assert.AreEqual(16, result);
        }

        [Test]
        public void TestPowerOfNegativeEvenNumbers()
        {
            double a = -2;
            double b = 4;

            double result = Arithmetics.Power(a, b);

            Assert.AreEqual(16, result);
        }

        [Test]
        public void TestPowerOfNegativeOddNumbers()
        {
            double a = -2;
            double b = 3;

            double result = Arithmetics.Power(a, b);

            Assert.AreEqual(-8, result);
        }

        [Test]
        public void TestPowerOfZero()
        {
            double a = 2;
            double b = 0;

            double result = Arithmetics.Power(a, b);

            Assert.AreEqual(1, result);
        }
    }
}