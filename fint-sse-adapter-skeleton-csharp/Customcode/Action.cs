namespace fint_sse_adapter_skeleton_csharp.Customcode
{
    public enum Action
    {
        HEALTH
    }

    public class ActionUtils
    {
        public static bool IsValidAction(string eventAction)
        {
            if(System.Enum.TryParse(eventAction, true, out Action action))
            {
                if (System.Enum.IsDefined(typeof(Action), action))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
