using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.IO;

namespace EFPlaying
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {


            using (var db = new LottoContext())
            {
                
            }
        }

        public class LottoContext : DbContext
        {
            public DbSet<Lotto649Data> Lotto649 { get; set; }

            public DbSet<LottoMaxData> LottoMax { get; set; }

            public DbSet<USPowerBallData> USPowerball { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    @"Data Source=(localdb)\ProjectsV13;Initial Catalog=EFPlayingDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}
