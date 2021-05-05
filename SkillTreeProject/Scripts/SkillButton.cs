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
        [SerializeField] private int requiredSkillPoints = 0; // not used yet
        [SerializeField] private List<Skill> skills = new List<Skill>();
        [SerializeField] private List<SkillButton> unlockableSkills = new List<SkillButton>();
        [SerializeField] private string skillName;

        void Awake()
        {
            UpdateText();
        }

        void OnValidate() => gameObject.name = skillName;

        public void AddPoint()
        {
            if(addedSkillPoints>=skills.Count) return;

            addSkillEvent?.Invoke(skills[addedSkillPoints]);

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
            GetComponent<Button>().interactable = false;
            foreach(var unlocked in unlockableSkills)
            {
                unlocked.GetComponent<Button>().interactable = true;
            }
        }

    }
}
