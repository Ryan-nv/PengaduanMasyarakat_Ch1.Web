import { StringEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TanggapanEditorForm {
    Tanggapan: StringEditor;
    Tgl: DateEditor;
    Petugas: StringEditor;
}

export class TanggapanEditorForm extends PrefixedContext {
    static formKey = 'Layanan.TanggapanEditor';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TanggapanEditorForm.init)  {
            TanggapanEditorForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;

            initFormType(TanggapanEditorForm, [
                'Tanggapan', w0,
                'Tgl', w1,
                'Petugas', w0
            ]);
        }
    }
}
