namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenrestable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) Values (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) Values (2, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) Values (3, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) Values (4, 'Country')");
        }
        
        public override void Down()
        {
            Sql("Delete From Genres Where Id IN (1, 2, 3, 4");
        }
    }
}
