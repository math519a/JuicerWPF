using Microsoft.EntityFrameworkCore.Migrations;

namespace JuicerLib.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    Influences = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false),
                    Variation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Armours",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    Influences = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false),
                    LinkCount = table.Column<long>(nullable: true),
                    Variation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bases",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    Influences = table.Column<string>(nullable: true),
                    BaseIsShaper = table.Column<bool>(nullable: false),
                    BaseIsElder = table.Column<bool>(nullable: false),
                    BaseItemLevel = table.Column<long>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    StackSize = table.Column<long>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Display = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    StackSize = table.Column<long>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enchantments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    Influences = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false),
                    EnchantMin = table.Column<double>(nullable: true),
                    EnchantMax = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enchantments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flasks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false),
                    Variation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jewels",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jewels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    MapTier = table.Column<long>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false),
                    MapSeries = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prophecies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false),
                    Variation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prophecies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: false),
                    Influences = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Mean = table.Column<double>(nullable: false),
                    Median = table.Column<double>(nullable: false),
                    Mode = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Exalted = table.Column<double>(nullable: false),
                    Total = table.Column<long>(nullable: false),
                    Daily = table.Column<long>(nullable: false),
                    Current = table.Column<long>(nullable: false),
                    Accepted = table.Column<long>(nullable: false),
                    Change = table.Column<double>(nullable: false),
                    LinkCount = table.Column<long>(nullable: true),
                    Variation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Display = table.Column<string>(nullable: true),
                    ItemCategoryModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Categories_ItemCategoryModelId",
                        column: x => x.ItemCategoryModelId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_ItemCategoryModelId",
                table: "Group",
                column: "ItemCategoryModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "Armours");

            migrationBuilder.DropTable(
                name: "Bases");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Enchantments");

            migrationBuilder.DropTable(
                name: "Flasks");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Jewels");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "Prophecies");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
