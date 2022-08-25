using Fluxor;
using FluxorWithBlazor.State;
using FluxorWithBlazor.State.Counter;
using Microsoft.AspNetCore.Components;

namespace FluxorWithBlazor.Pages
{
    public partial class Counter
    {
        [Inject]
        private IState<CounterState> CounterState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        private void IncrementCount()
        {
            var action = new IncrementCounterAction();
            Dispatcher.Dispatch(action);
        }
    }
}
