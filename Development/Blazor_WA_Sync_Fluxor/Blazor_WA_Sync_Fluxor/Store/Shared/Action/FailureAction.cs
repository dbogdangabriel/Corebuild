namespace Blazor_WA_Sync_Fluxor.Store.Shared.Action
{
    public class FailureAction
    {
        protected FailureAction(string errorMessage) =>
            ErrorMessage = errorMessage;
        public string ErrorMessage { get;}
    }
}
