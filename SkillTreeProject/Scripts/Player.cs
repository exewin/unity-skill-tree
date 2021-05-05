using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkillTreeProject;

    public class Player : MonoBehaviour
    {
        public List<Skill> skills = new List<Skill>();
        public int availableSkillPoints;

        public void AddSkill(Skill skill)
        {
            skills.Add(skill);
        }
    }
