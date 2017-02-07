using DungeonMasterToolsInfrastructure.Model;

namespace DungeonMasterToolsInfrastructure.Domain
{
    public class DomainBaseHandler: IDomainBaseHandler<IEntity> 
    {
        context
        public IEntity AddEntity(IEntity entity, bool saveChanges)
        {
            var returnValue = context.SpecialAbilities.FirstOrDefault(x => x.Name == sa.Name);

            if (returnValue == null)
            {
                sa.Id = context.SpecialAbilities.Count() + 1;
                context.SpecialAbilities.Add(sa);
                returnValue = sa;

                if (saveChanges)
                {
                    context.SaveChanges();
                }
            }

            return returnValue;
        }
    }
}
