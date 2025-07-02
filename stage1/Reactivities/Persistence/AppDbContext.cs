using System;   
using System.Diagnostics;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    // Domain. video'da yok..!
    public required DbSet<Domain.Activity> Activities { get; set; }
}