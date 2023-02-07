using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PengaduanMasyarakat
{
    public partial class InlineImageFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "InlineImageFormatter";

        public InlineImageFormatterAttribute()
            : base(Key)
        {
        }
    }
}
