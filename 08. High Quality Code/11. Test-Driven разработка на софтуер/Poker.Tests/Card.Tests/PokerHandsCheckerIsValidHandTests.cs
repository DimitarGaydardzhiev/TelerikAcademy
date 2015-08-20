namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using Poker;

    [TestClass]
    public class PokerHandsCheckerIsValidHandTests
    {
        [TestMethod]
        public void HandWithNoCardsShouldNotBeValid()
        {
            var hand = new Hand(new List<ICard>());
            var pokerHandChecker = new PokerHandsChecker();

            bool expected = false;
            bool actual = pokerHandChecker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HandWithMoreThanFiveEqualCardsShouldNotBeValid()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            });

            var pokerHandChecker = new PokerHandsChecker();

            bool expected = false;
            bool actual = pokerHandChecker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HandWithMoreThanFiveCardsShouldNotBeValid()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Nine,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Eight,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Diamonds)
            });

            var pokerHandChecker = new PokerHandsChecker();

            bool expected = false;
            bool actual = pokerHandChecker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HandWithLessThanFiveEqualCardsShouldNotBeValid()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            });

            var pokerHandChecker = new PokerHandsChecker();

            bool expected = false;
            bool actual = pokerHandChecker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HandWithMoreLessFiveCardsShouldNotBeValid()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Nine,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Eight,CardSuit.Spades)
            });

            var pokerHandChecker = new PokerHandsChecker();

            bool expected = false;
            bool actual = pokerHandChecker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HandWithFiveEqualCardsShouldNotBeValid()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            });

            var pokerHandChecker = new PokerHandsChecker();

            bool expected = false;
            bool actual = pokerHandChecker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HandWithFiveDifferentCardsShouldBeValid()
        {
            var hand = new Hand(new List<ICard> { 
                 new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Nine,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Eight,CardSuit.Spades),
                new Card(CardFace.Eight,CardSuit.Clubs)
            });

            var pokerHandChecker = new PokerHandsChecker();

            bool expected = true;
            bool actual = pokerHandChecker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HandWithMoreThanTwoEqualCardsShouldNotBeValid()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Nine,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Eight,CardSuit.Spades),
                new Card(CardFace.Eight,CardSuit.Spades)
            });

            var pokerHandChecker = new PokerHandsChecker();

            bool expected = false;
            bool actual = pokerHandChecker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }
    }
}
