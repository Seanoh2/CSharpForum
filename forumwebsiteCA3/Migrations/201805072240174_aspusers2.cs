namespace forumwebsiteCA3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aspusers2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.comments", "senderID", c => c.String());
            AlterColumn("dbo.moderators", "userID", c => c.String());
            AlterColumn("dbo.posts", "userID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.posts", "userID", c => c.Int(nullable: false));
            AlterColumn("dbo.moderators", "userID", c => c.Int(nullable: false));
            AlterColumn("dbo.comments", "senderID", c => c.Int(nullable: false));
        }
    }
}
