using System.Collections.Generic;

namespace Patterns.Behavioral.Interceptor
{
    internal class SearchDispatcher<TContext> where TContext : class
    {
        private readonly HashSet<IInterceptor<TContext>> _interceptors;

        public SearchDispatcher()
        {
            _interceptors = new HashSet<IInterceptor<TContext>>();
        }

        public void Register(IInterceptor<TContext> interceptor)
        {
            _interceptors.Add(interceptor);
        }

        public void DeRegister(IInterceptor<TContext> interceptor)
        {
            _interceptors.Remove(interceptor);
        }

        public void Dispatch(TContext context, string search)
        {
            foreach (var interceptor in _interceptors)
            {
                interceptor.HandleEvent(context, search);
            }
        }
    }
}