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
        private int _addedSkillPoints;
        public int addedSkillPoints
        {
            get => _addedSkillPoints;
            set 
            { 
                _addedSkillPoints = value;
                UpdateText();
                if(addedSkillPoints == skills.Count)
                {
                    maxedOut = true;
                }
                else
                    maxedOut = false;
            }
        }
        public int requiredTreePoints;

        private bool _hasRequiredSkill = true;
        public bool hasRequiredSkill 
        {
            get => _hasRequiredSkill;
            set 
            { 
                _hasRequiredSkill = value;
                if(value==true)
                    AttemptUnlock();
                else
                    Lock();
            }
        }
        private bool _hasRequiredPoints;
        public bool hasRequiredPoints 
        {
            get => _hasRequiredPoints;
            set 
            { 
                _hasRequiredPoints = value;
                if(value==true)
                    AttemptUnlock();
                else
                    Lock();
            }
        }
        private bool _maxedOut;
        public bool maxedOut
        {
            get => _maxedOut;
            set 
            { 
                _maxedOut = value;
                if(value==true)
                {
                    Lock();
                    UnlockUnlockableSkills();
                }
                else
                    AttemptUnlock();
            }
        }

        [SerializeField] private SkillTreeController skillTreeController;
        public List<Skill> skills = new List<Skill>();
        [SerializeField] private List<SkillButton> unlockableSkills = new List<SkillButton>();
        [SerializeField] private string skillName;

        void Start()
        {
            ResetButton();

            if(!skillTreeController.skillButtonsInTree.Contains(this))
                skillTreeController.skillButtonsInTree.Add(this);
                
        }

        void OnValidate()
        {
            if(!skillTreeController.skillButtonsInTree.Contains(this))
                skillTreeController.skillButtonsInTree.Add(this);

            gameObject.name = skillName + " Button";

            if(!addedSkillPointsText) return;
            UpdateText();
        }

        void OnDrawGizmosSelected()
        {
            foreach(var unlockableSkill in unlockableSkills)
            {
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(transform.position, unlockableSkill.transform.position);
            }
        }

        public void AddPoint()
        {
            addSkillEvent?.Invoke(skills[addedSkillPoints]);
            skillTreeController.pointsInTree++;
            addedSkillPoints++;
            UpdateText();
        }

        public void ResetButton()
        {
            addedSkillPoints=0;

            if(requiredTreePoints>0)
                hasRequiredPoints=false;
            else
                hasRequiredPoints=true;

            hasRequiredSkill=true;
            foreach(var unlockableSkill in unlockableSkills)
            {
                unlockableSkill.hasRequiredSkill = false;
            }
        }

        private void UpdateText() => addedSkillPointsText.text = addedSkillPoints+"/"+skills.Count;

        private void UnlockUnlockableSkills()
        {
            foreach(var unlocked in unlockableSkills)
            {
                unlocked.hasRequiredSkill = true;
            }
        }


        private void Lock() => GetComponent<Button>().interactable = false;

        private void AttemptUnlock()
        {
            if(!hasRequiredSkill) return;
            if(!hasRequiredPoints) return;
            if(maxedOut) return;

            GetComponent<Button>().interactable = true;
        }


    }
}
