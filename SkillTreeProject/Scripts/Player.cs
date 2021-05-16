using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkillTreeProject;

public class Player : MonoBehaviour
{
    private List<Skill> _skills = new List<Skill>();
    public List<Skill> skills
    {
        get => _skills;
        set => _skills = value;
    }



    public List<SkillTree> availableSkillTrees = new List<SkillTree>();

    void Awake() => PlayerManager.GetInstance().players.Add(this);



    //test weapon damage
    public Functionality functionalityToTest;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(gameObject.name +"s "+ functionalityToTest.ToString() + " is " + CalculateStat.GetValue(this));
        }
    }
    //
}
