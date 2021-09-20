import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';

const routes: Routes = [
  {path: 'images', loadChildren: () => import('./pages/image/image.page.module').then(m => m.ImagePageModule)},
  {path: '', redirectTo: '/images', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
