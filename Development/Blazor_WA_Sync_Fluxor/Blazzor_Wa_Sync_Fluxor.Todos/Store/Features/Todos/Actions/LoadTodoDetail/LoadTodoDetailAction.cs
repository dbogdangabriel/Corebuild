namespace Blazzor_Wa_Sync_Fluxor.Todos.Store.Features.Todos.Actions.LoadTodoDetail
{
    public class LoadTodoDetailAction
    {
        public LoadTodoDetailAction(int id) =>
            Id = id;

        public int Id { get; set; }
    }
}
