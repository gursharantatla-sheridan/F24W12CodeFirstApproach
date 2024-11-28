﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F24W12CodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameColumnToStudentName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "StudentName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "Name");
        }
    }
}
