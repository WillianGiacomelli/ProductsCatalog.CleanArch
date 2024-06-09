using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class seedProducts_initial_values : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql1 = "INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
               "VALUES('Mouse sem fio', 'Mouse bluetooth', 49.90, 20, 'mouse.jpg', 1)";
            var sql2 = "INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
               "VALUES('Monitor 27 polegadas', 'Monitor alta resolução', 850.90, 15, 'monitor.jpg', 2)";
            var sql3 = "INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
               "VALUES('Cadeira predisencial', 'Cadeira preta confortável', 1250.90, 10, 'cadeira.jpg', 3)";

            migrationBuilder.Sql(sql1);
            migrationBuilder.Sql(sql2);
            migrationBuilder.Sql(sql3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sql = "DELETE * FROM Products";
            migrationBuilder.Sql(sql);
        }
    }
}
