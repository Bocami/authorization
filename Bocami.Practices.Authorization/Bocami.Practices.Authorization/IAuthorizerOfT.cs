namespace Bocami.Practices.Authorization
{
    public interface IAuthorizer<T> 
        where T : class
    {
        void Authorize(T t);
    }
}
