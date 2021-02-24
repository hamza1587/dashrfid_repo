using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLib.Migrations
{
    public partial class defaultuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"if not exists(select * from Users where user_name = 'admin' And user_pass='admin')
                insert into Users([user_name], user_pass, user_role, is_active, created_at) values('admin', 'admin', 'admin', 1, GETDATE())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
