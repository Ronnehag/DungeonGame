using Microsoft.EntityFrameworkCore.Migrations;

namespace Dungeon.Migrations
{
    public partial class UpdatingCharacterStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Level",
                table: "CharacterStatses",
                newName: "CurrentLevel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrentLevel",
                table: "CharacterStatses",
                newName: "Level");
        }
    }
}
