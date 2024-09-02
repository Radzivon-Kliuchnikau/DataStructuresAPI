using Data_Structures_Implementations_API.Repository;
using Data_Structures_Implementations_API.SinglyLinkedList.Interfaces;
using Data_Structures_Implementations_API.SinglyLinkedList.Models;

namespace Data_Structures_Implementations_API.SinglyLinkedList.Services;

public class SinglyLinkedList(IRepository repository) : ISinglyLinkedList
{
    private SinglyLinkedNode? head;

    public void AddNextNode(int data)
    {
        var newNode = new SinglyLinkedNode(data);
        
        //head = context.GetHeadOfTheList();
        
        if (head == null)
        {
            head = newNode;
            
            repository.AddNextNode(head);
            return;
        }

        var currentNode = head;
        while (currentNode.NextNode != null)
        {
            currentNode = currentNode.NextNode;
        }

        currentNode.NextNode = newNode;
        // repository.UpdateNode()
        repository.AddNextNode(currentNode.NextNode);
    }

    public List<SinglyLinkedNode> GetAllNodes()
    {
        return repository.GetAllNodes();
    }
}