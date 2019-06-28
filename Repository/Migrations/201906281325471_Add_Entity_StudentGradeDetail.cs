namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Entity_StudentGradeDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentGradeDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Student = c.String(),
                        LanguageArts = c.Int(nullable: false),
                        Science = c.Int(nullable: false),
                        SocialStudies = c.Int(nullable: false),
                        Maths = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentGradeDetails");
        }
    }
}
