using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChanger : MonoBehaviour
{

    public static event Action playerChangeEvent;
    const string playerTag = "Player";

    void Awake()
    {
        foreach (var playerGameObject in GameObject.FindGameObjectsWithTag(playerTag))
        {
            Players.players.Add(playerGameObject.GetComponent<Player>());
        }
        SelectPlayer(0);
    }

    public void SelectPlayer(int index)
    {
        Players.selectedPlayer = Players.players[index];
        playerChangeEvent?.Invoke();
    }




}
