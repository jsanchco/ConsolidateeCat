namespace eCat.Repository.Common
{
    #region Using

    using System;

    #endregion

    public class RepositoryBase : IDisposable
    {
        #region Members

        private bool _disposed;
        protected readonly Context Context;

        #endregion

        #region Constuctor

        public RepositoryBase()
        {
            Context = new Context();
        }

        public RepositoryBase(string connectionString)
        {
            Context = new Context(connectionString);
        }

        #endregion

        #region Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
