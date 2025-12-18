using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    public Cards cards;
   
    public SpriteRenderer artworkSprite;

    public void SetCard(Cards card)
    {
        artworkSprite.sprite = card.artwork;
    }

  
    /* check if card spawn works at start
    void Start()
    {
        artworkSprite.sprite = cards.artwork;

    }

    */
}
