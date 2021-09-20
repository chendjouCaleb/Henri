import {Image} from "../entities";
import {HttpClient} from "@angular/common/http";
import {environment} from "../../environments/environment";
import {Injectable} from "@angular/core";

@Injectable({
  providedIn: 'root'
})
export class ImageRepository {
  constructor(private httpClient: HttpClient) {}

  url: string = `${ environment.serverUrl}/images`;

  async list(): Promise<Image[]> {
    const result = await this.httpClient.get<[]>(this.url).toPromise();
    return result.map(r => new Image(r));
  }
}
