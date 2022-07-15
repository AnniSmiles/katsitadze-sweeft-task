using System.Data.Entity;

class Pupil
{
    public Pupil()
    {
        this.Teachers = new HashSet<Teacher>();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string LName { get; set; }
    public string Gender { get; set; }
    public string Subject { get; set; }
    public virtual ICollection<Teacher> Teachers { get; set; }

}

class Teacher
{
    public Teacher()
    {
        this.Pupils = new HashSet<Pupil>();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string LName { get; set; }
    public string Gender { get; set; }
    public string Class { get; set; }
    public virtual ICollection<Pupil> Pupils { get; set; }
}

class MyDbContext: DbContext
{
    public DbSet<Pupil> Pupils { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

