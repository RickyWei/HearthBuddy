﻿namespace Triton.Game.Mapping
{
    using System;

    public enum TAG_STEP
    {
        INVALID,
        BEGIN_FIRST,
        BEGIN_SHUFFLE,
        BEGIN_DRAW,
        BEGIN_MULLIGAN,
        MAIN_BEGIN,
        MAIN_READY,
        MAIN_RESOURCE,
        MAIN_DRAW,
        MAIN_START,
        MAIN_ACTION,
        MAIN_COMBAT,
        MAIN_END,
        MAIN_NEXT,
        FINAL_WRAPUP,
        FINAL_GAMEOVER,
        MAIN_CLEANUP,
        MAIN_START_TRIGGERS
    }
}

