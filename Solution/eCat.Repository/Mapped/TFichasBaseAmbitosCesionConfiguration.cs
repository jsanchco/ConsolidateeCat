namespace eCat.Repository.Mapped
{
    public class TFichasBaseAmbitosCesionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TFichasBaseAmbitosCesion>
    {
        public TFichasBaseAmbitosCesionConfiguration()
            : this("dbo")
        {
        }

        public TFichasBaseAmbitosCesionConfiguration(string schema)
        {
            ToTable("T_FichasBase_AmbitosCesion", schema);
            HasKey(x => x.IdFichasBaseAmbitoCesion);

            Property(x => x.IdFichasBaseAmbitoCesion).HasColumnName(@"IdFichasBaseAmbitoCesion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.ComentariosInternos).HasColumnName(@"ComentariosInternos").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsRequired();
            Property(x => x.MasInformacion).HasColumnName(@"MasInformacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.EsRestrictivo).HasColumnName(@"EsRestrictivo").HasColumnType("bit").IsRequired();
            Property(x => x.DisponibleVentaDerechos).HasColumnName(@"DisponibleVentaDerechos").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.TFichasBaseAmbitosCesions).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_T_FichasBase_AmbitosCesion_FichasBase
            HasRequired(a => a.TAmbitosCesionEstado).WithMany(b => b.TFichasBaseAmbitosCesions).HasForeignKey(c => c.IdEstado).WillCascadeOnDelete(false); // FK_T_FichasBase_AmbitosCesion_T_AmbitosCesion_Estados
        }
    }
}