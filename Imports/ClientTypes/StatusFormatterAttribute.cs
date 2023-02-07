using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PengaduanMasyarakat
{
    public partial class StatusFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "StatusFormatter";

        public StatusFormatterAttribute()
            : base(Key)
        {
        }
    }
}
