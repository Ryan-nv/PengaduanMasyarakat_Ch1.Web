import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TanggapanColumns, TanggapanRow, TanggapanService } from '../../ServerTypes/Layanan';
import { TanggapanDialog } from './TanggapanDialog';

@Decorators.registerClass('PengaduanMasyarakat.Layanan.TanggapanGrid')
export class TanggapanGrid extends EntityGrid<TanggapanRow, any> {
    protected getColumnsKey() { return TanggapanColumns.columnsKey; }
    protected getDialogType() { return TanggapanDialog; }
    protected getIdProperty() { return TanggapanRow.idProperty; }
    protected getInsertPermission() { return TanggapanRow.insertPermission; }
    protected getLocalTextPrefix() { return TanggapanRow.localTextPrefix; }
    protected getService() { return TanggapanService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}