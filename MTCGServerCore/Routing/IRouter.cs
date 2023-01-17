using MTCGServerCore.Request;

namespace MTCGServerCore.Routing
{
    public interface IRouter
    {
        IRouteCommand? Resolve(RequestContext request);
    }
}