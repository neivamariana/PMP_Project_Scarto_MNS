using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [SerializeField] private DeckData startingDeck;
    [SerializeField] private DealingManager dealingManager;
    [SerializeField] private TrickManager trickManager;

    private RuntimeDeck deck;
    private List<PlayerManager> players = new List<PlayerManager>();


    private int currentPlayerIndex = 0;
    
    void Start()
    {
        SetupGame();
        Debug.Log("worked :0");
        
    }

    private void SetupGame()
    {
        SetupDeck();
        CreatePlayers();
        DealCards();
        //Debug.Log("IT WORKS HURRAY!! :)))))");

        currentPlayerIndex = 0;
        //Debug.Log($"player #1: {players[currentPlayerIndex].Role}");

    }

    private void SetupDeck()
    {
        deck = new RuntimeDeck(startingDeck);
        deck.Shuffle();
    }

    private void CreatePlayers()
    {
        players.Clear();

        players.Add(new PlayerManager(PlayerRole.Player));
        players.Add(new PlayerManager(PlayerRole.Elder));
        players.Add(new PlayerManager(PlayerRole.Dealer));
    }

    private void DealCards()
    {
        dealingManager.Deal(deck, players);
    }


    // turn system section -> i will probably change this/ polish it later 

    public void PlayTurn(int cardIndex)
    {
        PlayerManager currentPlayer = players[currentPlayerIndex];

        Cards playedCard = currentPlayer.Hand.PlayCard(cardIndex);
        if (playedCard == null)
            return;

        Debug.Log($"{currentPlayer.Role} played {playedCard.name}");

        trickManager.AddCardToTrick(playedCard);
        
        AdvanceTurn();
    }

    private void AdvanceTurn()
    {

        currentPlayerIndex++;

        if(currentPlayerIndex >= players.Count)
        {
            currentPlayerIndex = 0;

        }

        Debug.Log($"Next turn: {players[currentPlayerIndex].Role}");


    }

    //this input system is just for testing!! 

    private void Update()
    {
        //alpha1 means the number 1 key on the keyboard :0 don't forget 
        if (Input.GetKeyDown(KeyCode.Alpha1))
            PlayTurn(0);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            PlayTurn(1);  

        if (Input.GetKeyDown(KeyCode.Alpha3))
            PlayTurn(2);  

        
    }


}