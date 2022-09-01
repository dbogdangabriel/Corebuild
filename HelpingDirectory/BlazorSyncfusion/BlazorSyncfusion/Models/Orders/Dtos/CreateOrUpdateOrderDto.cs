namespace BlazorSyncfusion.Models.Orders.Dtos
{
    public class CreateOrUpdateOrderDto
    {
        public CreateOrUpdateOrderDto(string title, bool completed, int userId) =>
            (Title, Completed, UserId) = (title, completed, userId);
        public string Title { get; }
        public bool Completed { get; }
        public int UserId { get; }
    }
}
