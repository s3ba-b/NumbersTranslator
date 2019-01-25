using System;
using NUnit.Framework;

namespace NumbersTranslator.Tests
{
    [TestFixture]
    public class NumbersTranslatorTests
    {
        [Test]
        public void Translator_TranslationFromIntToString_ReturnProperString1()
        {
            var numTranslator = new NumbersTranslator();
            string translatedNumber = numTranslator.Translate(457); // param wejsciowe metody
            Assert.AreEqual("czterysta pięćdziesiąt siedem", translatedNumber); // wartosc oczekiwana
        }
        [Test]
        public void Translator_TranslationFromIntToString_ReturnProperString2()
        {
            var numTranslator = new NumbersTranslator();
            string translatedNumber = numTranslator.Translate(1000); // param wejsciowe metody
            Assert.AreEqual("Program obecnie obsługuje liczby do 999.", translatedNumber); // wartosc oczekiwana
        }
        [Test]
        public void Translator_TranslationFromIntToString_ReturnProperString3()
        {
            var numTranslator = new NumbersTranslator();
            string translatedNumber = numTranslator.Translate(100); // param wejsciowe metody
            Assert.AreEqual("sto", translatedNumber); // wartosc oczekiwana
        }
        [Test]
        public void Translator_TranslationFromIntToString_ReturnProperString4()
        {
            var numTranslator = new NumbersTranslator();
            string translatedNumber = numTranslator.Translate(228); // param wejsciowe metody
            Assert.AreEqual("dwieście dwadzieścia osiem", translatedNumber); // wartosc oczekiwana
        }
    }
}