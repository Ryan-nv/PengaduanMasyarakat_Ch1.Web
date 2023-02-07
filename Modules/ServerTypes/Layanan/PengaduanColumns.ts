import { InlineImageFormatter } from "@/Layanan/Pengaduan/InlineImageFormatter";
import { StatusFormatter } from "@/Layanan/Pengaduan/StatusFormatter";
import { StatusEnum } from "./StatusEnum";

export class PengaduanColumns {
    static columnsKey = 'Layanan.Pengaduan';
}

[InlineImageFormatter, StatusFormatter, StatusEnum]; // referenced types
