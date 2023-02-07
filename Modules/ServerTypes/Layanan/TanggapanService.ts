import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { TanggapanRow } from "./TanggapanRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace TanggapanService {
    export const baseUrl = 'Layanan/Tanggapan';

    export declare function Create(request: SaveRequest<TanggapanRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TanggapanRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TanggapanRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TanggapanRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Layanan/Tanggapan/Create",
        Update: "Layanan/Tanggapan/Update",
        Delete: "Layanan/Tanggapan/Delete",
        Retrieve: "Layanan/Tanggapan/Retrieve",
        List: "Layanan/Tanggapan/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>TanggapanService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
