using BLL;
using DAL;
using IBLL;
using IDAL;
using Models;
using RepositorySystemInterface.Controllers;
using System;

using Unity;

namespace RepositorySystemInterface
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();

            // 注册用户表的DAL和BLL
            container.RegisterType<IUserInfoDAL,UserInfoDAL>();
            container.RegisterType<IUserInfoBLL, UserInfoBLL>();

            container.RegisterType<IDepartmentInfoDAL, DepartmentInfoDAL>();
            container.RegisterType<IDepartmentInfoBLL, DepartmentInfoBLL>();

            container.RegisterType<IRoleInfoDAL, RoleInfoDAL>();
            container.RegisterType<IRoleInfoBLL, RoleInfoBLL>();

            container.RegisterType<IR_UserInfo_RoleInfoDAL, R_UserInfo_RoleInfoDAL>();
    
            container.RegisterType<IMenuInfoBLL, MenuInfoBLL>();
            container.RegisterType<IMenuInfoDAL, MenuInfoDAL>();

            container.RegisterType<IR_RoleInfo_MenuInfoDAL, R_RoleInfo_MenuInfoDAL>();

            container.RegisterType<ICategoryDAL, CategoryDAL>();
            container.RegisterType<ICategoryBLL, CategoryBLL>();

            container.RegisterType<IConsumableRecordDAL, ConsumableRecordDAL>();
            container.RegisterType<IConsumableRecordBLL, ConsumableRecordBLL>();

            container.RegisterType<IConsumableInfoDAL, ConsumableInfoDAL>();
            container.RegisterType<IConsumableInfoBLL, ConsumableInfoBLL>();

            container.RegisterType<IWorkFlow_ModelDAL, WorkFlow_ModelDAL>();
            container.RegisterType<IWorkFlow_ModelBLL, WorkFlow_ModelBLL>();

            container.RegisterType<IWorkFlow_InstanceDAL, WorkFlow_InstanceDAL>();
            container.RegisterType<IWorkFlow_InstanceBLL, WorkFlow_InstanceBLL>();

            container.RegisterType<IWorkFlow_InstanceStepDAL, WorkFlow_InstanceStepDAL>();
            container.RegisterType<IWorkFlow_InstanceStepBLL, WorkFlow_InstanceStepBLL>();
        }
    }
}