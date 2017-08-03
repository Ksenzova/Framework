using System.Reflection;

namespace Framework.LogicSteps
{
    public class BaseStep
    {
        public static void Start()
        {
            Logger.Info("Step " + MethodBase.GetCurrentMethod().Name + "is started");          
        }

        public static void Stop()
        {
            Logger.Info("Step " + MethodBase.GetCurrentMethod().Name + "is ended");
        }
    }
}
