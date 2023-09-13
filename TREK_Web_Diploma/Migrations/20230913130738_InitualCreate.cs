using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TREK_Web_Diploma.Migrations
{
    /// <inheritdoc />
    public partial class InitualCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "production");

            migrationBuilder.EnsureSchema(
                name: "sparesFrameset");

            migrationBuilder.EnsureSchema(
                name: "sparesEquipment");

            migrationBuilder.EnsureSchema(
                name: "sparesGroopset");

            migrationBuilder.EnsureSchema(
                name: "sparesTransmition");

            migrationBuilder.EnsureSchema(
                name: "factory");

            migrationBuilder.EnsureSchema(
                name: "sparesWheelset");

            migrationBuilder.CreateTable(
                name: "BikeSize",
                schema: "sparesFrameset",
                columns: table => new
                {
                    BikeSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BikeSizeName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeSize", x => x.BikeSizeId);
                });

            migrationBuilder.CreateTable(
                name: "Brake",
                schema: "sparesEquipment",
                columns: table => new
                {
                    BrakeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrakeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    BrakeQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brake", x => x.BrakeId);
                });

            migrationBuilder.CreateTable(
                name: "Carriage",
                schema: "sparesGroopset",
                columns: table => new
                {
                    CarriageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarriageName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CarriageQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carriage", x => x.CarriageId);
                });

            migrationBuilder.CreateTable(
                name: "Cassette",
                schema: "sparesTransmition",
                columns: table => new
                {
                    CassetteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CassetteName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CassetteQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cassette", x => x.CassetteId);
                });

            migrationBuilder.CreateTable(
                name: "Factory",
                schema: "factory",
                columns: table => new
                {
                    FactoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factory", x => x.FactoryId);
                });

            migrationBuilder.CreateTable(
                name: "Fork",
                schema: "sparesFrameset",
                columns: table => new
                {
                    ForkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForkName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ForkDescription = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ForkQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fork", x => x.ForkId);
                });

            migrationBuilder.CreateTable(
                name: "Frame",
                schema: "sparesFrameset",
                columns: table => new
                {
                    FrameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrameName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    FrameDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FrameQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame", x => x.FrameId);
                });

            migrationBuilder.CreateTable(
                name: "FrontGear",
                schema: "sparesTransmition",
                columns: table => new
                {
                    FrontGearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrontGearName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    FrontGearQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrontGear", x => x.FrontGearId);
                });

            migrationBuilder.CreateTable(
                name: "Grips",
                schema: "sparesEquipment",
                columns: table => new
                {
                    GripsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GripsName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    GripsQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grips", x => x.GripsId);
                });

            migrationBuilder.CreateTable(
                name: "Handlebar",
                schema: "sparesEquipment",
                columns: table => new
                {
                    HandlbarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HandlbarName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    HandlebarQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Handlebar", x => x.HandlbarId);
                });

            migrationBuilder.CreateTable(
                name: "Hub",
                schema: "sparesWheelset",
                columns: table => new
                {
                    HubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HubName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    HubDescription = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    HubQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hub", x => x.HubId);
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                schema: "factory",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitleName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.JobTitleId);
                });

            migrationBuilder.CreateTable(
                name: "Pedals",
                schema: "sparesGroopset",
                columns: table => new
                {
                    PedalsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedalsName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    PedalsQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedals", x => x.PedalsId);
                });

            migrationBuilder.CreateTable(
                name: "Rim",
                schema: "sparesWheelset",
                columns: table => new
                {
                    RimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RimName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    RimDescription = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    RimQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rim", x => x.RimId);
                });

            migrationBuilder.CreateTable(
                name: "Saddle",
                schema: "sparesEquipment",
                columns: table => new
                {
                    SaddleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaddleName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SaddleQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saddle", x => x.SaddleId);
                });

            migrationBuilder.CreateTable(
                name: "SeatPost",
                schema: "sparesEquipment",
                columns: table => new
                {
                    SeatPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatPostName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SeatPostQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatPost", x => x.SeatPostId);
                });

            migrationBuilder.CreateTable(
                name: "Shifter",
                schema: "sparesTransmition",
                columns: table => new
                {
                    ShifterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShifterName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ShifterQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifter", x => x.ShifterId);
                });

            migrationBuilder.CreateTable(
                name: "Steering",
                schema: "sparesEquipment",
                columns: table => new
                {
                    SteeringId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SteeringName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SteeringQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steering", x => x.SteeringId);
                });

            migrationBuilder.CreateTable(
                name: "Stem",
                schema: "sparesEquipment",
                columns: table => new
                {
                    StemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StemName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    StemQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stem", x => x.StemId);
                });

            migrationBuilder.CreateTable(
                name: "Switch",
                schema: "sparesTransmition",
                columns: table => new
                {
                    SwitchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SwitchName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SwitchQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Switch", x => x.SwitchId);
                });

            migrationBuilder.CreateTable(
                name: "Tire",
                schema: "sparesWheelset",
                columns: table => new
                {
                    TireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TireName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TireDescription = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TireQuantity = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tire", x => x.TireId);
                });

            migrationBuilder.CreateTable(
                name: "Frameset",
                schema: "production",
                columns: table => new
                {
                    FramesetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BikeSizeId = table.Column<int>(type: "int", nullable: false),
                    FrameId = table.Column<int>(type: "int", nullable: false),
                    ForkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frameset", x => x.FramesetId);
                    table.ForeignKey(
                        name: "FK_Frameset_BikeSize_BikeSizeId",
                        column: x => x.BikeSizeId,
                        principalSchema: "sparesFrameset",
                        principalTable: "BikeSize",
                        principalColumn: "BikeSizeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Frameset_Fork_ForkId",
                        column: x => x.ForkId,
                        principalSchema: "sparesFrameset",
                        principalTable: "Fork",
                        principalColumn: "ForkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Frameset_Frame_FrameId",
                        column: x => x.FrameId,
                        principalSchema: "sparesFrameset",
                        principalTable: "Frame",
                        principalColumn: "FrameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                schema: "factory",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    FactoryId = table.Column<int>(type: "int", nullable: false),
                    JobTitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staff_Factory_FactoryId",
                        column: x => x.FactoryId,
                        principalSchema: "factory",
                        principalTable: "Factory",
                        principalColumn: "FactoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_JobTitle_JobTitleId",
                        column: x => x.JobTitleId,
                        principalSchema: "factory",
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                schema: "production",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrakeId = table.Column<int>(type: "int", nullable: false),
                    SaddleId = table.Column<int>(type: "int", nullable: false),
                    SeatPostId = table.Column<int>(type: "int", nullable: false),
                    StemId = table.Column<int>(type: "int", nullable: false),
                    HandlebarId = table.Column<int>(type: "int", nullable: false),
                    GripsId = table.Column<int>(type: "int", nullable: false),
                    SteeringId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentId);
                    table.ForeignKey(
                        name: "FK_Equipment_Brake_BrakeId",
                        column: x => x.BrakeId,
                        principalSchema: "sparesEquipment",
                        principalTable: "Brake",
                        principalColumn: "BrakeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Grips_GripsId",
                        column: x => x.GripsId,
                        principalSchema: "sparesEquipment",
                        principalTable: "Grips",
                        principalColumn: "GripsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Handlebar_HandlebarId",
                        column: x => x.HandlebarId,
                        principalSchema: "sparesEquipment",
                        principalTable: "Handlebar",
                        principalColumn: "HandlbarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Saddle_SaddleId",
                        column: x => x.SaddleId,
                        principalSchema: "sparesEquipment",
                        principalTable: "Saddle",
                        principalColumn: "SaddleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_SeatPost_SeatPostId",
                        column: x => x.SeatPostId,
                        principalSchema: "sparesEquipment",
                        principalTable: "SeatPost",
                        principalColumn: "SeatPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Steering_SteeringId",
                        column: x => x.SteeringId,
                        principalSchema: "sparesEquipment",
                        principalTable: "Steering",
                        principalColumn: "SteeringId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Stem_StemId",
                        column: x => x.StemId,
                        principalSchema: "sparesEquipment",
                        principalTable: "Stem",
                        principalColumn: "StemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transmition",
                schema: "sparesGroopset",
                columns: table => new
                {
                    TransmitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CassetteId = table.Column<int>(type: "int", nullable: false),
                    SwitchId = table.Column<int>(type: "int", nullable: false),
                    ShifterId = table.Column<int>(type: "int", nullable: false),
                    FrontGearId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmition", x => x.TransmitionId);
                    table.ForeignKey(
                        name: "FK_Transmition_Cassette_CassetteId",
                        column: x => x.CassetteId,
                        principalSchema: "sparesTransmition",
                        principalTable: "Cassette",
                        principalColumn: "CassetteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transmition_FrontGear_FrontGearId",
                        column: x => x.FrontGearId,
                        principalSchema: "sparesTransmition",
                        principalTable: "FrontGear",
                        principalColumn: "FrontGearId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transmition_Shifter_ShifterId",
                        column: x => x.ShifterId,
                        principalSchema: "sparesTransmition",
                        principalTable: "Shifter",
                        principalColumn: "ShifterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transmition_Switch_SwitchId",
                        column: x => x.SwitchId,
                        principalSchema: "sparesTransmition",
                        principalTable: "Switch",
                        principalColumn: "SwitchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wheelset",
                schema: "production",
                columns: table => new
                {
                    WheelsetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HubId = table.Column<int>(type: "int", nullable: false),
                    RimId = table.Column<int>(type: "int", nullable: false),
                    TireId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheelset", x => x.WheelsetId);
                    table.ForeignKey(
                        name: "FK_Wheelset_Hub_HubId",
                        column: x => x.HubId,
                        principalSchema: "sparesWheelset",
                        principalTable: "Hub",
                        principalColumn: "HubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wheelset_Rim_RimId",
                        column: x => x.RimId,
                        principalSchema: "sparesWheelset",
                        principalTable: "Rim",
                        principalColumn: "RimId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wheelset_Tire_TireId",
                        column: x => x.TireId,
                        principalSchema: "sparesWheelset",
                        principalTable: "Tire",
                        principalColumn: "TireId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroopSet",
                schema: "production",
                columns: table => new
                {
                    GroopsetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransmitionId = table.Column<int>(type: "int", nullable: false),
                    CarriageId = table.Column<int>(type: "int", nullable: false),
                    PedalsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroopSet", x => x.GroopsetId);
                    table.ForeignKey(
                        name: "FK_GroopSet_Carriage_CarriageId",
                        column: x => x.CarriageId,
                        principalSchema: "sparesGroopset",
                        principalTable: "Carriage",
                        principalColumn: "CarriageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroopSet_Pedals_PedalsId",
                        column: x => x.PedalsId,
                        principalSchema: "sparesGroopset",
                        principalTable: "Pedals",
                        principalColumn: "PedalsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroopSet_Transmition_TransmitionId",
                        column: x => x.TransmitionId,
                        principalSchema: "sparesGroopset",
                        principalTable: "Transmition",
                        principalColumn: "TransmitionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bike",
                schema: "production",
                columns: table => new
                {
                    BikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BikeName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    BikeImage = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    BikeDescription = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    BikePrice = table.Column<int>(type: "int", maxLength: 16, nullable: false),
                    BikeWeight = table.Column<double>(type: "float", maxLength: 16, nullable: false),
                    FramesetId = table.Column<int>(type: "int", nullable: false),
                    WheelsetId = table.Column<int>(type: "int", nullable: false),
                    GroopsetId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    TypeOfBike = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bike", x => x.BikeId);
                    table.ForeignKey(
                        name: "FK_Bike_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalSchema: "production",
                        principalTable: "Equipment",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bike_Frameset_FramesetId",
                        column: x => x.FramesetId,
                        principalSchema: "production",
                        principalTable: "Frameset",
                        principalColumn: "FramesetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bike_GroopSet_GroopsetId",
                        column: x => x.GroopsetId,
                        principalSchema: "production",
                        principalTable: "GroopSet",
                        principalColumn: "GroopsetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bike_Wheelset_WheelsetId",
                        column: x => x.WheelsetId,
                        principalSchema: "production",
                        principalTable: "Wheelset",
                        principalColumn: "WheelsetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bike_EquipmentId",
                schema: "production",
                table: "Bike",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bike_FramesetId",
                schema: "production",
                table: "Bike",
                column: "FramesetId");

            migrationBuilder.CreateIndex(
                name: "IX_Bike_GroopsetId",
                schema: "production",
                table: "Bike",
                column: "GroopsetId");

            migrationBuilder.CreateIndex(
                name: "IX_Bike_WheelsetId",
                schema: "production",
                table: "Bike",
                column: "WheelsetId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_BrakeId",
                schema: "production",
                table: "Equipment",
                column: "BrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_GripsId",
                schema: "production",
                table: "Equipment",
                column: "GripsId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_HandlebarId",
                schema: "production",
                table: "Equipment",
                column: "HandlebarId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_SaddleId",
                schema: "production",
                table: "Equipment",
                column: "SaddleId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_SeatPostId",
                schema: "production",
                table: "Equipment",
                column: "SeatPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_SteeringId",
                schema: "production",
                table: "Equipment",
                column: "SteeringId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_StemId",
                schema: "production",
                table: "Equipment",
                column: "StemId");

            migrationBuilder.CreateIndex(
                name: "IX_Frameset_BikeSizeId",
                schema: "production",
                table: "Frameset",
                column: "BikeSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Frameset_ForkId",
                schema: "production",
                table: "Frameset",
                column: "ForkId");

            migrationBuilder.CreateIndex(
                name: "IX_Frameset_FrameId",
                schema: "production",
                table: "Frameset",
                column: "FrameId");

            migrationBuilder.CreateIndex(
                name: "IX_GroopSet_CarriageId",
                schema: "production",
                table: "GroopSet",
                column: "CarriageId");

            migrationBuilder.CreateIndex(
                name: "IX_GroopSet_PedalsId",
                schema: "production",
                table: "GroopSet",
                column: "PedalsId");

            migrationBuilder.CreateIndex(
                name: "IX_GroopSet_TransmitionId",
                schema: "production",
                table: "GroopSet",
                column: "TransmitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_FactoryId",
                schema: "factory",
                table: "Staff",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_JobTitleId",
                schema: "factory",
                table: "Staff",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmition_CassetteId",
                schema: "sparesGroopset",
                table: "Transmition",
                column: "CassetteId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmition_FrontGearId",
                schema: "sparesGroopset",
                table: "Transmition",
                column: "FrontGearId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmition_ShifterId",
                schema: "sparesGroopset",
                table: "Transmition",
                column: "ShifterId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmition_SwitchId",
                schema: "sparesGroopset",
                table: "Transmition",
                column: "SwitchId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheelset_HubId",
                schema: "production",
                table: "Wheelset",
                column: "HubId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheelset_RimId",
                schema: "production",
                table: "Wheelset",
                column: "RimId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheelset_TireId",
                schema: "production",
                table: "Wheelset",
                column: "TireId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bike",
                schema: "production");

            migrationBuilder.DropTable(
                name: "Staff",
                schema: "factory");

            migrationBuilder.DropTable(
                name: "Equipment",
                schema: "production");

            migrationBuilder.DropTable(
                name: "Frameset",
                schema: "production");

            migrationBuilder.DropTable(
                name: "GroopSet",
                schema: "production");

            migrationBuilder.DropTable(
                name: "Wheelset",
                schema: "production");

            migrationBuilder.DropTable(
                name: "Factory",
                schema: "factory");

            migrationBuilder.DropTable(
                name: "JobTitle",
                schema: "factory");

            migrationBuilder.DropTable(
                name: "Brake",
                schema: "sparesEquipment");

            migrationBuilder.DropTable(
                name: "Grips",
                schema: "sparesEquipment");

            migrationBuilder.DropTable(
                name: "Handlebar",
                schema: "sparesEquipment");

            migrationBuilder.DropTable(
                name: "Saddle",
                schema: "sparesEquipment");

            migrationBuilder.DropTable(
                name: "SeatPost",
                schema: "sparesEquipment");

            migrationBuilder.DropTable(
                name: "Steering",
                schema: "sparesEquipment");

            migrationBuilder.DropTable(
                name: "Stem",
                schema: "sparesEquipment");

            migrationBuilder.DropTable(
                name: "BikeSize",
                schema: "sparesFrameset");

            migrationBuilder.DropTable(
                name: "Fork",
                schema: "sparesFrameset");

            migrationBuilder.DropTable(
                name: "Frame",
                schema: "sparesFrameset");

            migrationBuilder.DropTable(
                name: "Carriage",
                schema: "sparesGroopset");

            migrationBuilder.DropTable(
                name: "Pedals",
                schema: "sparesGroopset");

            migrationBuilder.DropTable(
                name: "Transmition",
                schema: "sparesGroopset");

            migrationBuilder.DropTable(
                name: "Hub",
                schema: "sparesWheelset");

            migrationBuilder.DropTable(
                name: "Rim",
                schema: "sparesWheelset");

            migrationBuilder.DropTable(
                name: "Tire",
                schema: "sparesWheelset");

            migrationBuilder.DropTable(
                name: "Cassette",
                schema: "sparesTransmition");

            migrationBuilder.DropTable(
                name: "FrontGear",
                schema: "sparesTransmition");

            migrationBuilder.DropTable(
                name: "Shifter",
                schema: "sparesTransmition");

            migrationBuilder.DropTable(
                name: "Switch",
                schema: "sparesTransmition");
        }
    }
}
