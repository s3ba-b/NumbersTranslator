using System;
using NUnit.Framework;

namespace NumbersTranslator.Tests
{
    [TestFixture]
    public class NumbersTranslatorTests
    {
        [Test]
        public void Translator_TranslationFromIntToString_ReturnProperString() { // nazwa testu
            var numTranslator = new NumbersTranslator();
            string translatedNumber = numTranslator.Translate(4); // param wejsciowe metody
            Assert.AreEqual("cztery", translatedNumber); // wartosc oczekiwana
        }
    }
}
