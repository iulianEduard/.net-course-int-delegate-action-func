using System;

namespace Delegate_Action_Func.Core
{
    public class DisplayMessage
    {
        public void Handle(Action<string> action, string message)
        {
            action(message);
        }
    }
}
