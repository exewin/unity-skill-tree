using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillTreeProject
{
    public class TreeToAssignerLink : MonoBehaviour
    {
        void Awake()
        {
            SkillButtonAssigner.skillTreeControllers.Add(GetComponent<SkillTreeController>());
        }
    }
}
