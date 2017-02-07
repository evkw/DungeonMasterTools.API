using System.Collections.Generic;
using DungeonMasterToolsModels.Monster.DTOs;

namespace DungeonMasterToolsDomain.Monsters
{
    public interface IMonsterDomainHandler
    {
        string BulkAddMonsters(List<AddMonsterDto> monsters);
    }
}
