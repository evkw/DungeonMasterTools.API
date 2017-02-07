using AutoMapper;
using DungeonMasterToolsModels.Entities.Monster;

namespace DungeonMasterToolsModels
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(config => {
                config.CreateMap<AddMonsterDto, MonsterModel> ();
            });
        }
    }
}
