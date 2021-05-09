using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SkillTreeProject
{
    public class SkillButton : MonoBehaviour
    {
        public static event Action<Skill> addSkillEvent;
        [SerializeField] private Text addedSkillPointsText;
        private int addedSkillPoints = 0;
        public int requiredSkillPoints;

        private bool _hasRequiredSkill = true;
        public bool hasRequiredSkill 
        {
            get => _hasRequiredSkill;
            set 
            { 
                _hasRequiredSkill = value;
                AttemptUnlock();
            }
        }
        private bool _hasRequiredPoints;
        public bool hasRequiredPoints 
        {
            get => _hasRequiredPoints;
            set 
            { 
                _hasRequiredPoints = value;
                AttemptUnlock();
            }
        }

        [SerializeField] private SkillTreeController skillTreeController;
        [SerializeField] private List<Skill> skills = new List<Skill>();
        [SerializeField] private List<SkillButton> unlockableSkills = new List<SkillButton>();
        [SerializeField] private string skillName;

        void Awake()
        { 
            UpdateText();
            skillTreeController.skillButtonsInTree.Add(this);

            foreach(var unlockableSkill in unlockableSkills)
            {
                unlockableSkill.hasRequiredSkill = false;
            }
        }


        void OnValidate()
        {
            gameObject.name = skillName;
            if(!addedSkillPointsText) return;

            UpdateText();
        }

        public void AddPoint()
        {
            if(addedSkillPoints>=skills.Count) return;
            
            addSkillEvent?.Invoke(skills[addedSkillPoints]);
            skillTreeController.pointsInTree++;
            addedSkillPoints++;
            UpdateText();

            if(addedSkillPoints == skills.Count)
            {
                MaxedOut();
            }
        }

        private void UpdateText() => addedSkillPointsText.text = addedSkillPoints+"/"+skills.Count;


        private void MaxedOut()
        {
            Lock();
            foreach(var unlocked in unlockableSkills)
            {
                unlocked.hasRequiredSkill = true;
            }
        }


        public void Lock() => GetComponent<Button>().interactable = false;

        private void AttemptUnlock()
        {
            if(!hasRequiredSkill) return;
            if(!hasRequiredPoints) return;

            GetComponent<Button>().interactable = true;
        }


    }
}
