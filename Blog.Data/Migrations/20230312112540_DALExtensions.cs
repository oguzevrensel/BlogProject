using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a37efc04-c69f-4719-b70e-f614debbba6d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c7a9125a-1dde-4900-a902-017a88db7546"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("7b6b2d78-d3a7-4b3d-a107-842715c856d0"), new Guid("bf2a3de7-beb3-4e03-b111-e5010dbb3c9d"), "Asp.NetCore Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 3, 12, 14, 25, 40, 401, DateTimeKind.Local).AddTicks(2171), null, null, new Guid("92621080-1900-4e50-bd65-0c7cfbdbe1ce"), false, null, null, "Asp.NetCore Deneme Makalesi", 15 },
                    { new Guid("f0b25915-5787-4d10-a4ef-cb74775cc2f9"), new Guid("94bbaef5-0bb6-4e51-98cc-e7981360d908"), "Visual Studio Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 3, 12, 14, 25, 40, 401, DateTimeKind.Local).AddTicks(2178), null, null, new Guid("00d19de1-b11f-46b7-9b18-867fd52c6289"), false, null, null, "Visual Studio Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94bbaef5-0bb6-4e51-98cc-e7981360d908"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 14, 25, 40, 401, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf2a3de7-beb3-4e03-b111-e5010dbb3c9d"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 14, 25, 40, 401, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("00d19de1-b11f-46b7-9b18-867fd52c6289"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 14, 25, 40, 401, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("92621080-1900-4e50-bd65-0c7cfbdbe1ce"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 14, 25, 40, 401, DateTimeKind.Local).AddTicks(2475));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7b6b2d78-d3a7-4b3d-a107-842715c856d0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f0b25915-5787-4d10-a4ef-cb74775cc2f9"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("a37efc04-c69f-4719-b70e-f614debbba6d"), new Guid("bf2a3de7-beb3-4e03-b111-e5010dbb3c9d"), "Asp.NetCore Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(2866), null, null, new Guid("92621080-1900-4e50-bd65-0c7cfbdbe1ce"), false, null, null, "Asp.NetCore Deneme Makalesi", 15 },
                    { new Guid("c7a9125a-1dde-4900-a902-017a88db7546"), new Guid("94bbaef5-0bb6-4e51-98cc-e7981360d908"), "Visual Studio Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(2880), null, null, new Guid("00d19de1-b11f-46b7-9b18-867fd52c6289"), false, null, null, "Visual Studio Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94bbaef5-0bb6-4e51-98cc-e7981360d908"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf2a3de7-beb3-4e03-b111-e5010dbb3c9d"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("00d19de1-b11f-46b7-9b18-867fd52c6289"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("92621080-1900-4e50-bd65-0c7cfbdbe1ce"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 15, 47, 16, 667, DateTimeKind.Local).AddTicks(3137));
        }
    }
}
