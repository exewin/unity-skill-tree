using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkillTreeProject;

    public class Player : MonoBehaviour
    {
        public List<Skill> skills = new List<Skill>();
        public List<SkillTree> availableSkillTrees = new List<SkillTree>();
        public int availableSkillPoints;

        void Awake() => Players.players.Add(this);


        public void AddSkill(Skill skill)
        {
            skills.Add(skill);
        }
    }
