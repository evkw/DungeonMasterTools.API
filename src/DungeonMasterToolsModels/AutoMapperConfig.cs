using AutoMapper;
using DungeonMasterToolsModels.Monster.DTOs;
using DungeonMasterToolsModels.Monster.Entities;

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
