using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    public Cards cards;

    public SpriteRenderer artworkSprite;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        artworkSprite.sprite = cards.artwork;
        
        Debug.Log ("im working");
    }


}
