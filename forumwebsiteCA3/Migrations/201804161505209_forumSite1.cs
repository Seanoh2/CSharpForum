namespace forumwebsiteCA3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forumSite1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.comments",
                c => new
                    {
                        commentID = c.Int(nullable: false, identity: true),
                        postID = c.Int(nullable: false),
                        senderID = c.Int(nullable: false),
                        time = c.DateTime(nullable: false),
                        content = c.String(),
                    })
                .PrimaryKey(t => t.commentID);
            
            CreateTable(
                "dbo.forums",
                c => new
                    {
                        forumID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                        sidebar = c.String(),
                        wiki = c.String(),
                    })
                .PrimaryKey(t => t.forumID);
            
            CreateTable(
                "dbo.moderators",
                c => new
                    {
                        moderatorID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        forumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.moderatorID);
            
            CreateTable(
                "dbo.posts",
                c => new
                    {
                        postID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        forumID = c.Int(nullable: false),
                        isLink = c.Int(nullable: false),
                        title = c.String(),
                        content = c.String(),
                        score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.postID);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        email = c.String(),
                        password = c.String(),
                        isAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
            DropTable("dbo.posts");
            DropTable("dbo.moderators");
            DropTable("dbo.forums");
            DropTable("dbo.comments");
        }
    }
}
