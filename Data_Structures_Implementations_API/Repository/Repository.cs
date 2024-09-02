using Data_Structures_Implementations_API.Data;
using Data_Structures_Implementations_API.SinglyLinkedList.Models;

namespace Data_Structures_Implementations_API.Repository;

public class Repository(ApplicationDbContext context) : IRepository
{
    public void AddNextNode(SinglyLinkedNode data)
    {
        context.SinglyLinkedNodes.Add(data);
        context.SaveChanges();
    }

    public List<SinglyLinkedNode> GetAllNodes()
    {
        return context.SinglyLinkedNodes.ToList();
    }

    public SinglyLinkedNode? GetById(int id)
    {
        var singlyLinkedNode = context.SinglyLinkedNodes.FirstOrDefault(node => node.Id == id);
        
        return singlyLinkedNode;
    }
}