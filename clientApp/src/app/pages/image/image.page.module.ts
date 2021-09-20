import {NgModule} from "@angular/core";
import {CommonModule} from "@angular/common";
import {ImageListPage} from "./list/image-list.page";
import {RouterModule, Routes} from "@angular/router";
import {MsButtonModule, MsContextMenuModule, MsDropdownModule, MsTableModule} from "@ms-fluent/components";
import {OverlayModule} from "@angular/cdk/overlay";

const routes: Routes = [
  {path: '', component: ImageListPage}
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(routes), MsTableModule, MsButtonModule, OverlayModule,
    MsDropdownModule, MsContextMenuModule],
  declarations: [ImageListPage]
})
export class ImagePageModule {

}
