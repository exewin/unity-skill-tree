using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SkillTreeProject
{
    public class SkillButtonIcon : MonoBehaviour
    {
        void OnValidate()
        {
            SkillButton skillButton = GetComponent<SkillButton>();
            GetComponent<Image>().sprite = skillButton.skills[0].icon;
        }
    }
}