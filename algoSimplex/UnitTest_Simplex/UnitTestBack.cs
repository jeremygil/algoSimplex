using Microsoft.VisualStudio.TestTools.UnitTesting;
using algoSimplex;
using System.Collections.Generic;
using log4net;

namespace UnitTest_Simplex
{
    [TestClass]
    public class UnitTestBack
    {
        private static ILog LOGGER = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void TestCalculZ()
        {
            //Preparation
            int[] listCP = { 0, 0, 0 };
            double[] listQuantite = { 1400, 1500, 1600 };

            //Appel methode
            double value = Back.calculZ(listCP,listQuantite);

            //Resultat
            double testValue = 0.0;

            //Affichage valeur
            LOGGER.Info("Valeur de Z : " + value);

            //Test
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void TestCalculZj()
        {
            //Preparation
            int row = 2;
            int column = 2;
            int[] listCP = { 0, 1 };
            double[,] listContrainte = { { 1, 2 }, { 2, 3 } };

            //Appel methode
            double[] valueZj = Back.calculZj(listCP, listContrainte, row, column);

            //Resultat
            double[] testValue = { 0, 5 };

            //Affichage valeur
            LOGGER.Info("Valeur de Zj : " + valueZj);

            //Test
            Assert.AreEqual(valueZj[0] , testValue[0]);
            Assert.AreEqual(valueZj[1] , testValue[1]);
        }

        [TestMethod]
        public void TestSoustractionCjZj()
        {
            //Preparation
            int[] listCj = { 100, 120 };
            double[] listZj = { 100, 120 };

            //Appel methode
            double[] valueCjZj = Back.calculSoustractionCjZj(listCj,listZj);

            //Resultat
            double[] testValue = { 0, 0 };

            //Affichage valeur
            LOGGER.Info("Valeur de CjZj : " + valueCjZj);

            //Test
            Assert.AreEqual(valueCjZj[0] , testValue[0]);
            Assert.AreEqual(valueCjZj[1] , testValue[1]);
        }

        [TestMethod]
        public void TestMinCjZj()
        {
            //Preparation
            double[] listCjZj = { 100, 120, -20 };

            //Appel methode
            int result = Back.minCjZj(listCjZj);

            //Resultat
            int testValuePlace = 2;

            //Affichage valeur
            LOGGER.Info("Min de CjZj : " + result);

            //Test
            Assert.AreEqual(result, testValuePlace);
        }

        [TestMethod]
        public void TestMaxCjZj()
        {
            //Preparation
            double[] listCjZj = { 100, 120, -20 };

            //Appel methode
            int result = Back.maxCjZj(listCjZj);

            //Resultat
            int testValuePlace = 1;

            //Affichage valeur
            LOGGER.Info("Max de CjZj : " + result);

            //Test
            Assert.AreEqual(result, testValuePlace);
        }

        [TestMethod]
        public void TestCalculRatio()
        {
            //Preparation
            double[] listQuantite = { 100, 120, 200 };
            double[,] listContrainte = { { 1, 2, 4 }, { 4, 5, 6 }, { 7, 8, 2 } };
            int valeurPlace = 2;

            //Appel methode
            double[] result = Back.calculRatio(listQuantite, listContrainte, valeurPlace);

            //Resultat
            double[] testValuePlace = { 25, 20, 100 };

            //Affichage valeur
            LOGGER.Info("Ratio : " + result);

            //Test
            Assert.AreEqual(result[0], testValuePlace[0]);
            Assert.AreEqual(result[1], testValuePlace[1]);
            Assert.AreEqual(result[2], testValuePlace[2]);
        }

        [TestMethod]
        public void TestMinRatio()
        {
            //Preparation
            double[] listRatio = { 100, 120, -20 };

            //Appel methode
            int result = Back.minRatio(listRatio);

            //Resultat
            int testValuePlace = 2;

            //Affichage valeur
            LOGGER.Info("Min de CjZj : " + result);

            //Test
            Assert.AreEqual(result, testValuePlace);
        }
    }
}
