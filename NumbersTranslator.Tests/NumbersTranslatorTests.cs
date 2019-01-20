using System;
using NUnit.Framework;

namespace NumbersTranslator.Tests
{
    [TestFixture]
    public class NumbersTranslatorTests
    {
        [Test]
        public void Translator_TranslationFromIntToString_ReturnProperString()
        {
            var numTranslator = new NumbersTranslator();
            string translatedNumber = numTranslator.Translate(457); // param wejsciowe metody
            Assert.AreEqual("czterysta pięćdziesiąt siedem", translatedNumber); // wartosc oczekiwana
        }
    }
}