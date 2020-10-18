using Imersao_dados_csv_import.Models;
using Microsoft.EntityFrameworkCore;

namespace Imersao_dados_csv_import.Context
{
    public class MicroDadosContext : DbContext
    {
        public DbSet<MicroDado> MicroDados { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=imersao_dados;Uid=root;Pwd=*****");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
