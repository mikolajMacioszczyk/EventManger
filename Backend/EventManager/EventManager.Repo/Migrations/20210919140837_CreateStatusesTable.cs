using Microsoft.EntityFrameworkCore.Migrations;

namespace EventManager.Repo.Migrations
{
    public partial class CreateStatusesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffers_Employees_EmployeeId",
                table: "JobOffers");

            migrationBuilder.DropIndex(
                name: "IX_JobOffers_EmployeeId",
                table: "JobOffers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "JobOffers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "JobOffers");

            migrationBuilder.CreateTable(
                name: "JobOfferStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    JobOfferId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOfferStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobOfferStatuses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobOfferStatuses_JobOffers_JobOfferId",
                        column: x => x.JobOfferId,
                        principalTable: "JobOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobOfferStatuses_EmployeeId",
                table: "JobOfferStatuses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOfferStatuses_JobOfferId",
                table: "JobOfferStatuses",
                column: "JobOfferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobOfferStatuses");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "JobOffers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "JobOffers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_EmployeeId",
                table: "JobOffers",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffers_Employees_EmployeeId",
                table: "JobOffers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
