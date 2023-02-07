import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { PengaduanRow } from "./PengaduanRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace PengaduanService {
    export const baseUrl = 'Layanan/Pengaduan';

    export declare function Create(request: SaveRequest<PengaduanRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<PengaduanRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PengaduanRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PengaduanRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Layanan/Pengaduan/Create",
        Update: "Layanan/Pengaduan/Update",
        Delete: "Layanan/Pengaduan/Delete",
        Retrieve: "Layanan/Pengaduan/Retrieve",
        List: "Layanan/Pengaduan/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PengaduanService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
