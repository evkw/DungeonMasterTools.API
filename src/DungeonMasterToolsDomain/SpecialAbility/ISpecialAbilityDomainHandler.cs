using DungeonMasterToolsModels.SpecialAbility.Entities;

namespace DungeonMasterToolsDomain.SpecialAbility
{
    public interface ISpecialAbilityDomainHandler
    {
        SpecialAbilityModel LookUpSpecialAbilityByName(string name);
        SpecialAbilityModel AddSpecialAbility(SpecialAbilityModel sa, bool saveChanges);
    }
}
