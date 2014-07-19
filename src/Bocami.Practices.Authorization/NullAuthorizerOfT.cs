namespace Bocami.Practices.Authorization
{
    public class NullAuthorizer<T> : IAuthorizer<T> 
    {
        public void Authorize(T t)
        {
        }
    }
}
