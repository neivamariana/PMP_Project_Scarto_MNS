using UnityEngine;

public enum Suit{ Fool, Trumps, Pentacles, Cups, Swords, Batons }

public enum Arcana { MajorArcana, MinorArcana }

[CreateAssetMenu(fileName = "Cards", menuName = "Scriptable Objects/Cards")]

public class Cards : ScriptableObject
{
    public Arcana arcana;

    public Suit suit;

    public int faceValue;

    public int points;

    public Sprite artwork;

    public string description;
 
}

   
