import {NgModule} from "@angular/core";
import {HttpClientModule} from "@angular/common/http";
import {ImageRepository} from "./ImageRepository";

@NgModule({
  imports: [ HttpClientModule ],
  providers: [ ImageRepository ]
})
export class RepositoryModule {

}
