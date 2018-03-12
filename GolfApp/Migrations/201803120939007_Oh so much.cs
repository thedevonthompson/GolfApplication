namespace GolfApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ohsomuch : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Game", "Hole1_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole10_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole11_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole12_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole13_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole14_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole15_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole16_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole17_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole18_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole2_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole3_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole4_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole5_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole6_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole7_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole8_HoleId", "dbo.Holes");
            DropForeignKey("dbo.Game", "Hole9_HoleId", "dbo.Holes");
            DropIndex("dbo.Game", new[] { "Hole1_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole10_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole11_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole12_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole13_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole14_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole15_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole16_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole17_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole18_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole2_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole3_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole4_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole5_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole6_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole7_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole8_HoleId" });
            DropIndex("dbo.Game", new[] { "Hole9_HoleId" });
            DropColumn("dbo.Game", "currHole");
            DropColumn("dbo.Game", "Hole1_HoleId");
            DropColumn("dbo.Game", "Hole10_HoleId");
            DropColumn("dbo.Game", "Hole11_HoleId");
            DropColumn("dbo.Game", "Hole12_HoleId");
            DropColumn("dbo.Game", "Hole13_HoleId");
            DropColumn("dbo.Game", "Hole14_HoleId");
            DropColumn("dbo.Game", "Hole15_HoleId");
            DropColumn("dbo.Game", "Hole16_HoleId");
            DropColumn("dbo.Game", "Hole17_HoleId");
            DropColumn("dbo.Game", "Hole18_HoleId");
            DropColumn("dbo.Game", "Hole2_HoleId");
            DropColumn("dbo.Game", "Hole3_HoleId");
            DropColumn("dbo.Game", "Hole4_HoleId");
            DropColumn("dbo.Game", "Hole5_HoleId");
            DropColumn("dbo.Game", "Hole6_HoleId");
            DropColumn("dbo.Game", "Hole7_HoleId");
            DropColumn("dbo.Game", "Hole8_HoleId");
            DropColumn("dbo.Game", "Hole9_HoleId");
            DropColumn("dbo.Holes", "HoleNum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Holes", "HoleNum", c => c.Int(nullable: false));
            AddColumn("dbo.Game", "Hole9_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole8_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole7_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole6_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole5_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole4_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole3_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole2_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole18_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole17_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole16_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole15_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole14_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole13_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole12_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole11_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole10_HoleId", c => c.Int());
            AddColumn("dbo.Game", "Hole1_HoleId", c => c.Int());
            AddColumn("dbo.Game", "currHole", c => c.Int());
            CreateIndex("dbo.Game", "Hole9_HoleId");
            CreateIndex("dbo.Game", "Hole8_HoleId");
            CreateIndex("dbo.Game", "Hole7_HoleId");
            CreateIndex("dbo.Game", "Hole6_HoleId");
            CreateIndex("dbo.Game", "Hole5_HoleId");
            CreateIndex("dbo.Game", "Hole4_HoleId");
            CreateIndex("dbo.Game", "Hole3_HoleId");
            CreateIndex("dbo.Game", "Hole2_HoleId");
            CreateIndex("dbo.Game", "Hole18_HoleId");
            CreateIndex("dbo.Game", "Hole17_HoleId");
            CreateIndex("dbo.Game", "Hole16_HoleId");
            CreateIndex("dbo.Game", "Hole15_HoleId");
            CreateIndex("dbo.Game", "Hole14_HoleId");
            CreateIndex("dbo.Game", "Hole13_HoleId");
            CreateIndex("dbo.Game", "Hole12_HoleId");
            CreateIndex("dbo.Game", "Hole11_HoleId");
            CreateIndex("dbo.Game", "Hole10_HoleId");
            CreateIndex("dbo.Game", "Hole1_HoleId");
            AddForeignKey("dbo.Game", "Hole9_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole8_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole7_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole6_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole5_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole4_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole3_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole2_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole18_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole17_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole16_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole15_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole14_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole13_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole12_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole11_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole10_HoleId", "dbo.Holes", "HoleId");
            AddForeignKey("dbo.Game", "Hole1_HoleId", "dbo.Holes", "HoleId");
        }
    }
}
