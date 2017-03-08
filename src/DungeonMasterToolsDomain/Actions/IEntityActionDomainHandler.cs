using System.Linq;
using DungeonMasterToolsModels.Actions.Entities;
using DungeonMasterToolsRepository;

namespace DungeonMasterToolsDomain.Actions
{
    public interface IEntityActionDomainHandler
    {
        ActionModel AddActionModel(ActionModel action, bool saveChanges = false);
    }

    public class EntityActionDomainHandler : IEntityActionDomainHandler
    {
        private readonly DungeonMasterToolsDbContext context;

        public EntityActionDomainHandler(DungeonMasterToolsDbContext context)
        {
            this.context = context;
        }

        public ActionModel AddActionModel(ActionModel action, bool saveChanges = false)
        {
            var returnValue = context.Set<ActionModel>().FirstOrDefault(x => x.Name == action.Name);

            if (returnValue == null)
            {
                action.Id = context.Actions.Count() + 1;
                context.Actions.Add(action);
                returnValue = action;

                if (saveChanges)
                {
                    context.SaveChanges();
                }
            }

            return returnValue;
        }
    }
}
