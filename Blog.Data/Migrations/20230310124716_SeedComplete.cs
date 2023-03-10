using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedComplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("94bbaef5-0bb6-4e51-98cc-e7981360d908"), "Admin Test", new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(3048), null, null, false, null, null, "Visual Studio 2022" },
                    { new Guid("bf2a3de7-beb3-4e03-b111-e5010dbb3c9d"), "Admin Test", new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(3044), null, null, false, null, null, "Asp.Net Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("00d19de1-b11f-46b7-9b18-867fd52c6289"), "Admin Test", new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(3144), null, null, "images/vsTests", "png", false, null, null },
                    { new Guid("92621080-1900-4e50-bd65-0c7cfbdbe1ce"), "Admin Test", new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(3137), null, null, "images/testImage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("a37efc04-c69f-4719-b70e-f614debbba6d"), new Guid("bf2a3de7-beb3-4e03-b111-e5010dbb3c9d"), "Asp.NetCore Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(2866), null, null, new Guid("92621080-1900-4e50-bd65-0c7cfbdbe1ce"), false, null, null, "Asp.NetCore Deneme Makalesi", 15 },
                    { new Guid("c7a9125a-1dde-4900-a902-017a88db7546"), new Guid("94bbaef5-0bb6-4e51-98cc-e7981360d908"), "Visual Studio Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(2880), null, null, new Guid("00d19de1-b11f-46b7-9b18-867fd52c6289"), false, null, null, "Visual Studio Deneme Makalesi", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a37efc04-c69f-4719-b70e-f614debbba6d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c7a9125a-1dde-4900-a902-017a88db7546"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94bbaef5-0bb6-4e51-98cc-e7981360d908"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf2a3de7-beb3-4e03-b111-e5010dbb3c9d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("00d19de1-b11f-46b7-9b18-867fd52c6289"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("92621080-1900-4e50-bd65-0c7cfbdbe1ce"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
