using Data_Structures_Implementations_API.SinglyLinkedList.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Data_Structures_Implementations_API.SinglyLinkedList.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SinglyLinkedListController(ISinglyLinkedList singlyLinkedList) : ControllerBase
{
    [HttpPost]
    public IActionResult AddNode([FromBody] int data)
    {
        singlyLinkedList.AddNextNode(data);
        
        return Ok($"Data added: {data}");
    }

    [HttpGet]
    public IActionResult GetAllNodes()
    {
        return Ok(singlyLinkedList.GetAllNodes());
    }
}   