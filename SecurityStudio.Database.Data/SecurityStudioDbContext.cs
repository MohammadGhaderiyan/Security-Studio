//using SecurityStudio.Database.Data.Migrations;

//namespace SecurityStudio.Database.Data
//{
//    public class SecurityStudioDbContext : DbContext
//    {
//        public SecurityStudioDbContext()
//        {

//        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//        }


//        #region Mitre

//        public DbSet<SubTechnique> SubTechniques { get; set; }
//        public DbSet<Tactic> Tactics { get; set; }
//        public DbSet<Technique> Techniques { get; set; }

//        #endregion


//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);


//            #region Mitre

//            modelBuilder.Configurations.Add(new SubTechniqueEntityTypeConfiguration());
//            modelBuilder.Configurations.Add(new TacticEntityTypeConfiguration());
//            modelBuilder.Configurations.Add(new TechniqueEntityTypeConfiguration());

//            #endregion
//        }
//    }
//}