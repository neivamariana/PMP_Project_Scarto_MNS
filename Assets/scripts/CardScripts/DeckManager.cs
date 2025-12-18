using UnityEngine;
//this script will manage the deck
public class DeckManager : MonoBehaviour
{
  public List<Cards> FullDeck; 
  public CardDisplay display;

    void Start()
    {
        //make me a new deck pls 
        Deck deck = new Deck(FullDeck);
        deck.Shuffle();

        Cards drawn = deck.Deal();
        display.cards = drawn;
    }
}
