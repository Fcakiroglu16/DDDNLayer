using DDDNLayer.Data.Configurations;
using DDDNLayer.Domain.Core;

using DDDNLayer.Domain.CategoryAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace DDDNLayer.Data
{
    public class AppDbContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "myschema";

        public DbSet<Category> Categories { get; set; }
        private readonly IMediator _mediator;

        public AppDbContext(DbContextOptions<AppDbContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator;
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Ignore<Event>();
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //    base.OnModelCreating(modelBuilder);
        //}

        //public async Task<bool> CommitAsync()
        //{
        //    var domainEntities = ChangeTracker.Entries<Entity>().Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

        //    var domainEvents = domainEntities.SelectMany(x => x.Entity.DomainEvents).ToList();

        //    //domainEvents.Select(async (e) =>
        //    //{
        //    //    await _mediatorHandler.PublishEvent(e);
        //    //});

        //    return await SaveChangesAsync() > 0;
        //}
    }
}