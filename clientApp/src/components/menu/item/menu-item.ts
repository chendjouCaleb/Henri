﻿import {
  AfterViewInit,
  ChangeDetectionStrategy,
  Component,
  ElementRef,
  Input,
  ViewChild,
  ViewEncapsulation
} from "@angular/core";
import Iconify from '@iconify/iconify';

@Component({
  templateUrl: 'menu-item.html',
  selector: 'MenuItem',
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
  host: {
    class: 'menu-item',
    tabindex: '0'
  }
})
export class MenuItem implements AfterViewInit {
  @Input()
  icon: string;

  @ViewChild('iconContainer')
  iconContainer: ElementRef<HTMLElement>;

  ngAfterViewInit(): void {
    Iconify.loadIcons([this.icon], () => {
      const result = Iconify.renderSVG(this.icon, {width: 24, height: 24});

      if (result) {
        this.iconContainer.nativeElement.appendChild(result);
      }
    });
  }
}
