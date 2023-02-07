import { LookupEditor, DateEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TanggapanForm {
    IdPengaduan: LookupEditor;
    Tgl: DateEditor;
    Tanggapan: StringEditor;
    IdPetugas: LookupEditor;
}

export class TanggapanForm extends PrefixedContext {
    static formKey = 'Layanan.Tanggapan';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TanggapanForm.init)  {
            TanggapanForm.init = true;

            var w0 = LookupEditor;
            var w1 = DateEditor;
            var w2 = StringEditor;

            initFormType(TanggapanForm, [
                'IdPengaduan', w0,
                'Tgl', w1,
                'Tanggapan', w2,
                'IdPetugas', w0
            ]);
        }
    }
}
