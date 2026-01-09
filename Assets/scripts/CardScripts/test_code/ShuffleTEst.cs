using UnityEngine;

public class ShuffleTEst : MonoBehaviour
{
      public DeckData deckSO; 

    private RuntimeDeck runtimeDeck;

    void Start()
    {
        if (deckSO == null || deckSO.cards.Count == 0)
        {
            Debug.LogWarning("Deck SO is empty or not assigned!");
            return;
        }

        
        runtimeDeck = new RuntimeDeck(deckSO);

        
        runtimeDeck.Shuffle();

        
        Debug.Log("Shuffled deck:");
        Cards drawnCard;
        while ((drawnCard = runtimeDeck.Draw()) != null)
        {
            Debug.Log(drawnCard.name); 
        }

    }
}
