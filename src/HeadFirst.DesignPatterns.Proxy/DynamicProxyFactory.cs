using System;

namespace HeadFirst.DesignPatterns.Proxy
{

    /// <summary>
    /// 用于创建动态代理实例的工厂
    /// <code>
    /// TestClasses.SimpleClass testClass = new TestClasses.SimpleClass();
    /// TestClasses.ISimpleInterface testClassProxy = (TestClasses.ISimpleInterface) DynamicProxyFactory.Instance.CreateProxy(testClass, new InvocationDelegate(InvocationHandler));
    /// testClassProxy.Method1();
    /// </code>
    /// <see cref="IDynamicProxy"/>
    /// </summary>
    public class DynamicProxyFactory {

        private static DynamicProxyFactory self = new DynamicProxyFactory();

        private DynamicProxyFactory() {

        }


        /// <summary>
        /// 获取工厂的实例（singleton）
        /// </summary>
        public static DynamicProxyFactory Instance {

            get { return self; }

        }



        /// <summary>
        /// 为目标对象创建代理
        /// </summary>
        /// <param name="target">要为其创建代理的对象</param>
        /// <param name="invocationHandler">代理的调用处理程序</param>
        /// <returns>动态代理实例</returns>
        public object CreateProxy(object target, InvocationDelegate invocationHandler) {
            return CreateProxy(target, invocationHandler, false, null);
        }



        /// <summary>
        /// 为目标对象创建代理
        /// </summary>
        /// <param name="target">要为其创建代理的对象</param>
        /// <param name="invocationHandler">代理的调用处理程序</param>
        /// <param name="strict">Indicates if the cast support should be strict. If strict is true all casts are checked before being performed</param>
        /// <returns>动态代理实例</returns>
        public object CreateProxy(object target, InvocationDelegate invocationHandler, bool strict) {

            return CreateProxy(target, invocationHandler, strict, null);

        }



        /// <summary>
        /// 为目标对象创建代理
        /// </summary>
        /// <param name="target">要为其创建代理的对象</param>
        /// <param name="invocationHandler">代理的调用处理程序</param>
        /// <param name="strict">Indicates if the cast support should be strict. If strict is true all casts are checked before being performed. The supportedType list will enabled support for more interfaces than the target object supports</param>
        /// <param name="supportedTypes">List of types that are supported for casts. Is only checked if strict is true.</param>
        /// <returns>动态代理实例</returns>
        public object CreateProxy(object target, InvocationDelegate invocationHandler, bool strict, Type[] supportedTypes) {

            return new DynamicProxyImpl(target, invocationHandler, strict, supportedTypes).GetTransparentProxy();
        }
    }

}
