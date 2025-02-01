using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Task_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Task_Title = table.Column<string>(type: "text", nullable: true),
                    Task_Description = table.Column<string>(type: "text", nullable: true),
                    Task_Creation = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Task_Required = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Task_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    User_Name = table.Column<string>(type: "text", nullable: true),
                    User_Position = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Comment_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Comment_Text = table.Column<string>(type: "text", nullable: true),
                    Comment_Type = table.Column<int>(type: "integer", nullable: false),
                    Comment_Reminder_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Comment_TaskTask_Id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Comment_Id);
                    table.ForeignKey(
                        name: "FK_Comments_Tasks_Comment_TaskTask_Id",
                        column: x => x.Comment_TaskTask_Id,
                        principalTable: "Tasks",
                        principalColumn: "Task_Id");
                });

            migrationBuilder.CreateTable(
                name: "TaskUser",
                columns: table => new
                {
                    Task_AssignessUser_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    User_TasksTask_Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskUser", x => new { x.Task_AssignessUser_Id, x.User_TasksTask_Id });
                    table.ForeignKey(
                        name: "FK_TaskUser_Tasks_User_TasksTask_Id",
                        column: x => x.User_TasksTask_Id,
                        principalTable: "Tasks",
                        principalColumn: "Task_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskUser_Users_Task_AssignessUser_Id",
                        column: x => x.Task_AssignessUser_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Comment_TaskTask_Id",
                table: "Comments",
                column: "Comment_TaskTask_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TaskUser_User_TasksTask_Id",
                table: "TaskUser",
                column: "User_TasksTask_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "TaskUser");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
