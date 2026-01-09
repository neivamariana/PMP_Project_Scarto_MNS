using UnityEngine;
using System.Collections.Generic;

public class HandManager
{
    private List<Cards> cards = new List<Cards>();

    public int Count => cards.Count;


//IReadOnlyList guess what?? only read the lisyt it cant change it >:O
    public IReadOnlyList<Cards> Cards => cards;

//calls card into hand 
    public void AddCard(Cards card)
    {
        cards.Add(card);
    }

//card leaves hand --> this is for when a card is played :))
    public void RemoveCard(Cards card)
    {
        cards.Remove(card);
    }

//clears the hand --> if i want to add a restart button?
    public void Clear()
    {
        cards.Clear();

    }
    
}
