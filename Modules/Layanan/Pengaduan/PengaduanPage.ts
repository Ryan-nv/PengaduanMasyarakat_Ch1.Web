import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { PengaduanGrid } from './PengaduanGrid';

$(function() {
    initFullHeightGridPage(new PengaduanGrid($('#GridDiv')).element);
});