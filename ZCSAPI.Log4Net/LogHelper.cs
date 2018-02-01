using System;

namespace ZCSAPI.Log4Net
{
    public class LogHelper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().ReflectedType);

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="type">出错类的类型</param>
        /// <param name="message">信息</param>
        public static void WriteLog(Type type, string message)
        {
            log4net.LogManager.GetLogger(type).Error(message);
        }

        /// <summary>
        /// 调试信息
        /// </summary>
        /// <param name="message">信息</param>
        public static void Debug(string message)
        {
            if (log.IsDebugEnabled)
            {
                log.Debug(message);
            }
        }

        /// <summary>
        /// 一般信息
        /// </summary>
        /// <param name="message">信息</param>
        public static void Info(string message)
        {
            if (log.IsInfoEnabled)
            {
                log.Info(message);
            }
        }

        /// <summary>
        /// 警告信息
        /// </summary>
        /// <param name="message">信息</param>
        public static void Warn(string message)
        {
            if (log.IsWarnEnabled)
            {
                log.Warn(message);
            }
        }

        /// <summary>
        ///  一般错误信息
        /// </summary>
        /// <param name="message">信息</param>
        public static void Error(string message)
        {
            if (log.IsErrorEnabled)
            {
                log.Error(message);
            }
        }

        /// <summary>
        /// 致命错误信息
        /// </summary>
        /// <param name="message">信息</param>
        public static void Fatal(string message)
        {
            if (log.IsFatalEnabled)
            {
                log.Fatal(message);
            }
        }
    }
}
