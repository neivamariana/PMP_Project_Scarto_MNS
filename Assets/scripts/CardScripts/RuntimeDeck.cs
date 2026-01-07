using UnityEngine;
using System.Collections.Generic;


public class RuntimeDeck
{
    private List<Cards> cards;

    public RuntimeDeck(DeckData deckData)
    {
        cards = new List<Cards>(deckData.cards);
    }

    public void Shuffle()
    {
        cards.Shuffle();

    }

    public Cards Draw()
    {
        if (cards.Count == 0)
            return null;

        Cards topCard = cards[0];
        cards.RemoveAt(0);
        return topCard;
    }
    
}
