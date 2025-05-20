using Microsoft.EntityFrameworkCore; 
using Genesis.Domain.Models;
using api.Core.Mapping;
using api.Domain.Models;

namespace api.Core;

public partial class ParkFlowContext : DbContext
{
    public ParkFlowContext() {}
    
    public ParkFlowContext(DbContextOptions<ParkFlowContext> options)
        : base(options)
    {}

    public virtual DbSet<Role> RoleList { get; set; }
    public virtual DbSet<Address> AddressList { get; set; }
    public virtual DbSet<Image> ImageList { get; set; }
    public virtual DbSet<Plan> PlanList { get; set; }
    public virtual DbSet<CompanySettings> CompanySettingsList { get; set; }
    public virtual DbSet<Company> CompanyList { get; set; }
    public virtual DbSet<User> UserList { get; set; }
    public virtual DbSet<GoogleAuthentication> GoogleAuthenticationList { get; set; }
    public virtual DbSet<Vehicle> VehicleList { get; set; }
    public virtual DbSet<VehicleAccessLog> VehicleAccessLogList { get; set; }

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Data Source=CT-C-002AF\SQLEXPRESS;Initial Catalog=ParkFlow;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfiguration(new RoleClassMap());
        modelBuilder.ApplyConfiguration(new AddressClassMap());
        modelBuilder.ApplyConfiguration(new ImageClassMap());
        modelBuilder.ApplyConfiguration(new PlanClassMap());
        modelBuilder.ApplyConfiguration(new CompanySettingsClassMap());
        modelBuilder.ApplyConfiguration(new CompanyClassMap());
        modelBuilder.ApplyConfiguration(new UserClassMap());
        modelBuilder.ApplyConfiguration(new GoogleAuthenticationClassMap());
        modelBuilder.ApplyConfiguration(new VehicleClassMap());
        modelBuilder.ApplyConfiguration(new VehicleAccessLogClassMap());

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public override int SaveChanges()
    {
        foreach(var entry in ChangeTracker.Entries())
        {
            if(entry.State == EntityState.Deleted && entry.Entity is ISoftDeleted deleted)
            {
                entry.State = EntityState.Modified;
                deleted.DeletedAt = DateTime.Now;
            }
        }
        return base.SaveChanges();
    }
}
