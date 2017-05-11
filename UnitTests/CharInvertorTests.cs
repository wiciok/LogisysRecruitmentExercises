using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;

namespace CharInvertorTests
{
    [TestClass]
    public class CharInvertorTests
    {
        [TestMethod]
        public void FirstLetterCapitalized()
        {
            //arrange
            CharInvertor charInvertor = new CharInvertor();

            string sourceString = "Logisys";
            string expectedString = "Sysigol";

            //act
            string result = charInvertor.CharInversion(sourceString);

            //assert
            Assert.AreEqual(expectedString, result);
        }

        [TestMethod]
        public void NonLetterChars()
        {
            //arrange
            CharInvertor charInvertor = new CharInvertor();

            string sourceString = "1235,";
            string expectedString = ",5321";

            //act
            string result = charInvertor.CharInversion(sourceString);

            //assert
            Assert.AreEqual(expectedString, result);
        }

        [TestMethod]
        public void CapitalLettersInsideString()
        {
            //arrange
            CharInvertor charInvertor = new CharInvertor();

            string sourceString = "TeSttEst";
            string expectedString = "Tsettset";

            //act
            string result = charInvertor.CharInversion(sourceString);

            //assert
            Assert.AreEqual(expectedString, result);
        }
    }
}
