using Data_Structures_Implementations_API.SinglyLinkedList.Models;
using Microsoft.EntityFrameworkCore;

namespace Data_Structures_Implementations_API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<SinglyLinkedNode> SinglyLinkedNodes { get; set; }
}