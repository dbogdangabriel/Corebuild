using FluxorWithBlazor.State;
using FluxorWithBlazor.State.Weather;

namespace FluxorWithBlazor.Pages
{
	public partial class FetchData
	{

        protected override void OnInitialized()
        {
            base.OnInitialized();
            dispatcher.Dispatch(new FetchDataAction());
        }
    }
}
