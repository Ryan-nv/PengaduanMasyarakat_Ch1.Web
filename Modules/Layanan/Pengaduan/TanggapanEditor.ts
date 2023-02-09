import { Decorators } from '@serenity-is/corelib';
import { GridEditorBase } from '@serenity-is/extensions';
import { TanggapanColumns, TanggapanRow, TanggapanService } from '../../ServerTypes/Layanan';
import { TanggapanEditorDialog } from './TanggapanEditorDialog';

@Decorators.registerEditor('TanggapanEditor')
export class TanggapanEditor extends GridEditorBase<TanggapanRow, any> {
    protected getColumnsKey() { return TanggapanColumns.columnsKey; }
    protected getDialogType() { return TanggapanEditorDialog; }
    protected getIdProperty() { return TanggapanRow.idProperty; }
    protected getInsertPermission() { return TanggapanRow.insertPermission; }
    protected getLocalTextPrefix() { return TanggapanRow.localTextPrefix; }
    protected getService() { return TanggapanService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}