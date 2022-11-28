using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTask;

namespace MathTaskTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RectangleArea_3and5_15retyrned()
        {
            // исходные данные 
            int a = 3;
            int b = 5;
            int expected = 15;

            //получаем значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}
