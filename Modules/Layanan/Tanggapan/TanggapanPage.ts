import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TanggapanGrid } from './TanggapanGrid';

$(function() {
    initFullHeightGridPage(new TanggapanGrid($('#GridDiv')).element);
});