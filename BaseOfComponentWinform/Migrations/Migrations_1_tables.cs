using FluentMigrator;

namespace BaseOfComponentWinform.Migrations
{
    [Migration(1)]
    public class Migration1 : Migration
    {
        private const string TableElement = "Elements";
        private const string TableRelation = "Relations";

        private const string FKRelationParent = "FK_Relation_Parent";
        private const string FKRelationChild = "FK_Relation_Child";

        public override void Up()
        {
            Create.Table(TableElement)
                       .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                       .WithColumn("Name").AsString(1000).NotNullable()
                       .WithColumn("Count").AsInt32().NotNullable();

            Create.Table(TableRelation)
                       .WithColumn("ElementParentId").AsInt32().Nullable()
                       .WithColumn("ElementChildId").AsInt32().NotNullable();

            Create.ForeignKey(FKRelationParent)
                .FromTable(TableRelation).ForeignColumn("ElementParentId")
                .ToTable(TableElement).PrimaryColumn("Id").OnDelete(System.Data.Rule.None);

            Create.ForeignKey(FKRelationChild)
                .FromTable(TableRelation).ForeignColumn("ElementChildId")
                .ToTable(TableElement).PrimaryColumn("Id").OnDelete(System.Data.Rule.None);
        }

        public override void Down()
        {
            Delete.ForeignKey(FKRelationParent);
            Delete.ForeignKey(FKRelationChild);

            Delete.Table(TableRelation);
            Delete.Table(TableElement);
        }
    }
}