using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChanger : MonoBehaviour
{

    const string playerTag = "Player";

    void Awake()
    {
        foreach (var playerGameObject in GameObject.FindGameObjectsWithTag(playerTag))
        {
            Players.players.Add(playerGameObject.GetComponent<Player>());
        }
        SelectPlayer(0);
    }

    void SelectPlayer(int index)
    {
        Players.selectedPlayer = Players.players[index];
    }




}
