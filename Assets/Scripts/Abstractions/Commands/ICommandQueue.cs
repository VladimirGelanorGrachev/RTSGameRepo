using System.Collections;

namespace Abstractions.Commands
{
    public interface ICommandQueue
    {
        void EnqueueCommand(object command);
        void Clear();
    }
}   
