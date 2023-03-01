using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class gfj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColvoMemory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colvo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColvoMemory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cooler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoolingSystem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfCooling = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoolingSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lineika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YadroName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YadroQuantity = table.Column<int>(type: "int", nullable: false),
                    YadroCapacity = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DVD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Need = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Finished_assembly",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    PURPOSE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRAND = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finished_assembly", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotherBoard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherBoard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NetworkCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Need = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColvoMemory = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfMemory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HddOrSsd = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfMemory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memory = table.Column<int>(type: "int", nullable: false),
                    TypeOfMemory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoiceCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Need = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoiceCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BPFinished_assembly",
                columns: table => new
                {
                    BPId = table.Column<int>(type: "int", nullable: false),
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPFinished_assembly", x => new { x.BPId, x.Finished_assemblyId });
                    table.ForeignKey(
                        name: "FK_BPFinished_assembly_BP_BPId",
                        column: x => x.BPId,
                        principalTable: "BP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BPFinished_assembly_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaseFinished_assembly",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseFinished_assembly", x => new { x.CaseId, x.Finished_assemblyId });
                    table.ForeignKey(
                        name: "FK_CaseFinished_assembly_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseFinished_assembly_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColvoMemoryFinished_assembly",
                columns: table => new
                {
                    ColvoMemoryId = table.Column<int>(type: "int", nullable: false),
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColvoMemoryFinished_assembly", x => new { x.ColvoMemoryId, x.Finished_assemblyId });
                    table.ForeignKey(
                        name: "FK_ColvoMemoryFinished_assembly_ColvoMemory_ColvoMemoryId",
                        column: x => x.ColvoMemoryId,
                        principalTable: "ColvoMemory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColvoMemoryFinished_assembly_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoolerFinished_assembly",
                columns: table => new
                {
                    CoolerId = table.Column<int>(type: "int", nullable: false),
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoolerFinished_assembly", x => new { x.CoolerId, x.Finished_assemblyId });
                    table.ForeignKey(
                        name: "FK_CoolerFinished_assembly_Cooler_CoolerId",
                        column: x => x.CoolerId,
                        principalTable: "Cooler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoolerFinished_assembly_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoolingSystemFinished_assembly",
                columns: table => new
                {
                    CoolingSystemId = table.Column<int>(type: "int", nullable: false),
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoolingSystemFinished_assembly", x => new { x.CoolingSystemId, x.Finished_assemblyId });
                    table.ForeignKey(
                        name: "FK_CoolingSystemFinished_assembly_CoolingSystem_CoolingSystemId",
                        column: x => x.CoolingSystemId,
                        principalTable: "CoolingSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoolingSystemFinished_assembly_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CPUFinished_assembly",
                columns: table => new
                {
                    CPUId = table.Column<int>(type: "int", nullable: false),
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUFinished_assembly", x => new { x.CPUId, x.Finished_assemblyId });
                    table.ForeignKey(
                        name: "FK_CPUFinished_assembly_CPU_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUFinished_assembly_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DVDFinished_assembly",
                columns: table => new
                {
                    DVDId = table.Column<int>(type: "int", nullable: false),
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVDFinished_assembly", x => new { x.DVDId, x.Finished_assemblyId });
                    table.ForeignKey(
                        name: "FK_DVDFinished_assembly_DVD_DVDId",
                        column: x => x.DVDId,
                        principalTable: "DVD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DVDFinished_assembly_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Finished_assemblyMatplata",
                columns: table => new
                {
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false),
                    MatplataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finished_assemblyMatplata", x => new { x.Finished_assemblyId, x.MatplataId });
                    table.ForeignKey(
                        name: "FK_Finished_assemblyMatplata_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Finished_assemblyMatplata_MotherBoard_MatplataId",
                        column: x => x.MatplataId,
                        principalTable: "MotherBoard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Finished_assemblyNetworkCard",
                columns: table => new
                {
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false),
                    NetworkCardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finished_assemblyNetworkCard", x => new { x.Finished_assemblyId, x.NetworkCardId });
                    table.ForeignKey(
                        name: "FK_Finished_assemblyNetworkCard_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Finished_assemblyNetworkCard_NetworkCard_NetworkCardId",
                        column: x => x.NetworkCardId,
                        principalTable: "NetworkCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Finished_assemblyRAM",
                columns: table => new
                {
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false),
                    RAMId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finished_assemblyRAM", x => new { x.Finished_assemblyId, x.RAMId });
                    table.ForeignKey(
                        name: "FK_Finished_assemblyRAM_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Finished_assemblyRAM_RAM_RAMId",
                        column: x => x.RAMId,
                        principalTable: "RAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Finished_assemblyTypeOfMemory",
                columns: table => new
                {
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false),
                    TypeOfMemoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finished_assemblyTypeOfMemory", x => new { x.Finished_assemblyId, x.TypeOfMemoryId });
                    table.ForeignKey(
                        name: "FK_Finished_assemblyTypeOfMemory_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Finished_assemblyTypeOfMemory_TypeOfMemory_TypeOfMemoryId",
                        column: x => x.TypeOfMemoryId,
                        principalTable: "TypeOfMemory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Finished_assemblyGPU",
                columns: table => new
                {
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false),
                    GPUId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finished_assemblyGPU", x => new { x.Finished_assemblyId, x.GPUId });
                    table.ForeignKey(
                        name: "FK_Finished_assemblyGPU_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Finished_assemblyGPU_VideoCard_GPUId",
                        column: x => x.GPUId,
                        principalTable: "VideoCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Finished_assemblyVoiceCard",
                columns: table => new
                {
                    Finished_assemblyId = table.Column<int>(type: "int", nullable: false),
                    VoiceCardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finished_assemblyVoiceCard", x => new { x.Finished_assemblyId, x.VoiceCardId });
                    table.ForeignKey(
                        name: "FK_Finished_assemblyVoiceCard_Finished_assembly_Finished_assemblyId",
                        column: x => x.Finished_assemblyId,
                        principalTable: "Finished_assembly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Finished_assemblyVoiceCard_VoiceCard_VoiceCardId",
                        column: x => x.VoiceCardId,
                        principalTable: "VoiceCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BPFinished_assembly_Finished_assemblyId",
                table: "BPFinished_assembly",
                column: "Finished_assemblyId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFinished_assembly_Finished_assemblyId",
                table: "CaseFinished_assembly",
                column: "Finished_assemblyId");

            migrationBuilder.CreateIndex(
                name: "IX_ColvoMemoryFinished_assembly_Finished_assemblyId",
                table: "ColvoMemoryFinished_assembly",
                column: "Finished_assemblyId");

            migrationBuilder.CreateIndex(
                name: "IX_CoolerFinished_assembly_Finished_assemblyId",
                table: "CoolerFinished_assembly",
                column: "Finished_assemblyId");

            migrationBuilder.CreateIndex(
                name: "IX_CoolingSystemFinished_assembly_Finished_assemblyId",
                table: "CoolingSystemFinished_assembly",
                column: "Finished_assemblyId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUFinished_assembly_Finished_assemblyId",
                table: "CPUFinished_assembly",
                column: "Finished_assemblyId");

            migrationBuilder.CreateIndex(
                name: "IX_DVDFinished_assembly_Finished_assemblyId",
                table: "DVDFinished_assembly",
                column: "Finished_assemblyId");

            migrationBuilder.CreateIndex(
                name: "IX_Finished_assemblyGPU_GPUId",
                table: "Finished_assemblyGPU",
                column: "GPUId");

            migrationBuilder.CreateIndex(
                name: "IX_Finished_assemblyMatplata_MatplataId",
                table: "Finished_assemblyMatplata",
                column: "MatplataId");

            migrationBuilder.CreateIndex(
                name: "IX_Finished_assemblyNetworkCard_NetworkCardId",
                table: "Finished_assemblyNetworkCard",
                column: "NetworkCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Finished_assemblyRAM_RAMId",
                table: "Finished_assemblyRAM",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_Finished_assemblyTypeOfMemory_TypeOfMemoryId",
                table: "Finished_assemblyTypeOfMemory",
                column: "TypeOfMemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Finished_assemblyVoiceCard_VoiceCardId",
                table: "Finished_assemblyVoiceCard",
                column: "VoiceCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BPFinished_assembly");

            migrationBuilder.DropTable(
                name: "CaseFinished_assembly");

            migrationBuilder.DropTable(
                name: "ColvoMemoryFinished_assembly");

            migrationBuilder.DropTable(
                name: "CoolerFinished_assembly");

            migrationBuilder.DropTable(
                name: "CoolingSystemFinished_assembly");

            migrationBuilder.DropTable(
                name: "CPUFinished_assembly");

            migrationBuilder.DropTable(
                name: "DVDFinished_assembly");

            migrationBuilder.DropTable(
                name: "Finished_assemblyGPU");

            migrationBuilder.DropTable(
                name: "Finished_assemblyMatplata");

            migrationBuilder.DropTable(
                name: "Finished_assemblyNetworkCard");

            migrationBuilder.DropTable(
                name: "Finished_assemblyRAM");

            migrationBuilder.DropTable(
                name: "Finished_assemblyTypeOfMemory");

            migrationBuilder.DropTable(
                name: "Finished_assemblyVoiceCard");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BP");

            migrationBuilder.DropTable(
                name: "Case");

            migrationBuilder.DropTable(
                name: "ColvoMemory");

            migrationBuilder.DropTable(
                name: "Cooler");

            migrationBuilder.DropTable(
                name: "CoolingSystem");

            migrationBuilder.DropTable(
                name: "CPU");

            migrationBuilder.DropTable(
                name: "DVD");

            migrationBuilder.DropTable(
                name: "VideoCard");

            migrationBuilder.DropTable(
                name: "MotherBoard");

            migrationBuilder.DropTable(
                name: "NetworkCard");

            migrationBuilder.DropTable(
                name: "RAM");

            migrationBuilder.DropTable(
                name: "TypeOfMemory");

            migrationBuilder.DropTable(
                name: "Finished_assembly");

            migrationBuilder.DropTable(
                name: "VoiceCard");
        }
    }
}
