using ElixirControlPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ElixirControlPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
   protected override void OnConfiguring(DbContextOptionsBuilder builder)
   {
      //Para campos de auditor (CreatedDate, UpdatedDate)
      builder.AddCreatedUpdatedInterceptor();
      base.OnConfiguring(builder);
   }
   
   protected override void OnModelCreating(ModelBuilder builder)
   {
      base.OnModelCreating(builder);
      
      //=================================================================================================
      //||                                    CONFIGURATION OF THE TABLES                              ||                              
      //=================================================================================================
         
      //===================================== 1. GONZALO Bounded Context ================================
         
         
      //===================================== END GONZALO Bounded Context ===============================
         
         
      //===================================== 2. GUSTAVO Bounded Context ================================
         
         
      //===================================== END GUSTAVO Bounded Context ===============================
         
         
      //===================================== 3. LUIS Bounded Context ===================================
         
         
      //===================================== END LUIS Bounded Context ==================================
         
         
      //===================================== 4. OSCAR Bounded Context ==================================
         
         
      //===================================== END OSCAR Bounded Context =================================
         
         
      //===================================== 5. VICENTE Bounded Context ================================
         
         
      //===================================== END VICENTE Bounded Context ===============================
   
      
      //Regals de mapped object relational (ORM)
      builder.UseSnakeCaseNamingConvention();
   }
}