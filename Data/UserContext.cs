

using estudos_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace estudos_crud.Data
{
  public class UserContext : DbContext
  {
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
    }

    public DbSet<UserCar> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      var userCar = modelBuilder.Entity<UserCar>();

      userCar.ToTable("tb_usersCars");
      userCar.HasKey(x => x.Id);
      userCar.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
      userCar.Property(x => x.Name).HasColumnName("name").IsRequired();
    }
  }
}