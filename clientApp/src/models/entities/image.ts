import * as moment from 'moment';

export class Image {
  id: string;
  repository: string;
  containers: string;
  createdAt: Date;
  createdSince: string;
  digest: string;
  sharedSize: string;
  size: string;
  tag: string;
  uniqueSize: string;
  virtualSize: string;

  constructor(value: any = {}) {
    this.id = value.id;
    this.repository = value.repository;
    this.containers = value.containers;
    this.createdAt = moment(value.createdAt.toString().replace('WAT', '')).toDate();
    this.createdSince = value.createdSince;
    this.digest = value.digest;
    this.sharedSize = value.sharedSize;
    this.size = value.size;
    this.tag = value.tag;
    this.uniqueSize = value.uniqueSize;
    this.virtualSize = value.virtualSize;
  }
}
