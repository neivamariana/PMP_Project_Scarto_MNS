using UnityEngine;
using System.Collections.Generic;
//this is a class not a monobehaviour because it's its own datatype or data structure
//monobehaviour is a base data type I think lol 
public class Deck
{
    //I will not add this to the scene it's just a list that exists in unity's memory?
    private List<Cards> cards;
    //the deck is public so I can access it outside of the script but the list is private so I can only access it here 
    public Deck(List<Cards> startingCards)
    {
        cards = new List<Cards>(startingCards);
    }

    public bool IsEmpty()
    {
        return cards.Count == 0;
    }

    public Cards Deal()
    {
        Cards card = cards[0];
        cards.RemoveAt(0);
        return card;
    }

    public Cards RandomCard()
    {
        Cards card = cards[Random.Range(0, cards.Count)];
        cards.Remove(card);
        return card;
    }

    public void Shuffle()
    {
        for (int i = 0; i < cards.Count; i++)
        {
            int randomIndex = Random.Range(i, cards.Count);
            (cards[i], cards[randomIndex]) = (cards[randomIndex], cards[i]);
        }
    }
}
