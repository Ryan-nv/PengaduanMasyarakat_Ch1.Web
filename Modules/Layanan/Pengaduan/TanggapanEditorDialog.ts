import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';
import { Authorization } from '@serenity-is/corelib/q';
import { GridEditorDialog } from '@serenity-is/extensions';
import { TanggapanRow, TanggapanService } from '../../ServerTypes/Layanan';
import { TanggapanEditorForm } from '../../ServerTypes/Layanan/TanggapanEditorForm'

@Decorators.registerClass('TanggapanEditDialog')
export class TanggapanEditorDialog extends GridEditorDialog<any> {
    protected getFormKey() { return TanggapanEditorForm.formKey; }
    protected getIdProperty() { return TanggapanRow.idProperty; }
    protected getLocalTextPrefix() { return TanggapanRow.localTextPrefix; }
    protected getNameProperty() { return TanggapanRow.nameProperty; }
    protected getService() { return TanggapanService.baseUrl; }
    protected getDeletePermission() { return TanggapanRow.deletePermission; }
    protected getInsertPermission() { return TanggapanRow.insertPermission; }
    protected getUpdatePermission() { return TanggapanRow.updatePermission; }

    protected form = new TanggapanEditorForm(this.idPrefix);

    protected updateInterface(): void {
        super.updateInterface()
        this.form.Tgl.value = new Date().toDateString();
        EditorUtils.setReadOnly(this.form.Petugas, true);
        this.form.Petugas.value = Authorization.username;
    }
}