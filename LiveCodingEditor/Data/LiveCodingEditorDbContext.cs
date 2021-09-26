namespace LiveCodingEditor.Data
{
    using LiveCodingEditor.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class LiveCodingEditorDbContext : DbContext
    {
        public LiveCodingEditorDbContext(DbContextOptions<LiveCodingEditorDbContext> options)
            : base(options)
        { }

        public DbSet<HtmlExample> HtmlExamples { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}