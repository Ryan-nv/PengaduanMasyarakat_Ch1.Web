import { StatusEnum } from "./StatusEnum";
import { TanggapanRow } from "./TanggapanRow";
import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface PengaduanRow {
    Id?: number;
    Tanggal?: string;
    UserId?: number;
    Laporan?: string;
    Gambar?: string;
    Status?: StatusEnum;
    Tanggapan?: TanggapanRow[];
    Username?: string;
}

export abstract class PengaduanRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Laporan';
    static readonly localTextPrefix = 'Layanan.Pengaduan';
    static readonly lookupKey = 'Layanan.Pengaduan';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PengaduanRow>('Layanan.Pengaduan') }
    static async getLookupAsync() { return getLookupAsync<PengaduanRow>('Layanan.Pengaduan') }

    static readonly deletePermission = 'Pengaduan:Delete';
    static readonly insertPermission = 'Pengaduan:Insert';
    static readonly readPermission = 'Pengaduan:Read';
    static readonly updatePermission = 'Pengaduan:Update';

    static readonly Fields = fieldsProxy<PengaduanRow>();
}
