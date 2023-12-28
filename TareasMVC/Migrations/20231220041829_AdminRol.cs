using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                        IF NOT EXISTS(SELECT Id FROM AspNetRoles where Id='0d5f3113-f47e-449b-b047-d7c3ffade6a2')
                        BEGIN
	                        INSERT AspNetRoles(Id,[Name],[NormalizedName])
	                        VALUES ('0d5f3113-f47e-449b-b047-d7c3ffade6a2','admin','ADMIN')
                        END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id='0d5f3113-f47e-449b-b047-d7c3ffade6a2'");
        }
    }
}
