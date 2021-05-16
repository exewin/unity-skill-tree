using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CalculateStat
{
    public static float GetValue(Player player)
    {
        float value = 1f;
        foreach(Skill skill in player.skills)
        {
            foreach(SkillFunctionality skillFunctionality in skill.functionalities)
            {
                if(skillFunctionality.functionality == player.functionalityToTest)
                {
                    value=value*(1+(skillFunctionality.percentageValue/100));
                }
            }
        }
        return value;
    }
}
