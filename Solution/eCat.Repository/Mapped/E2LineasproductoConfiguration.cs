namespace eCat.Repository.Mapped
{
    public class E2LineasproductoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2Lineasproducto>
    {
        public E2LineasproductoConfiguration()
            : this("dbo")
        {
        }

        public E2LineasproductoConfiguration(string schema)
        {
            ToTable("E2_LINEASPRODUCTO", schema);
            HasKey(x => x.IdLineaP);

            Property(x => x.IdLineaP).HasColumnName(@"IdLineaP").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodLineaP).HasColumnName(@"COD_lineaP").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Texto).HasColumnName(@"Texto").HasColumnType("bit").IsRequired();
            Property(x => x.ProyectoGestion).HasColumnName(@"ProyectoGestion").HasColumnType("bit").IsRequired();
            HasMany(t => t.DilvePublicoObjetivoes).WithMany(t => t.E2Lineasproducto).Map(m =>
            {
                m.ToTable("DILVE_PublicoObjetivo_Equivalencias", "dbo");
                m.MapLeftKey("IdLineaP");
                m.MapRightKey("IdPublicoObjetivo");
            });
        }
    }
}