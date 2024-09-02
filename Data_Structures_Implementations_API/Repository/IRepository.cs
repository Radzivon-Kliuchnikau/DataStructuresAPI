using Data_Structures_Implementations_API.SinglyLinkedList.Models;

namespace Data_Structures_Implementations_API.Repository;

public interface IRepository
{
    void AddNextNode(SinglyLinkedNode data);

    List<SinglyLinkedNode> GetAllNodes();

    SinglyLinkedNode? GetById(int id);
}