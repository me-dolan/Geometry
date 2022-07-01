namespace GeometryTest
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void CirclNegativRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

        [Test]
        public void CirclSqrCalculationTest()
        {
            Circle circle = new Circle(3);

            var circleSquare = circle.Square;

            Assert.That(circleSquare, Is.EqualTo(28.274333882308138));
        }
    }
}
