using Microsoft.EntityFrameworkCore;

namespace SistemaCadastroFornecedores.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
        }

        public DbSet<FornecedorModel> Fornecedores { get; set; }
    }
}
