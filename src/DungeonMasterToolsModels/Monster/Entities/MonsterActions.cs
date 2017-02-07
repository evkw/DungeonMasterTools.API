using DungeonMasterToolsInfrastructure.Model;
using DungeonMasterToolsModels.Actions.Entities;

namespace DungeonMasterToolsModels.Monster.Entities
{
    /// <summary>
    /// Database model for mapping *:* relationship between monsters and actions
    /// </summary>
    public class MonsterActions: EntityBase
    { 
        public int MonsterId { get; set; }
        public MonsterModel Monster { get; set; }

        public int ActionId { get; set; }
        public ActionModel Action { get; set; }
        public int Id { get; set; }
    }
}
