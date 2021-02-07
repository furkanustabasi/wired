namespace Wired.Service.Mapster
{
    public interface IMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);
    }
}
