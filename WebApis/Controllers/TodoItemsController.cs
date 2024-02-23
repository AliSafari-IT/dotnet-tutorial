using Microsoft.AspNetCore.Mvc;

namespace WebApis.Models;

// Add TodoItemsController here 
public class TodoItemsController : ControllerBase {
    public TodoItemsController()
    {
    }

    // GET: api/TodoItems
    [HttpGet]
    public IEnumerable<TodoItem> Get() {
        return new List<TodoItem>() {
            new TodoItem() { Id = 1, Name = "Item1", IsComplete = false },
            new TodoItem() { Id = 2, Name = "Item2", IsComplete = false }
        };
    }

    // GET: api/TodoItems/5
    [HttpGet("{id}")]
    public TodoItem Get(int id) {
        return new TodoItem() { Id = 1, Name = "Item1", IsComplete = false };
    }

    // POST: api/TodoItems
    [HttpPost]
    public ActionResult<TodoItem> Post([FromBody] TodoItem todoItem)
    {
        todoItem.Id = 3; // hard coded id as we don't have a database yet
        return todoItem;
    }

}
 