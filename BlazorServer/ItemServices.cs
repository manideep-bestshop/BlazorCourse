namespace BlazorServer
{
    public class ItemServices
    {
        public async Task<List<Item>> GetItemsAsync()
        {
            
            await Task.Delay(100); 

            return new List<Item>
        {
            new Item { Id = 1, Title = "Buy groceries", IsCompleted = false },
            new Item { Id = 2, Title = "Do laundry", IsCompleted = true },
            new Item { Id = 3, Title = "Clean the house", IsCompleted = false }
        };
        }
    }
}
