namespace Bocami.Practices.Authorization
{
    public sealed class NullAuthorizer<T> : IAuthorizer<T> 
        where T : class
    {
        public void Authorize(T t)
        {
        }
    }
}
