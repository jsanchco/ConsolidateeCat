namespace eCat.Repository.Mapped
{
    public class TAmbitosCesionGruposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TAmbitosCesionGrupos>
    {
        public TAmbitosCesionGruposConfiguration()
            : this("dbo")
        {
        }

        public TAmbitosCesionGruposConfiguration(string schema)
        {
            ToTable("T_AmbitosCesion_Grupos", schema);
            HasKey(x => x.IdGrupoAmbitoCesion);

            Property(x => x.IdGrupoAmbitoCesion).HasColumnName(@"IdGrupoAmbitoCesion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.GrupoAmbitoCesion).HasColumnName(@"GrupoAmbitoCesion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}