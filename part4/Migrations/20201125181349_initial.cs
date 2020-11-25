using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace part4.Migrations
{
    public partial class initial : Migration
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
                    ConcurrencyStamp = table.Column<string>(nullable: true)
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
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Upgrade",
                columns: table => new
                {
                    UpgradeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpgradeName = table.Column<string>(nullable: true),
                    UpgradeCategory = table.Column<string>(nullable: true),
                    UpgradePrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upgrade", x => x.UpgradeID);
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
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UpgradePJT",
                columns: table => new
                {
                    UpgradePJTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(nullable: false),
                    UpgradeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpgradePJT", x => x.UpgradePJTID);
                    table.ForeignKey(
                        name: "FK_UpgradePJT_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpgradePJT_Upgrade_UpgradeID",
                        column: x => x.UpgradeID,
                        principalTable: "Upgrade",
                        principalColumn: "UpgradeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "Description", "ImageName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A small and lightweight PC for basic computing tasks.", "mini1.jpg", "The Mini", 599.99m },
                    { 2, "A Business PC for professional applications.", "business1.jpg", "The Business", 799.99m },
                    { 3, "A PC for playing all of the latest and greatest video games.", "gamer1.jpg", "The Gamer", 999.99m }
                });

            migrationBuilder.InsertData(
                table: "Upgrade",
                columns: new[] { "UpgradeID", "UpgradeCategory", "UpgradeName", "UpgradePrice" },
                values: new object[,]
                {
                    { 29, "Video", "Quadro P1000", 550 },
                    { 30, "Sound", "Integrated", 0 },
                    { 31, "Sound", "Sound Blaster 1000", 40 },
                    { 32, "OS", "None", 0 },
                    { 33, "OS", "Ubuntu", 0 },
                    { 34, "OS", "Win 10 Home", 70 },
                    { 35, "OS", "Win 10 Pro", 110 },
                    { 36, "CPU", "i5 9400", 0 },
                    { 37, "CPU", "i5 10400F", 75 },
                    { 38, "CPU", "i7 10700k", 150 },
                    { 39, "Memory", "8 Gb", 0 },
                    { 41, "Memory", "32 Gb", 200 },
                    { 28, "Video", "Quadro P620", 300 },
                    { 42, "Storage", "256 Gb SSD", 60 },
                    { 43, "Storage", "512 Gb SSD", 120 },
                    { 44, "Storage", "1 Tb SSD", 240 },
                    { 45, "Video", "1650 Ti", 0 },
                    { 46, "Video", "1660 Ti", 100 },
                    { 47, "Video", "RTX 2060", 150 },
                    { 48, "Video", "RTX 2070", 300 },
                    { 49, "Sound", "Integrated", 0 },
                    { 50, "Sound", "Sound Blaster 5000", 40 },
                    { 51, "Sound", "Sound Blaster 10000", 100 },
                    { 40, "Memory", "16 Gb", 100 },
                    { 27, "Video", "Integrated", 0 },
                    { 25, "Storage", "512 Gb SSD", 120 },
                    { 52, "OS", "Win 10 Home", 0 },
                    { 1, "CPU", "i3 8130u", 0 },
                    { 2, "CPU", "i5 8250u", 50 },
                    { 3, "CPU", "i7 8550u", 100 },
                    { 4, "Memory", "8 Gb", 0 },
                    { 5, "Memory", "16 Gb", 100 },
                    { 6, "Storage", "1 Tb HDD", 0 },
                    { 7, "Storage", "128 Gb SSD", 0 },
                    { 8, "Storage", "256 Gb SSD", 60 },
                    { 9, "Storage", "512 Gb SSD", 120 },
                    { 10, "Video", "Integrated", 0 },
                    { 11, "Sound", "Integrated", 0 },
                    { 26, "Storage", "1 Tb SSD", 240 },
                    { 12, "OS", "None", 0 },
                    { 14, "OS", "Win 10 Home", 70 },
                    { 15, "CPU", "i3 10100", 0 },
                    { 16, "CPU", "i5 10400", 50 },
                    { 17, "CPU", "i5 10600", 80 },
                    { 18, "CPU", "i7 10700", 140 },
                    { 19, "CPU", "i9 10900", 200 },
                    { 20, "Memory", "8 Gb", 0 },
                    { 21, "Memory", "16 Gb", 100 },
                    { 22, "Memory", "32 Gb", 200 },
                    { 23, "Storage", "1 Tb HDD", 0 },
                    { 24, "Storage", "256 Gb SSD", 60 },
                    { 13, "OS", "Ubuntu", 0 },
                    { 53, "OS", "Win 10 Pro", 40 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "OrderDate", "ProductID" },
                values: new object[] { 1, new DateTime(2019, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "OrderDate", "ProductID" },
                values: new object[] { 2, new DateTime(2019, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UpgradePJT",
                columns: new[] { "UpgradePJTID", "OrderID", "UpgradeID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 4 },
                    { 3, 1, 6 },
                    { 4, 1, 10 },
                    { 5, 1, 11 },
                    { 6, 1, 12 },
                    { 7, 2, 15 },
                    { 8, 2, 20 },
                    { 9, 2, 23 },
                    { 10, 2, 27 },
                    { 11, 2, 30 },
                    { 12, 2, 32 }
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
                name: "IX_Order_ProductID",
                table: "Order",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_UpgradePJT_OrderID",
                table: "UpgradePJT",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_UpgradePJT_UpgradeID",
                table: "UpgradePJT",
                column: "UpgradeID");
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
                name: "UpgradePJT");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Upgrade");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
