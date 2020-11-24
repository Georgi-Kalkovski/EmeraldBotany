namespace EmeraldBotany.Data
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    using EmeraldBotany.Data.Common.Models;
    using EmeraldBotany.Data.Models;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod =
            typeof(ApplicationDbContext).GetMethod(
                nameof(SetIsDeletedQueryFilter),
                BindingFlags.NonPublic | BindingFlags.Static);

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<AverageHeight> AverageHeights { get; set; }

        public DbSet<Bark> Barks { get; set; }

        public DbSet<Flower> Flowers { get; set; }

        public DbSet<Foliage> Foliages { get; set; }

        public DbSet<Fruit> Fruits { get; set; }

        public DbSet<FruitOrSeed> FruitsOrSeeds { get; set; }

        public DbSet<Growth> Growths { get; set; }

        public DbSet<Habit> Habits { get; set; }

        public DbSet<Images> Images { get; set; }

        public DbSet<Leaf> Leafs { get; set; }

        public DbSet<MaximumHeight> MaximumHeights { get; set; }

        public DbSet<MaximumPrecipitation> MaximumPrecipitations { get; set; }

        public DbSet<MaximumTemperature> MaximumTemperatures { get; set; }

        public DbSet<MinimumPrecipitation> MinimumPrecipitations { get; set; }

        public DbSet<MinimumRootDepth> MinimumRootDepths { get; set; }

        public DbSet<MinimumTemperature> MinimumTemperatures { get; set; }

        public DbSet<Other> Others { get; set; }

        public DbSet<Plant> Plants { get; set; }

        public DbSet<RowSpacing> RowSpacings { get; set; }

        public DbSet<Source> Source { get; set; }

        public DbSet<Sources> Sources { get; set; }

        public DbSet<Species> Species { get; set; }

        public DbSet<Specifications> Specifications { get; set; }

        public DbSet<Spread> Spreads { get; set; }

        public DbSet<Synonyms> Synonyms { get; set; }

        public DbSet<Absent> Absents { get; set; }

        public DbSet<Distributions> Distributions { get; set; }

        public DbSet<Doubtful> Doubtfuls { get; set; }

        public DbSet<Extinct> Extincts { get; set; }

        public DbSet<Introduced> Introduceds { get; set; }

        public DbSet<Links> Links { get; set; }

        public DbSet<Native> Natives { get; set; }

        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Needed for Identity models configuration
            base.OnModelCreating(builder);

            this.ConfigureUserIdentityRelations(builder);

            EntityIndexesConfiguration.Configure(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();

            // Set global query filter for not deleted entities only
            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDeletableEntity).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { builder });
            }

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        private static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDeletableEntity
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }

        // Applies configurations
        private void ConfigureUserIdentityRelations(ModelBuilder builder)
             => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
