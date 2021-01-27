using Microsoft.Practices.Prism.Regions;

namespace PrismScopedRegions.Infrastructure.Prism
{
    public interface IRegionManagerAware
    {
        IRegionManager RegionManager { get; set; }
    }
}
