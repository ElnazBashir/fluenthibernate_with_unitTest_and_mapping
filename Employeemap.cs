using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using shakiba.Entities;

namespace shakiba
{
    public class Employeemap:IAutoMappingOverride<Employee>
    {
        public void Override(AutoMapping<Employee> mapping)
        {
            mapping.Id(x => x.Id).GeneratedBy.Assigned();
            mapping.Map(x => x.FirstName);
            mapping.Map(x => x.LastName);
            



        }
    }
}