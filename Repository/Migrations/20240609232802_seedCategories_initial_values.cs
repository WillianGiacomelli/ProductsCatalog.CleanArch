using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class seedCategories_initial_values : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql1 = "INSERT INTO Categories(Name, Description)" +
                "VALUES('acessórios para computadores', 'Acessórios diversos para dar um up no setup')";
            var sql2 = "INSERT INTO Categories(Name, Description) " +
                "VALUES('monitores', 'Monitores para escritório')";
            var sql3 = "INSERT INTO Categories(Name, Description) " +
                "VALUES('cadeiras de escritório', 'Cadeiras de escritório')";

            migrationBuilder.Sql(sql1);
            migrationBuilder.Sql(sql2);
            migrationBuilder.Sql(sql3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sql = "DELETE * FROM Categories";
            migrationBuilder.Sql(sql);
        }
    }
}
