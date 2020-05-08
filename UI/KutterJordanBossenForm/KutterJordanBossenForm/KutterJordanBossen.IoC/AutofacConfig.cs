using Autofac;

using System.Threading;

using KutterJordanBossenForm.Interfaces;

using KutterJordanBossenRepository;

using KutterJordanBossenServices;

namespace KutterJordanBossen.IoC
{
    public static class AutofacConfig
    {
        private static IContainer _container;
        private static ContainerBuilder _builder;

        static AutofacConfig()
        {
            _builder = new ContainerBuilder();
        }

        /// <summary>
        /// Registers types for the project
        /// </summary>
        public static void RegisterDependencies()
        {
            RegisterRepositories();
            RegisterServices();

            _container = _builder.Build();
        }

        /// <summary>
        /// Returns registered services
        /// </summary>
        /// <returns>instance of <seealso cref="TService"/> service</returns>
        public static TService GetService<TService>(this Thread context)
        {
            using (_container.BeginLifetimeScope())
            {
                return _container.Resolve<TService>();
            }
        }

        /// <summary>
        /// Registers services of business layer which get data from repositories
        /// </summary>
        private static void RegisterServices()
        {
            _builder.RegisterType<EncryptionService>().As<IEncryptionService>();
        }

        /// <summary>
        /// Registers repositories which interact with database
        /// </summary>
        private static void RegisterRepositories()
        {
            _builder.RegisterType<NativeRepository>().As<ICryptoRepository>();
        }
    }
}
