using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLib.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RFIDLocations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location_name = table.Column<string>(maxLength: 50, nullable: true),
                    location_type = table.Column<string>(maxLength: 50, nullable: true),
                    is_active = table.Column<bool>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RFIDLocations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RFIDNotifications",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title_n = table.Column<string>(maxLength: 50, nullable: true),
                    description_n = table.Column<string>(maxLength: 150, nullable: true),
                    status_n = table.Column<string>(maxLength: 50, nullable: true),
                    reference_n = table.Column<string>(maxLength: 50, nullable: true),
                    is_active = table.Column<bool>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RFIDNotifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RFIDSysStatus",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status_sys = table.Column<string>(maxLength: 50, nullable: true),
                    notes = table.Column<string>(maxLength: 100, nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RFIDSysStatus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TagsInventory",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    epc = table.Column<string>(maxLength: 50, nullable: true),
                    userdata = table.Column<string>(maxLength: 100, nullable: true),
                    tagfunction = table.Column<string>(maxLength: 50, nullable: true),
                    tagstatus = table.Column<string>(maxLength: 50, nullable: true),
                    is_active = table.Column<bool>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagsInventory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(nullable: true),
                    user_pass = table.Column<string>(nullable: true),
                    user_role = table.Column<string>(nullable: true),
                    is_active = table.Column<bool>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReadersInventory",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reader_name = table.Column<string>(maxLength: 100, nullable: true),
                    reader_type = table.Column<string>(maxLength: 20, nullable: true),
                    reader_ip = table.Column<string>(maxLength: 25, nullable: true),
                    reader_macaddress = table.Column<string>(maxLength: 50, nullable: true),
                    reader_status = table.Column<string>(maxLength: 100, nullable: true),
                    location_id = table.Column<int>(nullable: true),
                    sets_status = table.Column<string>(maxLength: 100, nullable: true),
                    connection_check = table.Column<bool>(nullable: true),
                    is_active = table.Column<bool>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadersInventory", x => x.id);
                    table.ForeignKey(
                        name: "FK_ReadersInventory_RFIDLocations_location_id",
                        column: x => x.location_id,
                        principalTable: "RFIDLocations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Associations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    readtime = table.Column<DateTime>(nullable: false),
                    association_name = table.Column<string>(nullable: true),
                    user_id = table.Column<int>(nullable: true),
                    reader_id = table.Column<int>(nullable: true),
                    tag_id = table.Column<int>(nullable: true),
                    asset_id = table.Column<string>(maxLength: 50, nullable: true),
                    is_active = table.Column<bool>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Associations_ReadersInventory_reader_id",
                        column: x => x.reader_id,
                        principalTable: "ReadersInventory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Associations_TagsInventory_tag_id",
                        column: x => x.tag_id,
                        principalTable: "TagsInventory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReadingRPASFlux",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    readtime = table.Column<DateTime>(maxLength: 100, nullable: false),
                    epc = table.Column<string>(maxLength: 50, nullable: true),
                    association_id = table.Column<int>(nullable: true),
                    asset_status = table.Column<string>(maxLength: 50, nullable: true),
                    is_active = table.Column<bool>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingRPASFlux", x => x.id);
                    table.ForeignKey(
                        name: "FK_ReadingRPASFlux_Associations_association_id",
                        column: x => x.association_id,
                        principalTable: "Associations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReadingTagsFlux",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    readtime = table.Column<DateTime>(nullable: false),
                    reader_id = table.Column<int>(nullable: true),
                    association_id = table.Column<int>(nullable: true),
                    is_active = table.Column<bool>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingTagsFlux", x => x.id);
                    table.ForeignKey(
                        name: "FK_ReadingTagsFlux_Associations_association_id",
                        column: x => x.association_id,
                        principalTable: "Associations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReadingTagsFlux_ReadersInventory_reader_id",
                        column: x => x.reader_id,
                        principalTable: "ReadersInventory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TimeSpent",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    minutes_log = table.Column<int>(nullable: true),
                    association_id = table.Column<int>(nullable: true),
                    reader_id = table.Column<int>(nullable: true),
                    status_log = table.Column<string>(nullable: true),
                    is_active = table.Column<bool>(maxLength: 50, nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSpent", x => x.id);
                    table.ForeignKey(
                        name: "FK_TimeSpent_Associations_association_id",
                        column: x => x.association_id,
                        principalTable: "Associations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TimeSpent_ReadersInventory_reader_id",
                        column: x => x.reader_id,
                        principalTable: "ReadersInventory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Associations_reader_id",
                table: "Associations",
                column: "reader_id");

            migrationBuilder.CreateIndex(
                name: "IX_Associations_tag_id",
                table: "Associations",
                column: "tag_id");

            migrationBuilder.CreateIndex(
                name: "IX_ReadersInventory_location_id",
                table: "ReadersInventory",
                column: "location_id");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingRPASFlux_association_id",
                table: "ReadingRPASFlux",
                column: "association_id");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingTagsFlux_association_id",
                table: "ReadingTagsFlux",
                column: "association_id");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingTagsFlux_reader_id",
                table: "ReadingTagsFlux",
                column: "reader_id");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSpent_association_id",
                table: "TimeSpent",
                column: "association_id");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSpent_reader_id",
                table: "TimeSpent",
                column: "reader_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReadingRPASFlux");

            migrationBuilder.DropTable(
                name: "ReadingTagsFlux");

            migrationBuilder.DropTable(
                name: "RFIDNotifications");

            migrationBuilder.DropTable(
                name: "RFIDSysStatus");

            migrationBuilder.DropTable(
                name: "TimeSpent");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Associations");

            migrationBuilder.DropTable(
                name: "ReadersInventory");

            migrationBuilder.DropTable(
                name: "TagsInventory");

            migrationBuilder.DropTable(
                name: "RFIDLocations");
        }
    }
}
