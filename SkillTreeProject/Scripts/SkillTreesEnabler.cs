using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillTreeProject
{
    public class SkillTreesEnabler : MonoBehaviour
    {
        private void EnableTrees()
        {   
            foreach(SkillTreeController tree in SkillTreeControllers.skillTreeControllers)
            {
                if(!tree) return;
                
                if(Players.selectedPlayer.availableSkillTrees.Contains(tree.skillTree))
                    tree.gameObject.SetActive(true);
                else
                    tree.gameObject.SetActive(false);
            }
        }

        private void OnEnable()
        {
            PlayerChanger.playerChangeEvent+=EnableTrees;
        }

        private void OnDisable()
        {
            PlayerChanger.playerChangeEvent-=EnableTrees;
        }
    }
}