using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkillTreeProject;

    public class PlayersEventSetSkill : MonoBehaviour
    {
        private void OnEnable()
        {
            SkillButton.addSkillEvent+=SetSkill;
        }

        private void OnDisable()
        {
            SkillButton.addSkillEvent-=SetSkill;
        }

        private void SetSkill(Skill skill)
        {
            Players.selectedPlayer.AddSkill(skill);
        }
    }
