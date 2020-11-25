using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace part4.Migrations
{
    public partial class initialcreate : Migration
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
                name: "Upgrade",
                columns: table => new
                {
                    UpgradeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpgradeName = table.Column<string>(nullable: true),
                    UpgradeCategory = table.Column<string>(nullable: true),
                    UpgradePrice = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upgrade", x => x.UpgradeID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    UpgradeID = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Order_Upgrade_UpgradeID",
                        column: x => x.UpgradeID,
                        principalTable: "Upgrade",
                        principalColumn: "UpgradeID",
                        onDelete: ReferentialAction.Restrict);
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
                columns: new[] { "UpgradeID", "OrderID", "UpgradeCategory", "UpgradeName", "UpgradePrice" },
                values: new object[,]
                {
                    { 29, null, "Video", "Quadro P1000", 550 },
                    { 30, null, "Sound", "Integrated", 0 },
                    { 31, null, "Sound", "Sound Blaster 1000", 40 },
                    { 32, null, "OS", "None", 0 },
                    { 33, null, "OS", "Ubuntu", 0 },
                    { 34, null, "OS", "Win 10 Home", 70 },
                    { 35, null, "OS", "Win 10 Pro", 110 },
                    { 36, null, "CPU", "i5 9400", 0 },
                    { 37, null, "CPU", "i5 10400F", 75 },
                    { 38, null, "CPU", "i7 10700k", 150 },
                    { 39, null, "Memory", "8 Gb", 0 },
                    { 41, null, "Memory", "32 Gb", 200 },
                    { 28, null, "Video", "Quadro P620", 300 },
                    { 42, null, "Storage", "256 Gb SSD", 60 },
                    { 43, null, "Storage", "512 Gb SSD", 120 },
                    { 44, null, "Storage", "1 Tb SSD", 240 },
                    { 45, null, "Video", "1650 Ti", 0 },
                    { 46, null, "Video", "1660 Ti", 100 },
                    { 47, null, "Video", "RTX 2060", 150 },
                    { 48, null, "Video", "RTX 2070", 300 },
                    { 49, null, "Sound", "Integrated", 0 },
                    { 50, null, "Sound", "Sound Blaster 5000", 40 },
                    { 51, null, "Sound", "Sound Blaster 10000", 100 },
                    { 40, null, "Memory", "16 Gb", 100 },
                    { 27, null, "Video", "Integrated", 0 },
                    { 25, null, "Storage", "512 Gb SSD", 120 },
                    { 52, null, "OS", "Win 10 Home", 0 },
                    { 1, null, "CPU", "i3 8130u", 0 },
                    { 2, null, "CPU", "i5 8250u", 50 },
                    { 3, null, "CPU", "i7 8550u", 100 },
                    { 4, null, "Memory", "8 Gb", 0 },
                    { 5, null, "Memory", "16 Gb", 100 },
                    { 6, null, "Storage", "1 Tb HDD", 0 },
                    { 7, null, "Storage", "128 Gb SSD", 0 },
                    { 8, null, "Storage", "256 Gb SSD", 60 },
                    { 9, null, "Storage", "512 Gb SSD", 120 },
                    { 10, null, "Video", "Integrated", 0 },
                    { 11, null, "Sound", "Integrated", 0 },
                    { 26, null, "Storage", "1 Tb SSD", 240 },
                    { 12, null, "OS", "None", 0 },
                    { 14, null, "OS", "Win 10 Home", 70 },
                    { 15, null, "CPU", "i3 10100", 0 },
                    { 16, null, "CPU", "i5 10400", 50 },
                    { 17, null, "CPU", "i5 10600", 80 },
                    { 18, null, "CPU", "i7 10700", 140 },
                    { 19, null, "CPU", "i9 10900", 200 },
                    { 20, null, "Memory", "8 Gb", 0 },
                    { 21, null, "Memory", "16 Gb", 100 },
                    { 22, null, "Memory", "32 Gb", 200 },
                    { 23, null, "Storage", "1 Tb HDD", 0 },
                    { 24, null, "Storage", "256 Gb SSD", 60 },
                    { 13, null, "OS", "Ubuntu", 0 },
                    { 53, null, "OS", "Win 10 Pro", 40 }
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
                name: "IX_Order_UpgradeID",
                table: "Order",
                column: "UpgradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Upgrade_OrderID",
                table: "Upgrade",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Upgrade_Order_OrderID",
                table: "Upgrade",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Product_ProductID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Upgrade_UpgradeID",
                table: "Order");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Upgrade");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
