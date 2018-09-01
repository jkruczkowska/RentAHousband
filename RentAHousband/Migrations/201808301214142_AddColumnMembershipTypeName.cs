namespace RentAHousband.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set MembershipTypeName='PayAsYouGo' WHERE id = 1");
            Sql("UPDATE MembershipTypes set MembershipTypeName='Monthly' WHERE id = 2");
            Sql("UPDATE MembershipTypes set MembershipTypeName='Quarterly' WHERE id = 3");
            Sql("UPDATE MembershipTypes set MembershipTypeName='Annual' WHERE id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
