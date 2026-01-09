using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [SerializeField] private DeckData startingDeck;
    [SerializeField] private DealingManager dealingManager;

    private RuntimeDeck deck;
    private List<PlayerManager> players = new List<PlayerManager>();

    void Start()
    {
        SetupPlayers();

        SetupDeck();

        DealCards();

        DebugHands();

        Debug.Log("IT WORKS HURRAY!! :)))))");

    }

    void SetupPlayers()
    {
        players.Add(new PlayerManager(PlayerRole.Elder));

        players.Add(new PlayerManager(PlayerRole.Player));

        players.Add(new PlayerManager(PlayerRole.Dealer));
    }

    void SetupDeck()
    {
        deck = new RuntimeDeck(startingDeck);
        deck.Shuffle();
    }

    void DealCards()
    {
        dealingManager.Deal(deck, players);
    }

    void DebugHands()
    {
        foreach (PlayerManager player in players)
        {
           Debug.Log($"{player.Role} has {player.Hand.Count} cards."); 
        }
        Debug.Log($"Cards left in deck: {deck.Count}");
    }
}