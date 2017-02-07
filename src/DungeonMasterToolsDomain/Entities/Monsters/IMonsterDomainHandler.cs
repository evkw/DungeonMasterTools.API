using System.Collections.Generic;
using DungeonMasterToolsModels.Entities;

namespace DungeonMasterToolsDomain.Entities.Monsters
{
    public interface IMonsterDomainHandler
    {
        string BulkAddMonsters(List<MonsterModel> monsters);
    }
}
