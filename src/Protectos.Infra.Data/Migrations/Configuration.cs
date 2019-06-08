namespace Protectos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Protectos.Infra.Data.Context.ProtectosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Protectos.Infra.Data.Context.ProtectosContext context)
        {
           
        }
    }
}
