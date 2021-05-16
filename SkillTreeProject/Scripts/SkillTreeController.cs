using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SkillTreeProject
{
    public class SkillTreeController : MonoBehaviour
    {

        [SerializeField] private Text pointsInTreeText;
        [SerializeField] private Text titleText;
        public SkillTree skillTree;

        private int _pointsInTree;
        public int pointsInTree 
        {
            get => _pointsInTree; 
            set
            {
                _pointsInTree = value;
                foreach(SkillButton skillButton in skillButtonsInTree)
                {
                    if(skillButton.requiredTreePoints<=pointsInTree)
                    {
                        skillButton.hasRequiredPoints=true;
                    }
                }
                UpdatePointsInTreeText();
            } 
        }

        private List<SkillButton> _skillButtonsInTree = new List<SkillButton>();
        public List<SkillButton> skillButtonsInTree
        {
            get => _skillButtonsInTree;
            set 
            {
                _skillButtonsInTree = value;
            }
        }

        void OnValidate()
        {
            if(gameObject.scene.rootCount == 0) return;
            UpdateTitleText();
        }
        void Awake() => SkillTreeControllerManager.GetInstance().skillTreeControllers.Add(this);

        void UpdateTitleText()
        {
            if(!titleText || !skillTree) return;

            titleText.text = skillTree.name;
            gameObject.name = skillTree.name + " Tree";
        }

        void UpdatePointsInTreeText()
        {
            if(!pointsInTreeText) return;

            int sum = 0;
            foreach(var button in skillButtonsInTree)
            {
               sum+=button.skills.Count;
            }

            pointsInTreeText.text = pointsInTree+"/"+sum;
        }



    }
}

