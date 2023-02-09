import { StringEditor, DateEditor, ImageUploadEditor, EnumEditor, PrefixedContext } from "@serenity-is/corelib";
import { StatusEnum } from "./StatusEnum";
import { TanggapanEditor } from "@/Layanan/Pengaduan/TanggapanEditor";
import { initFormType } from "@serenity-is/corelib/q";

export interface PengaduanForm {
    Laporan: StringEditor;
    Tanggal: DateEditor;
    Username: StringEditor;
    Gambar: ImageUploadEditor;
    Status: EnumEditor;
    Tanggapan: TanggapanEditor;
}

export class PengaduanForm extends PrefixedContext {
    static formKey = 'Layanan.Pengaduan';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PengaduanForm.init)  {
            PengaduanForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = ImageUploadEditor;
            var w3 = EnumEditor;
            var w4 = TanggapanEditor;

            initFormType(PengaduanForm, [
                'Laporan', w0,
                'Tanggal', w1,
                'Username', w0,
                'Gambar', w2,
                'Status', w3,
                'Tanggapan', w4
            ]);
        }
    }
}

[StatusEnum]; // referenced types
