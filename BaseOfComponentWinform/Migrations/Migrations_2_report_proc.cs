using FluentMigrator;

namespace BaseOfComponentWinform.Migrations
{
    [Migration(2)]
    public class Migration2 : Migration
    {
        public override void Up()
        {
            Execute.Sql(@"CREATE PROCEDURE [dbo].[Report]
	                                @parent int
                                AS
                                BEGIN
	                                with [tree] as (
	                                select [dbo].[Elements].[Name], [dbo].[Relations].[ElementChildId] as [id]
		                                from [dbo].[Relations]
		                                join [dbo].[Elements] on [dbo].[Relations].[ElementChildId] = [dbo].[Elements].[Id]
		                                where [dbo].[Relations].[ElementParentId] = @parent
	                                union all
		                                select [dbo].[Elements].[Name], [dbo].[Relations].[ElementChildId] as [id]
		                                from [dbo].[Relations]
		                                join [dbo].[Elements] on [dbo].[Relations].[ElementChildId] = [dbo].[Elements].[Id]
		                                inner join tree on [tree].[id] = [dbo].[Relations].[ElementParentId]
	                                ) 
	                                select [Id], [Name]
	                                from [tree] 
                                END
                                GO");
        }

        public override void Down()
        {
            Execute.Sql(@"DROP PROCEDURE [dbo].[Report]
                          GO");
        }
    }
}