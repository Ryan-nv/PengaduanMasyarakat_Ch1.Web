import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TanggapanRow {
    Id?: number;
    IdPengaduan?: number;
    Tgl?: string;
    Tanggapan?: string;
    IdPetugas?: number;
    IdPengaduanTanggal?: string;
    IdPengaduanUserId?: number;
    IdPengaduanLaporan?: string;
    IdPengaduanGambar?: string;
    IdPengaduanStatus?: number;
}

export abstract class TanggapanRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Tanggapan';
    static readonly localTextPrefix = 'Layanan.Tanggapan';
    static readonly deletePermission = 'Tanggapan:Modify';
    static readonly insertPermission = 'Tanggapan:Modify';
    static readonly readPermission = 'Tanggapan:Read';
    static readonly updatePermission = 'Tanggapan:Modify';

    static readonly Fields = fieldsProxy<TanggapanRow>();
}
