// TodoDbContext.cs
using WebApis.Models;

namespace WebApis.Data;

// DTO = Data Transfer Object
// The DTO is a simple representation of the entity 
// that is used to transfer data between the client and the server.
// We use it to avoid exposing the entity to the client,
// and to avoid sending unnecessary data over the network.
public class TodoItemDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }

}
