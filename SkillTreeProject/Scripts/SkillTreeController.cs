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

        public void AddSkill(SkillButton skillButton)
        {
            _skillButtonsInTree.Add(skillButton);
        }
    }
}

