namespace eCat.Repository.Mapped
{
    public class EstadosSapConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.EstadosSap>
    {
        public EstadosSapConfiguration()
            : this("dbo")
        {
        }

        public EstadosSapConfiguration(string schema)
        {
            ToTable("EstadosSAP", schema);
            HasKey(x => x.IdEstadoSap);

            Property(x => x.IdEstadoSap).HasColumnName(@"IDEstadoSAP").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.EstadoSap).HasColumnName(@"EstadoSAP").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.EnWeb).HasColumnName(@"EnWeb").HasColumnType("bit").IsRequired();
            Property(x => x.IdEstadoBusqueda).HasColumnName(@"IdEstadoBusqueda").HasColumnType("tinyint").IsRequired();
            Property(x => x.RevisarStock).HasColumnName(@"RevisarStock").HasColumnType("bit").IsRequired();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.BajaSoloECat).HasColumnName(@"BajaSoloECat").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.TBusquedaGeneralEstado).WithMany(b => b.EstadosSaps).HasForeignKey(c => c.IdEstadoBusqueda).WillCascadeOnDelete(false); // FK_EstadosSAP_T_BusquedaGeneral_Estados
            HasMany(t => t.DilveSituacionCatalogoEditorials).WithMany(t => t.EstadosSaps).Map(m =>
            {
                m.ToTable("DILVE_SituacionCatalogoEditorial_Equivalencias", "dbo");
                m.MapLeftKey("IdEstadoSAP");
                m.MapRightKey("IdSituacion");
            });
        }
    }
}