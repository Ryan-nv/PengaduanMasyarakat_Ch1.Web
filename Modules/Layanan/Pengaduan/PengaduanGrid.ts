import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { Authorization } from '@serenity-is/corelib/q';
import { GridOptions } from '@serenity-is/sleekgrid';
import { PdfExportHelper } from '@serenity-is/extensions';
import { PengaduanColumns, PengaduanRow, PengaduanService } from '../../ServerTypes/Layanan';
import { PengaduanDialog } from './PengaduanDialog';

@Decorators.registerClass('PengaduanMasyarakat.Layanan.PengaduanGrid')
export class PengaduanGrid extends EntityGrid<PengaduanRow, any> {
    protected getColumnsKey() { return PengaduanColumns.columnsKey; }
    protected getDialogType() { return PengaduanDialog; }
    protected getIdProperty() { return PengaduanRow.idProperty; }
    protected getInsertPermission() { return PengaduanRow.insertPermission; }
    protected getLocalTextPrefix() { return PengaduanRow.localTextPrefix; }
    protected getService() { return PengaduanService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getSlickOptions(): GridOptions<any> {
        var options = super.getSlickOptions();
        options.rowHeight = 120;
        return options;
    }

    protected getButtons(): ToolButton[] {
        var btn = super.getButtons();
        if(Authorization.hasPermission("GeneratePdf")){
            btn.push(PdfExportHelper.createToolButton({
                grid: this, 
                onViewSubmit: () => this.onViewSubmit()
            }))
        }
        return btn
    }
}