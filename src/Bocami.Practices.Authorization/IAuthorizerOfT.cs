namespace Bocami.Practices.Authorization
{
    public interface IAuthorizer<in T> 
        where T : class
    {
        void Authorize(T t);
    }
}
