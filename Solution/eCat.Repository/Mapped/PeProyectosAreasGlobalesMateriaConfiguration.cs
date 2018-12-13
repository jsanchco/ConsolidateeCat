namespace eCat.Repository.Mapped
{
    public class PeProyectosAreasGlobalesMateriaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeProyectosAreasGlobalesMateria>
    {
        public PeProyectosAreasGlobalesMateriaConfiguration()
            : this("dbo")
        {
        }

        public PeProyectosAreasGlobalesMateriaConfiguration(string schema)
        {
            ToTable("PE_Proyectos_AreasGlobales_Materias", schema);
            HasKey(x => new { x.IdProyecto, x.IdAreaGlobal, x.CodMateria });

            Property(x => x.IdProyecto).HasColumnName(@"IdProyecto").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdAreaGlobal).HasColumnName(@"IdAreaGlobal").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodMateria).HasColumnName(@"CodMateria").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.PeAreasGlobalesMateria).WithMany(b => b.PeProyectosAreasGlobalesMaterias).HasForeignKey(c => new { c.IdAreaGlobal, c.CodMateria }).WillCascadeOnDelete(false); // FK_PE_Proyectos_AreasGlobales_Materias_PE_AreasGlobales_Materias
            HasRequired(a => a.PeProyecto).WithMany(b => b.PeProyectosAreasGlobalesMaterias).HasForeignKey(c => c.IdProyecto).WillCascadeOnDelete(false); // FK_PE_Proyectos_AreasGlobales_Materias_PE_Proyectos
        }
    }
}