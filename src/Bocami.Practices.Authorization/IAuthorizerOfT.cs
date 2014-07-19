namespace Bocami.Practices.Authorization
{
    public interface IAuthorizer<in T> 
    {
        void Authorize(T t);
    }
}
