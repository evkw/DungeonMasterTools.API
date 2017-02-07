using System;
using System.Linq;
using DungeonMasterToolsModels.SpecialAbility.Entities;
using DungeonMasterToolsRepository;

namespace DungeonMasterToolsDomain.SpecialAbility
{
    public class SpecialAbilityDomainHandler: ISpecialAbilityDomainHandler
    {

        private readonly DungeonMasterToolsDbContext context;

        public SpecialAbilityDomainHandler(DungeonMasterToolsDbContext context)
        {
            this.context = context;
        }

        public SpecialAbilityModel LookUpSpecialAbilityByName(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempts to add a new Special Ability Record to database.
        /// Looks up by name first (natural key) and if already found, returns that record instead
        /// </summary>
        public SpecialAbilityModel AddSpecialAbility(SpecialAbilityModel sa, bool saveChanges = false)
        {
            var returnValue = context.SpecialAbilities.FirstOrDefault(x => x.Name == sa.Name);

            if(returnValue == null)
            {
                sa.Id = context.SpecialAbilities.Count() + 1;
                context.SpecialAbilities.Add(sa);
                returnValue = sa;

                if(saveChanges)
                {
                    context.SaveChanges();
                }
            }

            return returnValue;
        }
    }
}