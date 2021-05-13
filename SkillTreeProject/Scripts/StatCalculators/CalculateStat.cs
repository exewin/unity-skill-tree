using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CalculateStat
{
    public static float GetDamage(Player player)
    {
        //you can check here what weapon player has etc.
        //example only shows mace damage
        return StatMaceDamage.GetDamage(player);
    }

}
