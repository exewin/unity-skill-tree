using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChanger : MonoBehaviour
{

    public static event Action playerChangeEvent;

    public void SelectPlayer(int index)
    {
        PlayerManager.GetInstance().SelectPlayer(index);
        playerChangeEvent?.Invoke();
    }

    void Awake() => SelectPlayer(0);




}
