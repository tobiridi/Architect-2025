using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labo_Agence_Voyage.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RenameReservationFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations_ReservationId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Reservations",
                newName: "DestinationId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ReservationId",
                table: "Reservations",
                newName: "IX_Reservations_DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations_DestinationId",
                table: "Reservations",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations_DestinationId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "DestinationId",
                table: "Reservations",
                newName: "ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_DestinationId",
                table: "Reservations",
                newName: "IX_Reservations_ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations_ReservationId",
                table: "Reservations",
                column: "ReservationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
