import {NgModule} from "@angular/core";
import {CommonModule} from "@angular/common";
import {MenuItem} from "./item/menu-item";
import {Menu} from "./menu";

@NgModule({
  imports: [ CommonModule ],
  declarations: [ Menu, MenuItem ],
  exports: [ Menu, MenuItem ]
})
export class MenuModule {

}
