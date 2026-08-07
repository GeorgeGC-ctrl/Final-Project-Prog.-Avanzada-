using Microsoft.EntityFrameworkCore.Storage;
using Northwind.Domain.Entidades;

namespace Northwind.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly NorthwindDbContext _context;
    private IDbContextTransaction _transaction;
    public UnitOfWork(NorthwindDbContext context)
    {
        this._context = context;
    }
    public IRepository<Categories> Categorias => new GenericRepository<Categories>(_context);
    public IRepository<Suppliers> Suplidores => new GenericRepository<Suppliers>(_context);
    public IRepository<Products> Productos => new GenericRepository<Products>(_context);

    public async Task BeginTransaction()
    {
        _transaction = await _context.Database.BeginTransactionAsync();
    }
    public async Task CommitTransaction()
    {
        if (_transaction == null) return;

        await _transaction.CommitAsync();
        await _transaction.DisposeAsync();

        _transaction = null;
    }
    public async Task RollbackTransaction()
    {
        if (_transaction == null) return;

        await _transaction.RollbackAsync();
        await _transaction.DisposeAsync();

        _transaction = null;
    }
    public void Dispose()
    {
        _transaction?.Dispose();
        _context.Dispose();

        GC.SuppressFinalize(this);
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

}