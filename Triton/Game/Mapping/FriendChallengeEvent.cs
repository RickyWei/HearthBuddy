﻿namespace Triton.Game.Mapping
{
    using System;

    public enum FriendChallengeEvent
    {
        I_SENT_CHALLENGE,
        I_RESCINDED_CHALLENGE,
        OPPONENT_ACCEPTED_CHALLENGE,
        OPPONENT_DECLINED_CHALLENGE,
        I_RECEIVED_CHALLENGE,
        I_ACCEPTED_CHALLENGE,
        I_DECLINED_CHALLENGE,
        OPPONENT_RESCINDED_CHALLENGE,
        SELECTED_DECK,
        DESELECTED_DECK,
        OPPONENT_CANCELED_CHALLENGE,
        OPPONENT_REMOVED_FROM_FRIENDS
    }
}

