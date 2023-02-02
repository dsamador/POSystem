﻿namespace POS.Infrastructure.Persistence.Interfaces
{
  public interface IUnitOfWork : IDisposable
  {
    //Declaracion o matricula de nuestras interfaces a nuvel de repository
    ICategoryRepository Category { get; }
    void SaveChanges();
    Task SaveChangesAsync();
  }
}
