namespace RentAHousband.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToHousbands : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PersonalityTypes (Type) VALUES ('outgoing')");
            Sql("INSERT INTO PersonalityTypes (Type) VALUES ('calm')");
            Sql("INSERT INTO PersonalityTypes (Type) VALUES ('gloomy')");
            Sql("INSERT INTO PersonalityTypes (Type) VALUES ('taciturn')");
            Sql("INSERT INTO Housbands (Name, SkillName, Age, IsBearded, PersonalityTypeId) VALUES ('Kaziu', 'Malarz', 70, 0, 2)");
            Sql("INSERT INTO Housbands (Name, SkillName, Age, IsBearded, PersonalityTypeId) VALUES ('Wiesiek', 'Tynkarz', 51, 1, 1)");
            Sql("INSERT INTO Housbands (Name, SkillName, Age, IsBearded, PersonalityTypeId) VALUES ('Tomek', 'Hydraulik', 29, 0, 4)");
            Sql("INSERT INTO Housbands (Name, SkillName, Age, IsBearded, PersonalityTypeId) VALUES ('Pioter', 'Cinkciarz', 34, 1, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
