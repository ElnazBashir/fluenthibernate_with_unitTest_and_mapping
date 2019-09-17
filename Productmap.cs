//using FluentNHibernate.Automapping;
//using FluentNHibernate.Automapping.Alterations;
//using shakiba.Entities;

//namespace shakiba
//{
//    public class Productmap:IAutoMappingOverride<Product>
//    {
//        public void Override(AutoMapping<Product> mapping)
//        {
//            mapping.Id(x => x.Id);
//            mapping.Map(x => x.Name);
//            mapping.Map(x => x.Price);
//            mapping.HasManyToMany(x => x.Stores)
//                .Table("StoreProduct");
//        }
//    }
//}