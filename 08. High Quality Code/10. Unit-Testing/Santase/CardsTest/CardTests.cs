using System;
using System.Collections.Generic;
using NUnit.Framework;
using Santase.Logic;
using Santase.Logic.Cards;

[TestFixture]
public class CardTests
{
    [Test]
    public void DeckShouldNotThrowWhenInitializing()
    {
        var deck = new Deck();
    }

    [Test]
    public void DeckShouldHave24CardsAtInitializing()
    {
        var deck = new Deck();

        Assert.AreEqual(24, deck.CardsLeft);
    }

    [TestCase(25)]
    [ExpectedException(typeof(InternalGameException))]
    public void ExpectToThrownWhenNoMoreCardsToGet(int numberOfCards)
    {
        var deck = new Deck();

        for (int i = 0; i <= numberOfCards; i++)
        {
            deck.GetNextCard();
        }
    }

    [TestCase(5, 19)]
    public void ExpectToReturnCorectNumbersOfCardsLeft(int cardsToGet, int cardsLeft)
    {
        var deck = new Deck();

        for (int i = 0; i < cardsToGet; i++)
        {
            deck.GetNextCard();
        }

        Assert.AreEqual(cardsLeft, deck.CardsLeft);
    }

    [Test]
    public void ExpectGetTrumpCardMethodToReturnACard()
    {
        var deck = new Deck();
        var card = deck.GetTrumpCard;

        Assert.IsInstanceOf(typeof(Card), card);
    }

    [Test]

    public void ChangeTrumpCardShouldChangeTheTrumpCard()
    {
        var deck = new Deck();
        var trumpCard = deck.GetTrumpCard;
        var nextCard = deck.GetNextCard();

        deck.ChangeTrumpCard(nextCard);

        Assert.AreNotEqual(trumpCard, deck.GetTrumpCard);
    }
}