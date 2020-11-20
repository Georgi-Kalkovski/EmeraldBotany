using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmeraldBotany.Data.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AverageHeights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Cm = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AverageHeights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foliages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    LeafRetention = table.Column<bool>(nullable: true),
                    Texture = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foliages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FruitsOrSeeds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Conspicuous = table.Column<bool>(nullable: true),
                    Shape = table.Column<string>(nullable: true),
                    SeedPersistence = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruitsOrSeeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaximumHeights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Cm = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaximumHeights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaximumPrecipitations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Mm = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaximumPrecipitations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaximumTemperatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DegF = table.Column<double>(nullable: true),
                    DegC = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaximumTemperatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MinimumPrecipitations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Mm = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinimumPrecipitations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MinimumRootDepths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Cm = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinimumRootDepths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MinimumTemperatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DegF = table.Column<double>(nullable: true),
                    DegC = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinimumTemperatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RowSpacings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Cm = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RowSpacings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spreads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Cm = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spreads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Barks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Copyright = table.Column<string>(nullable: true),
                    ImagesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barks_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Flowers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Conspicuous = table.Column<bool>(nullable: true),
                    ImagesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flowers_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fruits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Copyright = table.Column<string>(nullable: true),
                    ImagesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fruits_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Habits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Copyright = table.Column<string>(nullable: true),
                    ImagesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habits_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Leafs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Copyright = table.Column<string>(nullable: true),
                    ImagesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leafs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leafs_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Others",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Copyright = table.Column<string>(nullable: true),
                    ImagesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Others", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Others_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    GrowthForm = table.Column<string>(nullable: true),
                    GrowthHabit = table.Column<string>(nullable: true),
                    GrowthRate = table.Column<string>(nullable: true),
                    NitrogenFixation = table.Column<string>(nullable: true),
                    ShapeAndOrientation = table.Column<string>(nullable: true),
                    AverageHeightId = table.Column<int>(nullable: true),
                    MaximumHeightId = table.Column<int>(nullable: true),
                    LigneousType = table.Column<int>(nullable: true),
                    Toxicity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specifications_AverageHeights_AverageHeightId",
                        column: x => x.AverageHeightId,
                        principalTable: "AverageHeights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Specifications_MaximumHeights_MaximumHeightId",
                        column: x => x.MaximumHeightId,
                        principalTable: "MaximumHeights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Growths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DaysToHarvest = table.Column<double>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Sowing = table.Column<string>(nullable: true),
                    PhMaximum = table.Column<double>(nullable: true),
                    PhMinimum = table.Column<double>(nullable: true),
                    Light = table.Column<int>(nullable: true),
                    AtmosphericHumidity = table.Column<int>(nullable: true),
                    SoilNutriments = table.Column<int>(nullable: true),
                    SoilSalinity = table.Column<int>(nullable: true),
                    SoilTexture = table.Column<int>(nullable: true),
                    SoilHumidity = table.Column<int>(nullable: true),
                    RowSpacingId = table.Column<int>(nullable: true),
                    SpreadId = table.Column<int>(nullable: true),
                    MinimumPrecipitationId = table.Column<int>(nullable: true),
                    MaximumPrecipitationId = table.Column<int>(nullable: true),
                    MinimumRootDepthId = table.Column<int>(nullable: true),
                    MinimumTemperatureId = table.Column<int>(nullable: true),
                    MaximumTemperatureId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Growths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Growths_MaximumPrecipitations_MaximumPrecipitationId",
                        column: x => x.MaximumPrecipitationId,
                        principalTable: "MaximumPrecipitations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Growths_MaximumTemperatures_MaximumTemperatureId",
                        column: x => x.MaximumTemperatureId,
                        principalTable: "MaximumTemperatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Growths_MinimumPrecipitations_MinimumPrecipitationId",
                        column: x => x.MinimumPrecipitationId,
                        principalTable: "MinimumPrecipitations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Growths_MinimumRootDepths_MinimumRootDepthId",
                        column: x => x.MinimumRootDepthId,
                        principalTable: "MinimumRootDepths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Growths_MinimumTemperatures_MinimumTemperatureId",
                        column: x => x.MinimumTemperatureId,
                        principalTable: "MinimumTemperatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Growths_RowSpacings_RowSpacingId",
                        column: x => x.RowSpacingId,
                        principalTable: "RowSpacings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Growths_Spreads_SpreadId",
                        column: x => x.SpreadId,
                        principalTable: "Spreads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CommonName = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    ScientificName = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    Bibliography = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    FamilyCommonName = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    GenusId = table.Column<int>(nullable: true),
                    Genus = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Vegetable = table.Column<bool>(nullable: true),
                    Observations = table.Column<string>(nullable: true),
                    ImagesId = table.Column<int>(nullable: true),
                    FlowerId = table.Column<int>(nullable: true),
                    FoliageId = table.Column<int>(nullable: true),
                    FruitOrSeedId = table.Column<int>(nullable: true),
                    SpecificationsId = table.Column<int>(nullable: true),
                    GrowthId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Rank = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Species_Flowers_FlowerId",
                        column: x => x.FlowerId,
                        principalTable: "Flowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Species_Foliages_FoliageId",
                        column: x => x.FoliageId,
                        principalTable: "Foliages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Species_FruitsOrSeeds_FruitOrSeedId",
                        column: x => x.FruitOrSeedId,
                        principalTable: "FruitsOrSeeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Species_Growths_GrowthId",
                        column: x => x.GrowthId,
                        principalTable: "Growths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Species_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Species_Specifications_SpecificationsId",
                        column: x => x.SpecificationsId,
                        principalTable: "Specifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CommonName = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    ScientificName = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    Bibliography = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    FamilyCommonName = table.Column<string>(nullable: true),
                    GenusId = table.Column<int>(nullable: false),
                    Vegetable = table.Column<bool>(nullable: true),
                    Observations = table.Column<string>(nullable: true),
                    MainSpeciesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plants_Species_MainSpeciesId",
                        column: x => x.MainSpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<string>(nullable: true),
                    SpeciesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sources_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Synonyms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    SpeciesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Synonyms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Synonyms_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true),
                    PlantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Source_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_IsDeleted",
                table: "AspNetRoles",
                column: "IsDeleted");

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
                name: "IX_AspNetUsers_IsDeleted",
                table: "AspNetUsers",
                column: "IsDeleted");

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
                name: "IX_AverageHeights_IsDeleted",
                table: "AverageHeights",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Barks_ImagesId",
                table: "Barks",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Barks_IsDeleted",
                table: "Barks",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Flowers_ImagesId",
                table: "Flowers",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Flowers_IsDeleted",
                table: "Flowers",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Foliages_IsDeleted",
                table: "Foliages",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Fruits_ImagesId",
                table: "Fruits",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Fruits_IsDeleted",
                table: "Fruits",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_FruitsOrSeeds_IsDeleted",
                table: "FruitsOrSeeds",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Growths_IsDeleted",
                table: "Growths",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Growths_MaximumPrecipitationId",
                table: "Growths",
                column: "MaximumPrecipitationId");

            migrationBuilder.CreateIndex(
                name: "IX_Growths_MaximumTemperatureId",
                table: "Growths",
                column: "MaximumTemperatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Growths_MinimumPrecipitationId",
                table: "Growths",
                column: "MinimumPrecipitationId");

            migrationBuilder.CreateIndex(
                name: "IX_Growths_MinimumRootDepthId",
                table: "Growths",
                column: "MinimumRootDepthId");

            migrationBuilder.CreateIndex(
                name: "IX_Growths_MinimumTemperatureId",
                table: "Growths",
                column: "MinimumTemperatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Growths_RowSpacingId",
                table: "Growths",
                column: "RowSpacingId");

            migrationBuilder.CreateIndex(
                name: "IX_Growths_SpreadId",
                table: "Growths",
                column: "SpreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Habits_ImagesId",
                table: "Habits",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Habits_IsDeleted",
                table: "Habits",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Images_IsDeleted",
                table: "Images",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Leafs_ImagesId",
                table: "Leafs",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Leafs_IsDeleted",
                table: "Leafs",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_MaximumHeights_IsDeleted",
                table: "MaximumHeights",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_MaximumPrecipitations_IsDeleted",
                table: "MaximumPrecipitations",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_MaximumTemperatures_IsDeleted",
                table: "MaximumTemperatures",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_MinimumPrecipitations_IsDeleted",
                table: "MinimumPrecipitations",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_MinimumRootDepths_IsDeleted",
                table: "MinimumRootDepths",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_MinimumTemperatures_IsDeleted",
                table: "MinimumTemperatures",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Others_ImagesId",
                table: "Others",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Others_IsDeleted",
                table: "Others",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_IsDeleted",
                table: "Plants",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_MainSpeciesId",
                table: "Plants",
                column: "MainSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_RowSpacings_IsDeleted",
                table: "RowSpacings",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_IsDeleted",
                table: "Settings",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Source_IsDeleted",
                table: "Source",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Source_PlantId",
                table: "Source",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_Sources_IsDeleted",
                table: "Sources",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Sources_SpeciesId",
                table: "Sources",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_FlowerId",
                table: "Species",
                column: "FlowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_FoliageId",
                table: "Species",
                column: "FoliageId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_FruitOrSeedId",
                table: "Species",
                column: "FruitOrSeedId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_GrowthId",
                table: "Species",
                column: "GrowthId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_ImagesId",
                table: "Species",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_IsDeleted",
                table: "Species",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Species_SpecificationsId",
                table: "Species",
                column: "SpecificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Specifications_AverageHeightId",
                table: "Specifications",
                column: "AverageHeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Specifications_IsDeleted",
                table: "Specifications",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Specifications_MaximumHeightId",
                table: "Specifications",
                column: "MaximumHeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Spreads_IsDeleted",
                table: "Spreads",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Synonyms_IsDeleted",
                table: "Synonyms",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Synonyms_SpeciesId",
                table: "Synonyms",
                column: "SpeciesId");
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
                name: "Barks");

            migrationBuilder.DropTable(
                name: "Fruits");

            migrationBuilder.DropTable(
                name: "Habits");

            migrationBuilder.DropTable(
                name: "Leafs");

            migrationBuilder.DropTable(
                name: "Others");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "Synonyms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Flowers");

            migrationBuilder.DropTable(
                name: "Foliages");

            migrationBuilder.DropTable(
                name: "FruitsOrSeeds");

            migrationBuilder.DropTable(
                name: "Growths");

            migrationBuilder.DropTable(
                name: "Specifications");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "MaximumPrecipitations");

            migrationBuilder.DropTable(
                name: "MaximumTemperatures");

            migrationBuilder.DropTable(
                name: "MinimumPrecipitations");

            migrationBuilder.DropTable(
                name: "MinimumRootDepths");

            migrationBuilder.DropTable(
                name: "MinimumTemperatures");

            migrationBuilder.DropTable(
                name: "RowSpacings");

            migrationBuilder.DropTable(
                name: "Spreads");

            migrationBuilder.DropTable(
                name: "AverageHeights");

            migrationBuilder.DropTable(
                name: "MaximumHeights");
        }
    }
}
