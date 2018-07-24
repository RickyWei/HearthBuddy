﻿namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX06_Loatheb")]
    public class NAX06_Loatheb : NAX_MissionEntity
    {
        public NAX06_Loatheb(IntPtr address) : this(address, "NAX06_Loatheb")
        {
        }

        public NAX06_Loatheb(IntPtr address, string className) : base(address, className)
        {
        }

        public void InitEmoteResponses()
        {
            base.method_8("InitEmoteResponses", Array.Empty<object>());
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public bool m_cardLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_cardLinePlayed");
            }
        }

        public bool m_heroPowerLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPowerLinePlayed");
            }
        }
    }
}

