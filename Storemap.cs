using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using shakiba.Entities;

namespace shakiba
{
    public class Storemap:IAutoMappingOverride<Store>
    {
        public void Override(AutoMapping<Store> mapping)
        {
            mapping.Id(x => x.Id).GeneratedBy.Assigned();
            mapping.Map(x => x.Name);
            mapping.HasMany(x => x.Employees).KeyColumn("StoreId").Cascade.AllDeleteOrphan();
            //mapping.HasManyToMany(x => x.Products);

        }
    }
}