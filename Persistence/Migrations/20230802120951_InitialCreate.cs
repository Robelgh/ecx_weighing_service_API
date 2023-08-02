using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agricultural",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Consignment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Warehouse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Commodity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    License = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceIssued = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TruckPlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerPlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TruckNumberPlomps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerNumberPlomps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Woreda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecficArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductionYear = table.Column<int>(type: "int", nullable: false),
                    NumberOfBags = table.Column<int>(type: "int", nullable: false),
                    VehicleSize = table.Column<double>(type: "float", nullable: false),
                    EstimatedWeight = table.Column<double>(type: "float", nullable: false),
                    GrossWeight = table.Column<double>(type: "float", nullable: false),
                    TicketNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateReceived = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agricultural", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nonagricultural",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    License = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TruckPlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TruckType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeighingItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossWeight = table.Column<double>(type: "float", nullable: false),
                    Warehouse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankSlip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeighbridgeServiceFee = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nonagricultural", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "truck",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Trucktype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_truck", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "agricultural");

            migrationBuilder.DropTable(
                name: "nonagricultural");

            migrationBuilder.DropTable(
                name: "truck");
        }
    }
}
