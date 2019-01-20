using System;
using NUnit.Framework;

namespace NumbersTranslator.Tests
{
    [TestFixture]
    public class NumbersTranslatorTests
    {
        [Test]
        public void Translator_TranslationFromIntToString_ReturnProperString_Test1()
        {
            // nazwa testu
            var numTranslator = new NumbersTranslator();
            string translatedNumber = numTranslator.Translate(457); // param wejsciowe metody
            Assert.AreEqual("four hundred fifty seven", translatedNumber); // wartosc oczekiwana
<<<<<<< HEAD
<<<<<<< HEAD
        }
        [Test]
        public void Translator_TranslationFromIntToString_ReturnProperString_Test2()
        {
            var numTranslator = new NumbersTranslator();
            string translatedNumber = numTranslator.Translate(621); // param wejsciowe metody
            Assert.AreEqual("sześćset dwadzieścia jeden", translatedNumber); // wartosc oczekiwana
        }

        [Test]
        public void Translator_TranslationFromIntToString_ReturnProperString_Test3()
        {
            var numTranslator = new NumbersTranslator();
            string translatedNumber = numTranslator.Translate(30); // param wejsciowe metody
            Assert.AreEqual("trzydzieści", translatedNumber); // wartosc oczekiwana
=======
>>>>>>> parent of ec16c6e... new version
=======
>>>>>>> parent of ec16c6e... new version
        }
    }
}