import { DateEditor, LookupEditor, StringEditor, ImageUploadEditor, EnumEditor, PrefixedContext } from "@serenity-is/corelib";
import { StatusEnum } from "./StatusEnum";
import { initFormType } from "@serenity-is/corelib/q";

export interface PengaduanForm {
    Tanggal: DateEditor;
    UserId: LookupEditor;
    Laporan: StringEditor;
    Gambar: ImageUploadEditor;
    Status: EnumEditor;
}

export class PengaduanForm extends PrefixedContext {
    static formKey = 'Layanan.Pengaduan';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PengaduanForm.init)  {
            PengaduanForm.init = true;

            var w0 = DateEditor;
            var w1 = LookupEditor;
            var w2 = StringEditor;
            var w3 = ImageUploadEditor;
            var w4 = EnumEditor;

            initFormType(PengaduanForm, [
                'Tanggal', w0,
                'UserId', w1,
                'Laporan', w2,
                'Gambar', w3,
                'Status', w4
            ]);
        }
    }
}

[StatusEnum]; // referenced types
