namespace DungeonMasterToolsModels.Entities
{
    public class MonsterSpecialAbilities
    {
        public int Id { get; set; }
        public int MonsterId { get; set; }
        public MonsterModel Monster { get; set; }

        public int SpecialAbilityId { get; set; }
        public EntitySpecialAbilityModel SpecialAbility { get; set; }
    }
}
