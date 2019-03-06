using BusinessLogicLayer;
using DataAccessLayer;
using Ninject.Modules;
using System.Data.Entity;

namespace Store
{
    public class CustomNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMyBll>().To<MyBll>();
            Bind<IMyDal>().To<MyDal>();
            Bind<DbContext>().To<ConcreteMarket>();
        }
    }
}