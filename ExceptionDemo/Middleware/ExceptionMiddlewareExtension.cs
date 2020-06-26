using Microsoft.AspNetCore.Builder;

namespace ExceptionDemo.Middleware
{
    /// <summary>
    /// 静态类
    /// </summary>
    public static class ExceptionMiddlewareExtension
    {
        /// <summary>
        /// 静态方法
        /// </summary>
        /// <param name="app">要进行扩展的类型</param>
        public static void UseExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware(typeof(CustomerExceptionMiddleware));
        }
    }
}
