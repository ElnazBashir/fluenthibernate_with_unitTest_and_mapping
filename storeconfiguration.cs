using System;
using FluentNHibernate.Automapping;

namespace shakiba
{
    public class StoreConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace == "shakiba.Entities";
        }
    }
}