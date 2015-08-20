using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandsCheckerIsFlushTests
    {
        [TestMethod]
        public void ShouldReturnFalseIfHandIsEmpty()
        {
            var hand = new Hand(new List<ICard>());
            var checker = new PokerHandsChecker();

            var expected = false;
            var actual = checker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnFalseIfCardsAreLessThanFive()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Nine,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Eight,CardSuit.Spades)
            });

            var checker = new PokerHandsChecker();

            var expected = false;
            var actual = checker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnFalseIfCardsAreMoreThanFive()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Nine,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Eight,CardSuit.Spades),
                new Card(CardFace.Nine,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Clubs)
            });

            var checker = new PokerHandsChecker();

            var expected = false;
            var actual = checker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnFalseIfCardsFromOneFaceAndOneSuit()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            });

            var checker = new PokerHandsChecker();

            var expected = false;
            var actual = checker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnFalseIfMoreThanTwoCardsAreFromOneFaceAndOneSuit()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            });

            var checker = new PokerHandsChecker();

            var expected = false;
            var actual = checker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnTrueIfCardsAreFromOneSuitAndDifferentFaces()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            });

            var checker = new PokerHandsChecker();

            var expected = true;
            var actual = checker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnFalseIfCardsAreFromDifferentSuitAndOneFaces()
        {
            var hand = new Hand(new List<ICard> { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            });

            var checker = new PokerHandsChecker();

            var expected = true;
            var actual = checker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }
    }
}
