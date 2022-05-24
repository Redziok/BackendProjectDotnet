using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Strona_internetowa.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    personID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstName = table.Column<string>(type: "text", nullable: true),
                    age = table.Column<int>(type: "integer", nullable: false),
                    height = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<int>(type: "integer", nullable: false),
                    username = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.personID);
                });

            migrationBuilder.CreateTable(
                name: "survey",
                columns: table => new
                {
                    surveyID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    personID = table.Column<int>(type: "integer", nullable: true),
                    work = table.Column<string>(type: "text", nullable: true),
                    hoursWorked = table.Column<string>(type: "text", nullable: true),
                    hoursRelaxed = table.Column<string>(type: "text", nullable: true),
                    activityAmount = table.Column<string>(type: "text", nullable: true),
                    favouriteActivity = table.Column<string>(type: "text", nullable: true),
                    alcoholUsage = table.Column<string>(type: "text", nullable: true),
                    cigaretteUsage = table.Column<string>(type: "text", nullable: true),
                    coffeeUsage = table.Column<string>(type: "text", nullable: true),
                    sleepQuality = table.Column<string>(type: "text", nullable: true),
                    hoursSlept = table.Column<string>(type: "text", nullable: true),
                    energyQuality = table.Column<string>(type: "text", nullable: true),
                    medicationIntake = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_survey", x => x.surveyID);
                    table.ForeignKey(
                        name: "FK_survey_person_personID",
                        column: x => x.personID,
                        principalTable: "person",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "allergy",
                columns: table => new
                {
                    allergyID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    allergyName = table.Column<string>(type: "text", nullable: true),
                    surveyID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allergy", x => x.allergyID);
                    table.ForeignKey(
                        name: "FK_allergy_survey_surveyID",
                        column: x => x.surveyID,
                        principalTable: "survey",
                        principalColumn: "surveyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "foodAvoided",
                columns: table => new
                {
                    foodAvoidedID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    foodAvoidedName = table.Column<string>(type: "text", nullable: true),
                    surveyID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodAvoided", x => x.foodAvoidedID);
                    table.ForeignKey(
                        name: "FK_foodAvoided_survey_surveyID",
                        column: x => x.surveyID,
                        principalTable: "survey",
                        principalColumn: "surveyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "healthProblem",
                columns: table => new
                {
                    healthProblemID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    healthProblemName = table.Column<string>(type: "text", nullable: true),
                    surveyID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_healthProblem", x => x.healthProblemID);
                    table.ForeignKey(
                        name: "FK_healthProblem_survey_surveyID",
                        column: x => x.surveyID,
                        principalTable: "survey",
                        principalColumn: "surveyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sickness",
                columns: table => new
                {
                    sicknessID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sicknessName = table.Column<string>(type: "text", nullable: true),
                    surveyID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sickness", x => x.sicknessID);
                    table.ForeignKey(
                        name: "FK_sickness_survey_surveyID",
                        column: x => x.surveyID,
                        principalTable: "survey",
                        principalColumn: "surveyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_allergy_surveyID",
                table: "allergy",
                column: "surveyID");

            migrationBuilder.CreateIndex(
                name: "IX_foodAvoided_surveyID",
                table: "foodAvoided",
                column: "surveyID");

            migrationBuilder.CreateIndex(
                name: "IX_healthProblem_surveyID",
                table: "healthProblem",
                column: "surveyID");

            migrationBuilder.CreateIndex(
                name: "IX_sickness_surveyID",
                table: "sickness",
                column: "surveyID");

            migrationBuilder.CreateIndex(
                name: "IX_survey_personID",
                table: "survey",
                column: "personID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "allergy");

            migrationBuilder.DropTable(
                name: "foodAvoided");

            migrationBuilder.DropTable(
                name: "healthProblem");

            migrationBuilder.DropTable(
                name: "sickness");

            migrationBuilder.DropTable(
                name: "survey");

            migrationBuilder.DropTable(
                name: "person");
        }
    }
}
