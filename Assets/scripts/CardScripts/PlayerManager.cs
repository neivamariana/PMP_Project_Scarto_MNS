using UnityEngine;

// creates a player gives them a role & links it to their hand
// will add NPC AI after rn its just for  (playble?) playable charcters

public enum PlayerRole
{
    Dealer,
    Elder,
    Player
}

public class PlayerManager
{
    public PlayerRole Role { get; }
    public HandManager Hand { get; }

    public PlayerManager(PlayerRole role)
    {
        Role = role;
        Hand = new HandManager();
    }
}
