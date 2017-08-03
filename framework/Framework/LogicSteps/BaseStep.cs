namespace Framework.LogicSteps
{
    public class BaseStep
    {
        public static void Start(string name)
        {
            Logger.Info("Step " + name + "is started");          
        }

        public static void Stop(string name)
        {
            Logger.Info("Step " + name + "is finshed");
        }
    }
}
