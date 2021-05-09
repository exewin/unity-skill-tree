using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillTreeProject
{
    public class SkillButtonAssigner : MonoBehaviour
    {

        public static List<SkillTreeController> skillTreeControllers = new List<SkillTreeController>();

        void Awake()
        {

        }

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
            foreach(var tree in skillTreeControllers)
            {
                foreach(var skillButton in tree.skillButtonsInTree)
                {
                    //Players.selectedPlayer
                    skillButton.Lock();
                }
            }
        }

    }
}
