namespace TodoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TodoDetauls : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Details", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Details");
        }
    }
}
