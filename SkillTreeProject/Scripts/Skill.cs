using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkillTreeProject;

[CreateAssetMenu(fileName = "Skill", menuName = "new Skill")]
public class Skill : ScriptableObject
{
    protected SkillTreeController _skillTreeControllerMembership;
    public SkillTreeController skillTreeControllerMembership
    {
        get => _skillTreeControllerMembership;
        set => _skillTreeControllerMembership = value;
    }
}
