﻿namespace Lockstep.Game.Features.Input
{
    sealed class InputFeature : Feature
    {
        public InputFeature(Contexts contexts, ServiceContainer services) : base("Input")
        {
            //TODO: Add InputValidationSystem  
            Add(new ExecuteSpawnInput(contexts, services));
            Add(new VerifySelectionIdExists(contexts));
            Add(new ExecuteNavigationInput(contexts, services));
            //TODO: Add CleanupInput that removes input of validated frames (no rollback required => can be removed)
        }
    }
}
