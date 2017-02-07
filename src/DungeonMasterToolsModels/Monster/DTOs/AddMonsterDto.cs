using System.Collections.Generic;
using DungeonMasterToolsModels.Actions.Entities;
using DungeonMasterToolsModels.SpecialAbility.Entities;

namespace DungeonMasterToolsModels.Monster.DTOs
{
    /// <summary>
    /// Data Transfer Object for adding a new monster 
    /// </summary>
    public class AddMonsterDto
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Alignment { get; set; }
        public int ArmorClass { get; set; }
        public int HitPoints { get; set; }
        public string HitDice { get; set; }
        public string Speed { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Perception { get; set; }
        public string DamageVulnerabilities { get; set; }
        public string DamageResistences { get; set; }
        public string DamageImmunities { get; set; }
        public string ConditionImmunities { get; set; }
        public string Senses { get; set; }
        public string Languages { get; set; }
        public string ChallengeRating { get; set; }
        public List<ActionModel> Actions { get; set; }
        public List<SpecialAbilityModel> SpecialAbilities { get; set; }
    }
}
