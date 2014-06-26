namespace Bocami.Practices.Authorization
{
    public class NullAuthorizer<T> : IAuthorizer<T> 
        where T : class
    {
        public void Authorize(T t)
        {
        }
    }
}
