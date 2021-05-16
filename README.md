# unity-skill-tree
world of warcraft-like skill/talent tree in unity c#

![alt text](https://github.com/exewin/unity-skill-tree/blob/main/other/preview.PNG)


## about

#### functionality:
- Skill tree based on talent trees from World Of Warcraft (Wotlk)
- Supports multiple skill trees
- Supports multiple players
- Player have specific trees available
- Selecting different player, resets tree accordingly to their acquired skills
- Skill Buttons can be locked/unlocked if they meet requirements: 
1. Adequate ```SkillTreeController``` has enough ```int pointsInTree```
2. Adequate ```SkillButton``` that has this concrete ```SkillButton``` in unlockable list, must be maxed out
- Skills are ```ScriptableObject``` with some possible functionality. See ```StatCalculator.cs```, ```StatMaceDamage.cs``` and ```Player.cs``` for example usage. Please note that this code only presents quick way of practical use of ```Skill.cs``` and is not designed for bigger scale.

#### used 3rd party assets:
- https://assetstore.unity.com/packages/2d/gui/icons/basic-rpg-icons-181301
- https://assetstore.unity.com/packages/tools/gui/clean-settings-ui-65588
- random wow screenshot
