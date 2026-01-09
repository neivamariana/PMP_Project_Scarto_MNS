using UnityEngine;
using System.Collections.Generic;

public class DealingManager : MonoBehaviour
{
    [SerializeField] private int cardsPerTurn = 5;
    [SerializeField] private int cardsPerPlayer = 25;

    public void Deal(RuntimeDeck deck, List<PlayerManager> players)
    {
        int rounds = cardsPerPlayer / cardsPerTurn;

        for (int round = 0; round < rounds; round++)
        {
            foreach (PlayerManager player in players)
            {
                for (int i = 0; i < cardsPerTurn; i++)
                {
                    Cards card = deck.Draw();
                    if (card == null)
                        return;

                    player.Hand.AddCard(card);
                    Debug.Log($"Dealt {card.name} to {player.Role}");
                }
            }
        }
    }
}

