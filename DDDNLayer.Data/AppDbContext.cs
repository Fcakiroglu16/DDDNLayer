using DDDNLayer.Data.Configurations;
using DDDNLayer.Domain.Core;
using DDDNLayer.Domain.Core.Mediator;
using DDDNLayer.Domain.Core.Messaging;
using DDDNLayer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayer.Data
{
    public class AppDbContext : DbContext, IUnitOfWork
    {
        private readonly IMediatorHandler _mediatorHandler;

        public AppDbContext(DbContextOptions<AppDbContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Event>();
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> CommitAsync()
        {
            var domainEntities = ChangeTracker.Entries<Entity>().Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

            var domainEvents = domainEntities.SelectMany(x => x.Entity.DomainEvents).ToList();

            domainEvents.Select(async (e) =>
            {
                await _mediatorHandler.PublishEvent(e);
            });

            return await SaveChangesAsync() > 0;
        }
    }
}