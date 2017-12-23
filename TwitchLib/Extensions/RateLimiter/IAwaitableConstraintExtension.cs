﻿namespace TwitchLib.RateLimiter
{
    public static class IAwaitableConstraintExtension
    {
        public static IAwaitableConstraint Compose(this IAwaitableConstraint ac1, IAwaitableConstraint ac2)
        {
            if (ac1 == ac2)
            {
                return ac1;
            }

            return new ComposedAwaitableConstraint(ac1, ac2);
        }
    }
}
