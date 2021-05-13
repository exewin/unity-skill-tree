using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StatMaceDamage
{
    public static float GetDamage(Player player)
    {
        float damage = 1f;
        foreach(Skill skill in player.skills)
        {
            foreach(SkillFunctionality skillFunctionality in skill.functionalities)
            {
                if(skillFunctionality.functionality == Functionality.maceDamage)
                {
                    damage=damage*(1+(skillFunctionality.percentageValue/100));
                }
            }
        }
        return damage;
    }

}
