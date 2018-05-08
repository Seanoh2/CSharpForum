namespace forumwebsiteCA3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aspusers4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.posts", "forumID", c => c.Int(nullable: false));

        }

        public override void Down()
        {
            AlterColumn("dbo.posts", "forumID", c => c.String());
        }
    }
}
