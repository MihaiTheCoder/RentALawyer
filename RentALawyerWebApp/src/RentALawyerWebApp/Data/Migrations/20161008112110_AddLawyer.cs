using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentALawyerWebApp.Data.Migrations
{
    public partial class AddLawyer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lawyer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawyer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryLawyer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    LawyerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryLawyer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryLawyer_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryLawyer_Lawyer_LawyerId",
                        column: x => x.LawyerId,
                        principalTable: "Lawyer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryLawyer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: false),
                    LawyerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryLawyer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryLawyer_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryLawyer_Lawyer_LawyerId",
                        column: x => x.LawyerId,
                        principalTable: "Lawyer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageLawyer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(nullable: false),
                    LawyerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageLawyer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageLawyer_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageLawyer_Lawyer_LawyerId",
                        column: x => x.LawyerId,
                        principalTable: "Lawyer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryLawyer_CategoryId",
                table: "CategoryLawyer",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryLawyer_LawyerId",
                table: "CategoryLawyer",
                column: "LawyerId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLawyer_CountryId",
                table: "CountryLawyer",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLawyer_LawyerId",
                table: "CountryLawyer",
                column: "LawyerId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageLawyer_LanguageId",
                table: "LanguageLawyer",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageLawyer_LawyerId",
                table: "LanguageLawyer",
                column: "LawyerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryLawyer");

            migrationBuilder.DropTable(
                name: "CountryLawyer");

            migrationBuilder.DropTable(
                name: "LanguageLawyer");

            migrationBuilder.DropTable(
                name: "Lawyer");
        }
    }
}
