using SocialNetwork.RestServices.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SocialNetwork.RestServices.Mappers
{
    public class PerfilConfiguracion : EntityTypeConfiguration<Perfil>
    {
        public PerfilConfiguracion()
        {
            this.ToTable("Perfiles");

            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Id).IsRequired();

            this.HasRequired(c => c.Usuario).WithRequiredDependent(u => u.Perfil);

            this.Property(c => c.Privacidad).IsRequired();

            this.Property(c => c.Buscando).IsOptional();
            this.Property(c => c.Buscando).HasMaxLength(200);

            this.Property(c => c.Interes).IsOptional();
            this.Property(c => c.Interes).HasMaxLength(800);

            this.Property(c => c.Educacion).IsOptional();
            this.Property(c => c.Educacion).HasMaxLength(800);

            this.Property(c => c.Hobbies).IsOptional();
            this.Property(c => c.Hobbies).HasMaxLength(800);

            this.Property(c => c.Peliculas).IsOptional();
            this.Property(c => c.Peliculas).HasMaxLength(800);

            this.Property(c => c.Artistas).IsOptional();
            this.Property(c => c.Artistas).HasMaxLength(800);

            this.Property(c => c.Libros).IsOptional();
            this.Property(c => c.Libros).HasMaxLength(800);
        }
    }
}