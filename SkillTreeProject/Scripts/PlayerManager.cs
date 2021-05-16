using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager
{

    private PlayerManager() { }
    private static PlayerManager _instance;

    public static PlayerManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new PlayerManager();
        }
        return _instance;
    }

    public List<Player> players = new List<Player>();
    public Player selectedPlayer;

    public void SelectPlayer(int index)
    {
        selectedPlayer = players[index];
    }
}
