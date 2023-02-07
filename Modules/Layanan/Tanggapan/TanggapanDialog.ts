import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TanggapanForm, TanggapanRow, TanggapanService } from '../../ServerTypes/Layanan';

@Decorators.registerClass('PengaduanMasyarakat.Layanan.TanggapanDialog')
export class TanggapanDialog extends EntityDialog<TanggapanRow, any> {
    protected getFormKey() { return TanggapanForm.formKey; }
    protected getIdProperty() { return TanggapanRow.idProperty; }
    protected getLocalTextPrefix() { return TanggapanRow.localTextPrefix; }
    protected getNameProperty() { return TanggapanRow.nameProperty; }
    protected getService() { return TanggapanService.baseUrl; }
    protected getDeletePermission() { return TanggapanRow.deletePermission; }
    protected getInsertPermission() { return TanggapanRow.insertPermission; }
    protected getUpdatePermission() { return TanggapanRow.updatePermission; }

    protected form = new TanggapanForm(this.idPrefix);

}