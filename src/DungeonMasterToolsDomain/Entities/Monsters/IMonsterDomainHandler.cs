using System.Collections.Generic;
using DungeonMasterToolsModels.Entities.Monster;

namespace DungeonMasterToolsDomain.Entities.Monsters
{
    public interface IMonsterDomainHandler
    {
        string BulkAddMonsters(List<AddMonsterDto> monsters);
    }
}
