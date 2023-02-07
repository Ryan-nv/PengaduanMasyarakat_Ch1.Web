import {Formatter, Decorators } from '@serenity-is/corelib';
import { resolveUrl } from '@serenity-is/corelib/q';
import { FormatterContext } from '@serenity-is/sleekgrid';

@Decorators.registerFormatter("StatusFormatter")
export class StatusFormatter implements Formatter {
    format(ctx: FormatterContext<any>): string {
        switch (ctx.value) {
            case 1 :
                return `<p class="bg-warning p-1 rounded text-white"><i class="fa fa-clock-o"></i> Diproses</p>`;
            case 2 :
                return `<p class="bg-success p-1 rounded text-white"><i class="fa fa-check-circle-o"></i> Disetujui</p>`;
            case 3 :
                return `<p class="bg-danger p-1 rounded text-white"><i class="fa fa-times-circle-o"></i> Ditolak</p>`;
            default :
                return `<p class="bg-disabled p-1 rounded text-white"><i class="fa fa-circle-thins"></i> None</p>`;
        }
        
    }
}