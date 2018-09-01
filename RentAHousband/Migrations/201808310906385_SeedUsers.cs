namespace RentAHousband.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'16789cb7-5a0e-4cbb-8367-64b60f2e1c86', N'manager@rentahousband.com', 0, N'AEmwG3Az+dzZYbm+9k6tBBFKBtoObs9QPQhZbHYi0bqDmpfzrq1/FsBZtXDbTVVdfg==', N'b053f655-8f18-4108-bed5-ebe3db77da2e', NULL, 0, 0, NULL, 1, 0, N'manager@rentahousband.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd9eae1b2-5c3b-4b42-8d83-8bf551245e00', N'guest@rentahousband.com', 0, N'ALG+GoONZdEYI1Yi/hxnAyw2PgB0jWBsbJZvY0MSRaMD5B0GN9fGAvyljSxCbhxQGQ==', N'396beebc-4d36-4e31-a66e-9c3c929e6c9a', NULL, 0, 0, NULL, 1, 0, N'guest@rentahousband.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'91a97075-43e8-4be4-8a90-271afe6626fa', N'CanManageHousbands')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'16789cb7-5a0e-4cbb-8367-64b60f2e1c86', N'91a97075-43e8-4be4-8a90-271afe6626fa')
");
        }
        
        public override void Down()
        {
        }
    }
}
