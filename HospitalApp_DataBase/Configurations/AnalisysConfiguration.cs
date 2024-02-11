using HospitalApp_Model.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalApp_DataBase.Configurations;

internal class AnalisysConfiguration : IEntityTypeConfiguration<Analiz>
{
    public void Configure(EntityTypeBuilder<Analiz> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
