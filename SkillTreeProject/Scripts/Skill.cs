using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkillTreeProject;

[CreateAssetMenu(fileName = "Skill", menuName = "new Skill")]
public class Skill : ScriptableObject
{

    public SkillTree skillTreeMembership;
    public Sprite icon;
    public List<SkillFunctionality> functionalities = new List<SkillFunctionality>();

}

[Serializable]
public struct SkillFunctionality
{
    public Functionality functionality;
    public float percentageValue;
}

public enum Functionality
{
    maxHealthPoints,
    maceDamage,
    swordDamage
}
