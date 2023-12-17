namespace BankingWebApp.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly BankAppDbContext _context;
        private readonly DbSet<TEntity> table;

        public BaseRepository(BankAppDbContext context)
        {
            _context = context;
            table = _context.Set<TEntity>();
        }

        protected DbSet<TEntity> GetTable()
        {
            return table;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return table.ToList();
        }

        public TEntity GetById(int id)
        {
            var entity = table.Find(id);

            if (entity is null) throw new ArgumentNullException(nameof(id), $"No entity with id given has been found in the database");

            return entity;
        }

        public void Insert(TEntity entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity), $"Null entity cannot be added to the database");

            table.Add(entity);
        }

        public void Update(TEntity entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity), $"Null entity cannot be updated into the database");

            table.Update(entity);
        }

        public void Delete(int id)
        {
            TEntity existing = table.Find(id)!;
            if (existing is null) throw new ArgumentNullException(nameof(id), "No entity exists with the given id in the database");

            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
