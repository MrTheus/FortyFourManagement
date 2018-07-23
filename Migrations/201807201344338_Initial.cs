namespace FortyFourManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CountryID);
            
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        LeagueId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_CountryID = c.Int(),
                    })
                .PrimaryKey(t => t.LeagueId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryID)
                .Index(t => t.Country_CountryID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PlayerUrl = c.String(),
                        ImageUrl = c.String(),
                        Position = c.String(),
                        Number = c.String(),
                        BirthDate = c.String(),
                        MarketValue = c.String(),
                        IsCaptain = c.Boolean(nullable: false),
                        Loaned = c.Boolean(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        Team_TeamId = c.Int(),
                        Used_UsedPlayerID = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerID)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .ForeignKey("dbo.UsedPlayers", t => t.Used_UsedPlayerID)
                .Index(t => t.Team_TeamId)
                .Index(t => t.Used_UsedPlayerID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TeamUrl = c.String(),
                        TeamPlayersUrl = c.String(),
                        PlayerCount = c.String(),
                        MarketValue = c.String(),
                        MarketValueMedian = c.String(),
                        Icon = c.String(),
                        League_LeagueId = c.Int(),
                    })
                .PrimaryKey(t => t.TeamId)
                .ForeignKey("dbo.Leagues", t => t.League_LeagueId)
                .Index(t => t.League_LeagueId);
            
            CreateTable(
                "dbo.UsedPlayers",
                c => new
                    {
                        UsedPlayerID = c.Int(nullable: false, identity: true),
                        PlayerUsed = c.Boolean(nullable: false),
                        PlayerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsedPlayerID);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        SeasonID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SeasonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Used_UsedPlayerID", "dbo.UsedPlayers");
            DropForeignKey("dbo.Players", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Teams", "League_LeagueId", "dbo.Leagues");
            DropForeignKey("dbo.Leagues", "Country_CountryID", "dbo.Countries");
            DropIndex("dbo.Teams", new[] { "League_LeagueId" });
            DropIndex("dbo.Players", new[] { "Used_UsedPlayerID" });
            DropIndex("dbo.Players", new[] { "Team_TeamId" });
            DropIndex("dbo.Leagues", new[] { "Country_CountryID" });
            DropTable("dbo.Seasons");
            DropTable("dbo.UsedPlayers");
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
            DropTable("dbo.Leagues");
            DropTable("dbo.Countries");
        }
    }
}
