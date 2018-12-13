namespace eCat.Repository.Mapped
{
    public class EventoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Evento>
    {
        public EventoConfiguration()
            : this("dbo")
        {
        }

        public EventoConfiguration(string schema)
        {
            ToTable("Eventos", schema);
            HasKey(x => x.IdEvento);

            Property(x => x.IdEvento).HasColumnName(@"IDEvento").HasColumnType("nvarchar").IsRequired().HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Evento_).HasColumnName(@"Evento").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }
}