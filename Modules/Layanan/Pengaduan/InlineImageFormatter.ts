import {Formatter, Decorators } from '@serenity-is/corelib';
import { resolveUrl } from '@serenity-is/corelib/q';
import { FormatterContext } from '@serenity-is/sleekgrid';

@Decorators.registerFormatter("InlineImageFormatter")
export class InlineImageFormatter implements Formatter {
    format(ctx: FormatterContext<any>): string {
        var src = resolveUrl("~/upload/" + ctx.value);
        return `<img src="${src}" alt="image" class="h-100 img-cover">`
    }
}