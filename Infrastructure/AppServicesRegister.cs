using Funq;
using ServiceStack;

namespace ServiceStackApp.Infrastructure
{
    public class AppServicesRegister
    {
        protected Container Container;
        public AppServicesRegister(ServiceStackHost self)
        {
            Container = self.Container;
        }

        public void Init()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            //var connectionFactory = new OrmLiteConnectionFactory(":memory:", SqliteDialect.Provider);
            //Container.Register<IDbConnectionFactory>(c => connectionFactory);

            //var db = new Database();
            //db.CreateTablesAndTestData(connectionFactory);
            //Container.RegisterAutoWiredAs<Database, IDatabase>();
        }

    }
}
