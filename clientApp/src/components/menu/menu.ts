﻿import {ChangeDetectionStrategy, Component, ViewEncapsulation} from "@angular/core";

@Component({
  templateUrl: 'menu.html',
  selector: 'Menu',
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
  styleUrls: ['menu.scss'],
  host: {
    class: 'menu'
  }
})
export class Menu {

}
