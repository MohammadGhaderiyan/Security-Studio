//namespace SecurityStudio.Database.Data.Configuration.Mitre
//{
//    public class SubTechniqueEntityTypeConfiguration : EntityTypeConfiguration<SubTechnique>
//    {
//        public SubTechniqueEntityTypeConfiguration()
//        {
//            HasKey(subTechnique => subTechnique.Id);
//            ToTable("SubTechnique", "Mitre");
//            Property(subTechnique => subTechnique.Name).IsRequired();
//            HasRequired(subTechnique => subTechnique.Technique)
//                .WithMany(technique => technique.SubTechniques)
//                .HasForeignKey(subTechnique => subTechnique.TechniqueId);
//        }
//    }
//}