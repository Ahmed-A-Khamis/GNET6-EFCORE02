using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNET6_EFCORE02.Migrations
{
    /// <inheritdoc />
    public partial class thirdVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registerations");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Organizers");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Organizers");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Attendees",
                newName: "Address_Street");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Attendees",
                newName: "Address_PostalCode");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Attendees",
                newName: "Address_Country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Attendees",
                newName: "Address_City");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<string>(
                name: "Address_Street",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address_PostalCode",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address_Country",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address_City",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "OrganizersProfiles",
                columns: table => new
                {
                    OrganizerId = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizersProfiles", x => x.OrganizerId);
                    table.ForeignKey(
                        name: "FK_OrganizersProfiles_Organizers_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "Organizers",
                        principalColumn: "OrganizerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => new { x.EventId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Registrations_Attendees_UserId",
                        column: x => x.UserId,
                        principalTable: "Attendees",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registrations_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_UserId",
                table: "Registrations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizersProfiles");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "Attendees",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Address_PostalCode",
                table: "Attendees",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "Address_Country",
                table: "Attendees",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Attendees",
                newName: "City");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Registerations",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registerations", x => new { x.EventId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Registerations_Attendees_UserId",
                        column: x => x.UserId,
                        principalTable: "Attendees",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registerations_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registerations_UserId",
                table: "Registerations",
                column: "UserId");
        }
    }
}
