using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkillTreeProject;

[CreateAssetMenu(fileName = "Skill", menuName = "new Skill")]
public class Skill : ScriptableObject
{

    public SkillTree skillTreeMembership;
    public Sprite icon;

}
