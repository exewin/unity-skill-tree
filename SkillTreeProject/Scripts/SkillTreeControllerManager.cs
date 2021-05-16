using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SkillTreeProject
{
    public class SkillTreeControllerManager
    {
        private SkillTreeControllerManager() { }
        private static SkillTreeControllerManager _instance;

        public static SkillTreeControllerManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SkillTreeControllerManager();
            }
            return _instance;
        }

        public List<SkillTreeController> skillTreeControllers = new List<SkillTreeController>();
    }
}
