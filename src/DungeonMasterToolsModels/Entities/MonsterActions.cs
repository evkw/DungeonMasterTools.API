namespace DungeonMasterTools.Models.Entities
{
    public class MonsterActions
    {
        public int Id { get; set; }
        public int MonsterId { get; set; }
        public MonsterModel Monster { get; set; }

        public int ActionId { get; set; }
        public EntityActionModel Action { get; set; }
    }
}
