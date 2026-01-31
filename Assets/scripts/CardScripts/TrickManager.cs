using UnityEngine;
using System.Collections.Generic;


public class TrickManager : MonoBehaviour
{
    private List<Cards> currentTrick = new List<Cards>();

    public void AddCardToTrick(Cards card)
    {
        currentTrick.Add(card);

        Debug.Log($"Card added: {card.name}");

        if (currentTrick.Count >= 3)
        {
            ResolveTrick();
        }
    }

    private void ResolveTrick()
    {
        Debug.Log("Trick completed!! it workssssssssss!!!!!!!!");

        // ill add the winning trick logic here :))

        currentTrick.Clear();

        Debug.Log("the trick pile was cleared, we'll start the nxt trick!! hurray");


    }
}
