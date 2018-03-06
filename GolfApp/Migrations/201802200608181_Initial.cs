namespace GolfApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        currHole = c.Int(),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Holes",
                c => new
                    {
                        HoleId = c.Int(nullable: false, identity: true),
                        HoleNum = c.Int(nullable: false),
                        TotalShots = c.Int(nullable: false),
                        DriveType = c.String(),
                        OnFairway = c.Boolean(nullable: false),
                        InRegulation = c.Boolean(nullable: false),
                        Par = c.Int(nullable: false),
                        NumPutts = c.Int(nullable: false),
                        Game_GameId = c.Int(),
                    })
                .PrimaryKey(t => t.HoleId)
                .ForeignKey("dbo.Games", t => t.Game_GameId)
                .Index(t => t.Game_GameId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Holes", "Game_GameId", "dbo.Games");
            DropIndex("dbo.Holes", new[] { "Game_GameId" });
            DropIndex("dbo.Games", new[] { "User_UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Holes");
            DropTable("dbo.Games");
        }
    }
}
