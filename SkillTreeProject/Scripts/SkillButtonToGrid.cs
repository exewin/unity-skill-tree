using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillTreeProject
{
    public class SkillButtonToGrid : MonoBehaviour
    {
        [SerializeField] private int x;
        [SerializeField] private int y;

        const int buttonSpace = 47;
        const int xOffset = 26;
        const int yOffset = -26;


        void OnValidate()
        {
            GetComponent<RectTransform>().anchoredPosition = new Vector2(x*buttonSpace+xOffset, -y*buttonSpace+yOffset);
        }

    }
}

