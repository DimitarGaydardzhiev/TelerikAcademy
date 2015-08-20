namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CardShouldBeCreatedCorectly()
        {
            var card = new Card(CardFace.Ace, CardSuit.Diamonds);
        }

        [TestMethod]
        public void CardShouldReturnToStringCorectly()
        {
            var card = new Card(CardFace.Ace, CardSuit.Diamonds);
            string expectedValue = "Ace of Diamonds";

            Assert.AreEqual(expectedValue, card.ToString());
        }
    }
}
