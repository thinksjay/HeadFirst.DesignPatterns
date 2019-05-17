using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Proxies;

namespace HeadFirst.DesignPatterns.Proxy
{

    /// <summary>
    /// 动态代理的实现。不应直接实例化，而应通过DynamicProxyFactory
    /// </summary>
    public class DynamicProxyImpl : RealProxy, IDynamicProxy, IRemotingTypeInfo {

        /// <summary>
        /// 我们作为其代理的对象
        /// </summary>
        private object proxyTarget;

        /// <summary>
        /// 我们应该严格要求接口支持吗？
        /// </summary>
        private bool strict;

        /// <summary>
        /// 我们支持的类型列表。仅在strict为true时使用。自动支持代理目标类型
        /// </summary>
        private Type[] supportedTypes;

        /// <summary>
        /// 用于处理方法调用进程的调用部分的委托
        /// </summary>
        private InvocationDelegate invocationHandler;

        /// <summary>
        /// 创建一个新的代理实例，以proxyTarget作为代理对象
        /// </summary>
        /// <param name="proxyTarget">要代理的对象</param>
        /// <param name="strict">类型支撑（用于铸件）应严格或宽松</param>
        /// <param name="supportedTypes">支持的类型列表。仅在strict为true时使用。可能为空</param>
        protected internal DynamicProxyImpl(object proxyTarget, InvocationDelegate invocationHandler, bool strict, Type[] supportedTypes) : base(typeof(IDynamicProxy)) {

            this.proxyTarget = proxyTarget;

            this.invocationHandler = invocationHandler;

            this.strict = strict;

            this.supportedTypes = supportedTypes;

        }

        /// <summary>
        /// 不支持 CreateObjRef()
        /// </summary>
        /// <param name="requestedType"></param>
        /// <returns>Nothing</returns>
        /// <exception cref="NotSupportedException">CreateObjRef() for DynamicProxy isn't supported</exception>
        public override ObjRef CreateObjRef(System.Type type) {

            throw new NotSupportedException("ObjRef for DynamicProxy isn't supported");
        }

        /// <summary>
        /// 检查是否可以将表示指定对象类型的代理强制转换为由IRemotingTypeInfo接口表示的类型
        /// </summary>
        /// <param name="toType">The Type we wish to cast to</param>
        /// <param name="obj">The object we wish to cast</param>
        /// <returns>True if the strict property is false, otherwise the list of supportedTypes is checked.<br>
        /// The proxy targets type(s) are automatically supported</br></returns>
        public bool CanCastTo(System.Type toType, object obj) {

            // Assume we can (which is the default unless strict is true)
            bool canCast = true;

            if (strict) {

                // First check if the proxyTarget supports the cast
                if (toType.IsAssignableFrom(proxyTarget.GetType())) {
                    canCast = true;
                } else if (supportedTypes != null) {

                    canCast = false;

                    // Check if the list of supported interfaces supports the cast
                    foreach(Type type in supportedTypes) {
                        if (toType == type) {
                            canCast = true;
                            break;
                        }
                    }
                } else {
                    canCast = false;
                }
            }

            return canCast;
        }

        /// <summary>
        /// 不支持TypeName，因为DynamicProxy不支持CreateObjRef（）。
        /// </summary>
        /// <exception cref="NotSupported">不支持动态代理的类型名</exception>
        public string TypeName {
            get { throw new System.NotSupportedException("TypeName for DynamicProxy isn't supported"); }
            set { throw new System.NotSupportedException("TypeName for DynamicProxy isn't supported"); }
        }

        /// <summary>
        /// 用于调用方法的反射方法。有关realproxy，请参阅文档。
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override System.Runtime.Remoting.Messaging.IMessage Invoke(System.Runtime.Remoting.Messaging.IMessage message) {

            // 转换为 MethodCallMessage
            System.Runtime.Remoting.Messaging.IMethodCallMessage methodMessage = new System.Runtime.Remoting.Messaging.MethodCallMessageWrapper((System.Runtime.Remoting.Messaging.IMethodCallMessage)message);

            // 提取正在调用的方法
            System.Reflection.MethodBase method = methodMessage.MethodBase;

            // 执行 call
            object returnValue = null;
            if (method.DeclaringType == typeof(IDynamicProxy)) {
                // 处理此实例而不是代理目标实例上的IDynamicProxy接口调用
                returnValue = method.Invoke(this, methodMessage.Args);
            } else {
                // 委托给调用处理程序
                returnValue = invocationHandler(proxyTarget, method, methodMessage.Args);
            }

            // 创建返回消息 (ReturnMessage)
            System.Runtime.Remoting.Messaging.ReturnMessage returnMessage = new System.Runtime.Remoting.Messaging.ReturnMessage(returnValue, methodMessage.Args, methodMessage.ArgCount, methodMessage.LogicalCallContext, methodMessage);
            return returnMessage;
        }

        /// <summary>
        /// 返回代理的目标对象
        /// </summary>
        public object ProxyTarget {
            get { return proxyTarget; }
            set { proxyTarget = value; }
        }

        /// <summary>
        /// 在动态代理中处理调用任务的委托
        /// </summary>
        public InvocationDelegate InvocationHandler {
            get { return invocationHandler; }
            set { invocationHandler = value; }
        }

        /// <summary>
        /// 类型支持严格性。用于铸件的严格性
        /// </summary>
        public bool Strict {
            get { return strict; }
            set { strict = value; }
        }

        /// <summary>
        /// 强制转换支持的支持类型列表。仅当strict为true时才检查
        /// </summary>
        public Type[] SupportedTypes {
            get { return supportedTypes; }
            set { supportedTypes = value; }
        }
    }
}