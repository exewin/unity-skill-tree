using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillTreeProject
{
    public class SkillButtonAssigner : MonoBehaviour
    {

        public static List<SkillTreeController> skillTreeControllers = new List<SkillTreeController>();

        private void OnEnable()
        {
            PlayerChanger.playerChangeEvent+=AssignSkillsToButtons;
        }

        private void OnDisable()
        {
            PlayerChanger.playerChangeEvent-=AssignSkillsToButtons;
        }

        private void AssignSkillsToButtons()
        {
            List<Skill> playerSkills = Players.selectedPlayer.skills;
            foreach(var treeController in skillTreeControllers)
            {
                treeController.pointsInTree = 0;
                foreach(var skillButton in treeController.skillButtonsInTree)
                {
                    skillButton.ResetButton();
                    List<Skill> buttonSkills = skillButton.skills;

                    for(int i = buttonSkills.Count-1; i >= 0; i--)
                    {
                        if(playerSkills.Contains(buttonSkills[i]))
                        {
                            treeController.pointsInTree += i+1;
                            skillButton.addedSkillPoints = i+1;
                            break;
                        }
                    }
                }
            }
        }


    }
}
