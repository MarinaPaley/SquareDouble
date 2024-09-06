using Domain;

namespace Tests
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void Ctor_ValidData_Success()
        {
            Assert.DoesNotThrow(() => { _ = new Square(1); });
        }

        [Test]
        public void Ctor_NegativSide_ExpectedException()
        {
            Assert.Throws<ArgumentException>(() => { _ = new Square(-1); });
        }

        [TestCase(1, 1, true)]
        [TestCase(1, 2, false)]
        public void Equals_ValidData_Success(double a, double b, bool result)
        {
            // arrange
            var square1 = new Square(a);
            var square2 = new Square(b);

            //act & assert
            Assert.That(result, Is.EqualTo(square2.Equals(square1)));
        }

        [TestCase(2, 8)]
        [TestCase(3, 12)]
        public void GetPerimetr_ValidData_Success(double side, double perimetr)
        {
            // arrange
            var square = new Square(side);
            // act & assert
            Assert.That(Math.Abs(square.GetPerimetr() - perimetr), Is.LessThanOrEqualTo(Double.Epsilon));
        }

        [TestCase(2, 4)]
        [TestCase(3, 9)]
        public void GetArea_ValidData_Success(double side, double area)
        {
            // arrange
            var square = new Square(side);
            // act & assert
            Assert.That(Math.Abs(square.GetArea() - area), Is.LessThanOrEqualTo(Double.Epsilon));
        }

}
}
