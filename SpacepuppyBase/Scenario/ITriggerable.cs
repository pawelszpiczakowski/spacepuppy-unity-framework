﻿namespace com.spacepuppy.Scenario
{

    public interface ITriggerableMechanism : IComponent
    {

        int Order { get; }
        bool CanTrigger { get; }
        bool Trigger(object sender, object arg);

    }

    public interface IBlockingTriggerableMechanism : ITriggerableMechanism
    {
        
        bool Trigger(object sender, object arg, BlockingTriggerYieldInstruction instruction);

    }
    
}
