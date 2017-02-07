using System;
using DungeonMasterToolsInfrastructure.Model;

namespace DungeonMasterToolsInfrastructure.Domain
{
    interface IDomainBaseHandler<TEntity> where TEntity: class, IEntity
    {

        TEntity AddEntity(TEntity entity, bool saveChanges);
    }
}
