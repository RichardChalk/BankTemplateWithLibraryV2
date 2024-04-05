using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Accounts",
            //    columns: table => new
            //    {
            //        AccountId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Frequency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Created = table.Column<DateOnly>(type: "date", nullable: false),
            //        Balance = table.Column<decimal>(type: "decimal(13,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_account", x => x.AccountId);
            //    });

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

            //migrationBuilder.CreateTable(
            //    name: "Countries",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CountryCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
            //        CountryLabel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Countries", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Customers",
            //    columns: table => new
            //    {
            //        CustomerId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
            //        Givenname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        Streetaddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        Zipcode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
            //        Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        CountryCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
            //        Birthday = table.Column<DateOnly>(type: "date", nullable: true),
            //        NationalId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        Telephonecountrycode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        Telephonenumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
            //        Emailaddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Customers", x => x.CustomerId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Frequencies",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FrequencyCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
            //        FreqeuncyLabel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Frequencies", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Genders",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        GenderCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
            //        GenderLabel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Genders", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "User",
            //    columns: table => new
            //    {
            //        UserID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        LoginName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
            //        PasswordHash = table.Column<byte[]>(type: "binary(64)", fixedLength: true, maxLength: 64, nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_User_UserID", x => x.UserID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Loans",
            //    columns: table => new
            //    {
            //        LoanId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AccountId = table.Column<int>(type: "int", nullable: false),
            //        Date = table.Column<DateOnly>(type: "date", nullable: false),
            //        Amount = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
            //        Duration = table.Column<int>(type: "int", nullable: false),
            //        Payments = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
            //        Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_loan", x => x.LoanId);
            //        table.ForeignKey(
            //            name: "FK_Loans_Accounts",
            //            column: x => x.AccountId,
            //            principalTable: "Accounts",
            //            principalColumn: "AccountId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PermenentOrder",
            //    columns: table => new
            //    {
            //        OrderId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AccountId = table.Column<int>(type: "int", nullable: false),
            //        BankTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        AccountTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Amount = table.Column<decimal>(type: "decimal(13,2)", nullable: false, defaultValueSql: "((0.0))"),
            //        Symbol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PermenentOrder", x => x.OrderId);
            //        table.ForeignKey(
            //            name: "FK_PermenentOrder_Accounts",
            //            column: x => x.AccountId,
            //            principalTable: "Accounts",
            //            principalColumn: "AccountId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Transactions",
            //    columns: table => new
            //    {
            //        TransactionId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AccountId = table.Column<int>(type: "int", nullable: false),
            //        Date = table.Column<DateOnly>(type: "date", nullable: false),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Operation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Amount = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
            //        Balance = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
            //        Symbol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Bank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Account = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        LaunderingChecked = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_trans2", x => x.TransactionId);
            //        table.ForeignKey(
            //            name: "FK_Transactions_Accounts",
            //            column: x => x.AccountId,
            //            principalTable: "Accounts",
            //            principalColumn: "AccountId");
            //    });

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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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

            //migrationBuilder.CreateTable(
            //    name: "Dispositions",
            //    columns: table => new
            //    {
            //        DispositionId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CustomerId = table.Column<int>(type: "int", nullable: false),
            //        AccountId = table.Column<int>(type: "int", nullable: false),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_disposition", x => x.DispositionId);
            //        table.ForeignKey(
            //            name: "FK_Dispositions_Accounts",
            //            column: x => x.AccountId,
            //            principalTable: "Accounts",
            //            principalColumn: "AccountId");
            //        table.ForeignKey(
            //            name: "FK_Dispositions_Customers",
            //            column: x => x.CustomerId,
            //            principalTable: "Customers",
            //            principalColumn: "CustomerId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cards",
            //    columns: table => new
            //    {
            //        CardId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DispositionId = table.Column<int>(type: "int", nullable: false),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Issued = table.Column<DateOnly>(type: "date", nullable: false),
            //        CCType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        CCNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        CVV2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //        ExpM = table.Column<int>(type: "int", nullable: false),
            //        ExpY = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cards", x => x.CardId);
            //        table.ForeignKey(
            //            name: "FK_Cards_Dispositions",
            //            column: x => x.DispositionId,
            //            principalTable: "Dispositions",
            //            principalColumn: "DispositionId");
            //    });

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

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cards_DispositionId",
            //    table: "Cards",
            //    column: "DispositionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Dispositions_AccountId",
            //    table: "Dispositions",
            //    column: "AccountId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Dispositions_CustomerId",
            //    table: "Dispositions",
            //    column: "CustomerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Loans_AccountId",
            //    table: "Loans",
            //    column: "AccountId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PermenentOrder_AccountId",
            //    table: "PermenentOrder",
            //    column: "AccountId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Transactions_AccountId",
            //    table: "Transactions",
            //    column: "AccountId");
        }

        /// <inheritdoc />
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

            //migrationBuilder.DropTable(
            //    name: "Cards");

            //migrationBuilder.DropTable(
            //    name: "Countries");

            //migrationBuilder.DropTable(
            //    name: "Frequencies");

            //migrationBuilder.DropTable(
            //    name: "Genders");

            //migrationBuilder.DropTable(
            //    name: "Loans");

            //migrationBuilder.DropTable(
            //    name: "PermenentOrder");

            //migrationBuilder.DropTable(
            //    name: "Transactions");

            //migrationBuilder.DropTable(
            //    name: "User");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            //migrationBuilder.DropTable(
            //    name: "Dispositions");

            //migrationBuilder.DropTable(
            //    name: "Accounts");

            //migrationBuilder.DropTable(
            //    name: "Customers");
        }
    }
}
