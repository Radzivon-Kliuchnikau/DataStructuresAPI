using Data_Structures_Implementations_API.SinglyLinkedList.Models;

namespace Data_Structures_Implementations_API.SinglyLinkedList.Interfaces;

public interface ISinglyLinkedList
{
    void AddNextNode(int data);

    List<SinglyLinkedNode> GetAllNodes();
}