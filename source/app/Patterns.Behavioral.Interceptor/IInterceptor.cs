namespace Patterns.Behavioral.Interceptor
{
    internal interface IInterceptor<in TContext> where TContext : class
    {
        void HandleEvent(TContext context, string search);
    }
}