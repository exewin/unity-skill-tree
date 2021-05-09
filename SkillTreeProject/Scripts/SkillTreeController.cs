using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillTreeProject
{
    public class SkillTreeController : MonoBehaviour
    {
        private int _pointsInTree;
        public int pointsInTree 
        {
            get => _pointsInTree; 
            set
            {
                _pointsInTree = value;
                foreach(SkillButton skillButton in _skillButtonsInTree)
                {
                    if(skillButton.requiredSkillPoints==pointsInTree)
                    {
                        skillButton.hasRequiredPoints=true;
                    }
                }
            } 
        }

        private List<SkillButton> _skillButtonsInTree = new List<SkillButton>();
        public List<SkillButton> skillButtonsInTree{get => _skillButtonsInTree; set => _skillButtonsInTree = value;}



    }
}

