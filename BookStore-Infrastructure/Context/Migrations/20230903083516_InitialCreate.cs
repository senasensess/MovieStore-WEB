using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore_Infrastructure.Context.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieCategories",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategories", x => new { x.MovieId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_MovieCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCategories_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3123), null, "Action", 1, null },
                    { 2, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3125), null, "Adventure", 1, null },
                    { 3, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3126), null, "Comedy", 1, null },
                    { 4, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3127), null, "Fantasy", 1, null },
                    { 5, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3128), null, "Horror", 1, null },
                    { 6, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3129), null, "Mystery", 1, null },
                    { 7, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3130), null, "Romance", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "FirstName", "LastName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1928, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(2594), null, "Stanley", "Kubrick", 1, null },
                    { 2, new DateTime(1933, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(2614), null, "Roman", "Polanski", 1, null },
                    { 3, new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(2616), null, "Quentine Jerome", "Tarantino", 1, null },
                    { 4, new DateTime(1897, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(2617), null, "Frank", "Capra", 1, null },
                    { 5, new DateTime(1962, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(2618), null, "David Leo", "Fincher", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "DirectorId", "Image", "Name", "Status", "UpdatedDate", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3021), null, "A pragmatic U.S. Marine observes the dehumanizing effects the Vietnam War has on his fellow recruits from their brutal boot camp training to the bloody street fighting in Hue.", 1, "1269f10b-aa48-4e93-b666-76ca1d34fa06_Full Metal Jacket.jpg", "Full Metal Jacket", 1, null, 1987 },
                    { 2, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3024), null, "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future", 1, "6c472c63-5322-4081-b558-1ea594fca0d0_The Shining.jpg", "The Shining", 1, null, 1980 },
                    { 3, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3026), null, "A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II", 2, "d116b47d-4705-4f88-bb48-409714ec7c58_The Pianist.jpg", "The Pianist", 1, null, 2002 },
                    { 4, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3027), null, "In 1894, French Captain Alfred Dreyfus is wrongfully convicted of treason and sentenced to life imprisonment at Devil's island", 2, "d61f21ba-57eb-49d8-bb88-3c3500af5f75_An Officer and Spy.jpg", "An Offices and Spy", 1, null, 2019 },
                    { 5, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3028), null, "A faded television actor and his stunt double strive to achieve fame and success in the final years of Hollywood's Golden Age in 1969 Los Angeles", 3, "a501a3f6-530d-4cb1-b7f2-26bd1eb8ac6b_Once Upon a Time in Hollywood.jpg", "Once Upon a Time in Hollywood", 1, null, 2019 },
                    { 6, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3029), null, "After awakening from a four-year coma, a former assassin wreaks vengeance on the team of assassins who betrayed her.", 3, "1786becb-0d95-4eab-b103-14e1164e4dfa_Kill Bill Volume 1.jpg", "Kill Bill Volume 1", 1, null, 2003 },
                    { 7, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3030), null, "A Broadway matinee idol famous for his black-face portrayals anonymously joins an amateur acting troupe and falls in love with the leading lady", 4, "13d01d4f-6249-4861-bed5-51aa43b6302a_The Matinee Idol.jpg", "The Matinee Idol", 1, null, 1928 },
                    { 8, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3031), null, "Naive newspaper cub Clem lands a scoop when he's sent out to cover a murder. In his enthusiasm he writes that the main suspect is Jane. When she confronts Clem she convinces him to help her prove her innocence", 4, "2d97dc9f-3047-4460-9895-d122e671690c_Power_of_the_pressmp.jpg", "The Power Of The Press", 1, null, 1928 },
                    { 9, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3033), null, "Tells the story of Benjamin Button, a man who starts aging backwards with consequences", 5, "73297031-ae64-4231-9bac-51e834a0fe04_The Curios Case of Benjamin Button.jpg", "The Curios Case of Benjamin Button", 1, null, 2008 },
                    { 10, new DateTime(2023, 9, 3, 11, 35, 15, 654, DateTimeKind.Local).AddTicks(3034), null, "As Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, he is sued by the twins who claimed he stole their idea and by the co-founder who was later squeezed out of the business", 5, "a919191b-0917-4b7c-9c69-a9f8cb0ae5ff_The_Social_Network_film_poster.png", "The Social Network", 1, null, 2010 }
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "CategoryId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 5, 2 },
                    { 1, 3 },
                    { 6, 3 },
                    { 7, 3 },
                    { 1, 4 },
                    { 3, 4 },
                    { 5, 4 },
                    { 4, 5 },
                    { 5, 5 },
                    { 1, 6 },
                    { 3, 6 },
                    { 5, 6 },
                    { 5, 7 },
                    { 6, 7 },
                    { 1, 8 },
                    { 7, 8 },
                    { 2, 9 },
                    { 3, 9 },
                    { 2, 10 },
                    { 5, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieCategories_CategoryId",
                table: "MovieCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies",
                column: "DirectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Directors");
        }
    }
}
