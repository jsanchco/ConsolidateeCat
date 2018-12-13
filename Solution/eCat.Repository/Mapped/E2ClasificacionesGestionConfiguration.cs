namespace eCat.Repository.Mapped
{
    public class E2ClasificacionesGestionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2ClasificacionesGestion>
    {
        public E2ClasificacionesGestionConfiguration()
            : this("dbo")
        {
        }

        public E2ClasificacionesGestionConfiguration(string schema)
        {
            ToTable("E2_CLASIFICACIONES_GESTION", schema);
            HasKey(x => x.IdCatalogo);

            Property(x => x.IdCatalogo).HasColumnName(@"ID_CATALOGO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PlantillaNiveles).HasColumnName(@"PlantillaNiveles").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Editable).HasColumnName(@"Editable").HasColumnType("bit").IsRequired();
        }
    }
}