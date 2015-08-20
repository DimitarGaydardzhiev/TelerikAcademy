namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void HandShouldReturnToStringCorectly()
        {
            var ace = new Card(CardFace.Ace, CardSuit.Clubs);
            var eight = new Card(CardFace.Eight, CardSuit.Clubs);
            var five = new Card(CardFace.Five, CardSuit.Clubs);
            var jack = new Card(CardFace.Jack, CardSuit.Clubs);

            var listOfCards = new List<ICard>();

            listOfCards.Add(ace);
            listOfCards.Add(eight);
            listOfCards.Add(five);
            listOfCards.Add(jack);

            var hand = new Hand(listOfCards);
            var expecedValue = "Ace of Clubs, Eight of Clubs, Five of Clubs, Jack of Clubs";

            Assert.AreEqual(expecedValue, hand.ToString());
        }
    }
}
