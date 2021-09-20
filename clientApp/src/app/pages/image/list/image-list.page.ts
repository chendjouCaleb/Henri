import {Component, OnInit, ViewChild} from "@angular/core";
import {Image, ImageRepository} from "@henri/models";
import {MsTable} from "@ms-fluent/components";

@Component({
  templateUrl: 'image-list.page.html'
})
export class ImageListPage implements OnInit {
  images: Image[] = [];

  @ViewChild(MsTable)
  table: MsTable;

  constructor(private repository: ImageRepository) {
  }

  ngOnInit(): void {
    this.repository.list().then(images => {
      this.table.unshift(...images);
    })
  }
}
