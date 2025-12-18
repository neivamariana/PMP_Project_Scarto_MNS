using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    public Cards cards;

    public SpriteRenderer artworkSprite;

    public void SetCard(Cards card)
    {
        artworkSprite.sprite = card.artwork;
    }

}
