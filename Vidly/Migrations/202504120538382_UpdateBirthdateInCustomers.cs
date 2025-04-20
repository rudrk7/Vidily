namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdateInCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set BirthDate='1999-01-15' Where Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
