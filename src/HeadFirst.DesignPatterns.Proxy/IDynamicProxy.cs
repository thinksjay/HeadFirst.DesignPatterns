using System;
using System.Reflection;
using System.Runtime.Remoting;

namespace HeadFirst.DesignPatterns.Proxy
{

    /// <summary>
    /// 用于在动态代理中实现调用任务的委托
    /// </summary>
    public delegate object InvocationDelegate(object target, MethodBase method, object[] parameters);



    /// <summary>
    /// 动态代理的接口。通过这个接口，您可以在代理实例上工作。
    /// </summary>
    public interface IDynamicProxy
    {

        /// <summary>
        /// 代理的目标对象（aka.代理对象）
        /// </summary>
        object ProxyTarget
        {
            get;
            set;
        }

        /// <summary>
        /// 在动态代理中处理调用任务的委托
        /// </summary>
        InvocationDelegate InvocationHandler
        {
            get;
            set;
        }

        /// <summary>
        /// Type support strictness. Used for cast strictness
        /// </summary>
        bool Strict
        {
            get;
            set;
        }

        /// <summary>
        /// 强制转换支持的类型列表。仅当strict为true时才检查
        /// </summary>
        Type[] SupportedTypes
        {
            get;
            set;
        }
    }
}