using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PengaduanMasyarakat
{
    public partial class TanggapanEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "TanggapanEditor";

        public TanggapanEditorAttribute()
            : base(Key)
        {
        }
    }
}
