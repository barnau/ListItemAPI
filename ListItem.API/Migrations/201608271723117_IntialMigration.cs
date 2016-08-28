namespace ListItem.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ListItems",
                c => new
                    {
                        ListItemID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        PriorityClass = c.String(),
                        PriorityNumber = c.String(),
                    })
                .PrimaryKey(t => t.ListItemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ListItems");
        }
    }
}
