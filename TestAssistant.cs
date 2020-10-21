using AssistantVocal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssistantVocalTest
{
    [TestClass]
    public class TestAssistant
    {
        [TestMethod]
        
        public Assistant Heure(
            int heure,
            int minute)
                => new Assistant(heure, minute);

        [TestMethod]
        public void MinuteEgalesA45()
        {
            var test = new Assistant(12, 45);

            Assert.AreEqual(12, test.Heure);
            Assert.AreEqual(45, test.Minute);
        }
        [TestMethod]
        public void MinuteEgalesA15()
        {
            var test = new Assistant(12, 15);

            Assert.AreEqual(12, test.Heure);
            Assert.AreEqual(15, test.Minute);
        }
        [TestMethod]

        public void MidiPile()
        {
            var test = new Assistant(12, 00);

            Assert.AreEqual(12, test.Heure);
            Assert.AreEqual(00, test.Minute);
        }
        [TestMethod]
        public void ACinqMinutesPres()
        {
            var test = new Assistant(12, 57);

            Assert.AreEqual(12, test.Heure);
            Assert.AreEqual(57, test.Minute);
        }
        [TestMethod]
        public void EtDemi()
        {
            var test = new Assistant(12, 30);

            Assert.AreEqual(12, test.Heure);
            Assert.AreEqual(30, test.Heure);
        }
    }
}
