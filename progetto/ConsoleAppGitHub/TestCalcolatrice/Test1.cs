namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void testSomma()
        {
            // Arrange
            CalcolatriceGit.Calcolatrice calcolatrice = new CalcolatriceGit.Calcolatrice();
            double x = 5.0;
            double y = 3.0;
            int expected = 8;
            // Act2
            double result = calcolatrice.Somma(x, y);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSommaZero()
        {
            // Arrange
            CalcolatriceGit.Calcolatrice calcolatrice = new CalcolatriceGit.Calcolatrice();
            double x = 0.0;
            double y = 0.0;
            int expected = 0;
            // Act
            double result = calcolatrice.Somma(x, y);
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
