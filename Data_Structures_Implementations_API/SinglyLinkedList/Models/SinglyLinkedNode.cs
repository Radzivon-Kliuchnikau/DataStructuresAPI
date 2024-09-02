namespace Data_Structures_Implementations_API.SinglyLinkedList.Models;

public class Node<T>(T data)
{
    public T Data { get; set; } = data;

    public Node<T>? NextNode { get; set; } = null;
}