using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SkillTreeProject
{
    public class SkillButtonIcon : MonoBehaviour
    {
        [SerializeField] private SkillButton skillButton;
        void OnValidate()
        {
            if(!skillButton) return;
            GetComponent<Image>().sprite = skillButton.skills[0].icon;
        }
    }
}