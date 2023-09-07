using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1;

namespace lab1Tests
{
    [TestClass]
    public class Task2Tests
    {
        [TestMethod]
        public void TestRectangleArea()
        {
            task2.Rectangle rect = new task2.Rectangle(4, 5);
            Assert.AreEqual(rect.Area, 20);
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            task2.Rectangle rect = new task2.Rectangle(4, 5);
            Assert.AreEqual(rect.Perimeter, 18);
        }
    }

    [TestClass]
    public class Task3Tests
    {
        [TestMethod]
        public void TestTrianglePerimeter()
        {
            task3.Point p1 = new task3.Point(0, 0);
            task3.Point p2 = new task3.Point(1, 0);
            task3.Point p3 = new task3.Point(0, 1);

            task3.Figure triangle = new task3.Figure(p1, p2, p3);
            Assert.AreEqual(triangle.PerimeterCalculator(), 3.414213562373095);
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            task3.Point p1 = new task3.Point(0, 0);
            task3.Point p2 = new task3.Point(4, 0);
            task3.Point p3 = new task3.Point(4, 3);
            task3.Point p4 = new task3.Point(0, 3);

            task3.Figure rectangle = new task3.Figure(p1, p2, p3, p4);
            Assert.AreEqual(rectangle.PerimeterCalculator(), 14);
        }

        [TestMethod]
        public void TestPentagonPerimeter()
        {
            task3.Point p1 = new task3.Point(0, 0);
            task3.Point p2 = new task3.Point(4, 0);
            task3.Point p3 = new task3.Point(6, 2);
            task3.Point p4 = new task3.Point(4, 4);
            task3.Point p5 = new task3.Point(0, 4);

            task3.Figure pentagon = new task3.Figure(p1, p2, p3, p4, p5);
            Assert.AreEqual(pentagon.PerimeterCalculator(), 17.65685424949238); 
        }
    }
}
