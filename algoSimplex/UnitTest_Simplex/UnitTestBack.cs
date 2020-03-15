using Microsoft.VisualStudio.TestTools.UnitTesting;
using algoSimplex;
using System.Collections.Generic;

namespace UnitTest_Simplex
{
    [TestClass]
    public class UnitTestBack
    {
        [TestMethod]
        public void TestCalculZ()
        {
            //Preparation
            int[] listCP = { 0, 0, 0 };
            int[] listQuantite = { 1400, 1500, 1600 };

            //Appel methode
            double value = Back.calculZ(listCP,listQuantite);

            //Resultat
            double testValue = 0.0;

            //Test
            Assert.IsTrue(value == testValue, "C'est vrai");
        }

        [TestMethod]
        public void TestCalculZj()
        {
            //Preparation
            int row = 2;
            int column = 2;
            int[] listCP = { 0, 1 };
            int[,] listContrainte = { { 1, 2 }, { 2, 3 } };

            //Appel methode
            List<double> valueZj = Back.calculZj(listCP, listContrainte, row, column);

            //Resultat
            List<double> testValue = new List<double> { 0, 5 };

            //Test
            Assert.AreEqual(valueZj == testValue, "Ok");
        }
    }
}
