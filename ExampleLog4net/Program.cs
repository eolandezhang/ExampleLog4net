using System;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ExampleLog4net
{
    class Program
    {
        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");
        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");
        static void Main(string[] args)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                loginfo.Info("info");
                logerror.Error("error", new Exception("a error happend"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
