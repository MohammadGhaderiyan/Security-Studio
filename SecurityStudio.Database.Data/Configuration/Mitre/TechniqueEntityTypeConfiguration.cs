//namespace SecurityStudio.Database.Data.Configuration.Mitre
//{
//    public class TechniqueEntityTypeConfiguration : EntityTypeConfiguration<Technique>
//    {
//        public TechniqueEntityTypeConfiguration()
//        {
//            HasKey(technique => technique.Id);
//            ToTable("Technique", "Mitre");
//            Property(technique => technique.Name).IsRequired();
//            HasRequired(technique => technique.Tactic)
//                .WithMany(tactic => tactic.Techniques)
//                .HasForeignKey(technique => technique.TacticId);
//        }
//    }
//}