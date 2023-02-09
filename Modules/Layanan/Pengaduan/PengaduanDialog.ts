import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';
import { Authorization, EditorAttribute } from '@serenity-is/corelib/q';
import { TextEditor } from '@serenity-is/sleekgrid';
import { PengaduanForm, PengaduanRow, PengaduanService } from '../../ServerTypes/Layanan';

@Decorators.registerClass('PengaduanMasyarakat.Layanan.PengaduanDialog')
export class PengaduanDialog extends EntityDialog<PengaduanRow, any> {
    protected getFormKey() { return PengaduanForm.formKey; }
    protected getIdProperty() { return PengaduanRow.idProperty; }
    protected getLocalTextPrefix() { return PengaduanRow.localTextPrefix; }
    protected getNameProperty() { return PengaduanRow.nameProperty; }
    protected getService() { return PengaduanService.baseUrl; }
    protected getDeletePermission() { return PengaduanRow.deletePermission; }
    protected getInsertPermission() { return PengaduanRow.insertPermission; }
    protected getUpdatePermission() { return PengaduanRow.updatePermission; }

    protected form = new PengaduanForm(this.idPrefix);
    
    protected updateInterface(): void {
        super.updateInterface();
        this.form.Tanggal.value = new Date().toDateString();
        EditorUtils.setReadOnly(this.form.Username, true);
        this.form.Username.value = Authorization.username;
    }
    protected afterLoadEntity(): void {
        super.afterLoadEntity();
        if(!Authorization.hasPermission("Pengaduan:SetStatus")){
            this.form.Status.getGridField().toggle(false);
        }
        else if(!Authorization.hasPermission("Pengaduan:Insert")){
            EditorUtils.setReadOnly(this.form.Gambar,true);
            EditorUtils.setReadOnly(this.form.Tanggal,true);
            EditorUtils.setReadOnly(this.form.Laporan,true);
            EditorUtils.setReadOnly(this.form.Username,true);
        }
    }
}