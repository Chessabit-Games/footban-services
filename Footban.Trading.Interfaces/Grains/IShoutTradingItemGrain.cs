using System.Threading.Tasks;
using Orleans;
using Footban.Trading.Interfaces.Observerables;

namespace Footban.Trading.Interfaces.Grains
{
    /// <summary>
    /// Grain interface IGrain1
    /// </summary>
	public interface IShoutTradingItemGrain : ITradingItemGrain<IShoutItemObserver>, IGrainWithGuidKey
    {

    }
}
    