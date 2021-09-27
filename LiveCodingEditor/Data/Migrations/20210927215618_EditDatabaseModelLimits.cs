namespace LiveCodingEditor.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class EditDatabaseModelLimits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CodeText",
                table: "HtmlExamples",
                type: "nvarchar(max)",
                maxLength: 2500000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CodeText",
                table: "HtmlExamples",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 2499984);
        }
    }
}