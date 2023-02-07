import { Decorators } from "@serenity-is/corelib";

export enum StatusEnum {
    Diproses = 1,
    Disetujui = 2,
    Ditolak = 3
}
Decorators.registerEnumType(StatusEnum, 'PengaduanMasyarakat.Layanan.StatusEnum', 'Layanan.StatusEnum');
