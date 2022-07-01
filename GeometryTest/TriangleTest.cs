namespace GeometryTest
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void TriangleNegativSidesTest() // отрицательные стороны треугольника
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
        }

        [Test]
        public void TriangleSqrCalculateTest() // площадь треугольника
        {
            Triangle triangle = new Triangle(3,4,5);

            var triangleSqr = triangle.Square;

            Assert.That(triangleSqr, Is.EqualTo(6));
        }

        [Test]
        public void TriangleRightAngleTest() // прямоугольный
        {
            Triangle triangle = new Triangle(3,4,5);

            var isTriangleRightAngle = triangle.IsRightAnglde;

            Assert.That(isTriangleRightAngle, Is.EqualTo(true));
        }

        [Test]
        public void NonTriangleRightAngleTest() //не прямоугольный треугольник
        {
            var triangle = new Triangle(7,4,5);

            var isTriangleRightAngle = triangle.IsRightAnglde;

            Assert.That(isTriangleRightAngle, Is.EqualTo(false));
        }
    }
}