namespace Data_Structures_Implementations_API.SinglyLinkedList.Models;

public class SinglyLinkedNode(int data)
{
    public int Id { get; set; }
    
    public int Data { get; set; } = data;

    public SinglyLinkedNode? NextNode { get; set; } = null;
}