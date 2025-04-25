import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HelperService {

  public generateGuid() : string
  {
    const guid = crypto.randomUUID();
    return guid;
  }

  public generateUniqueIdentifier() : number
  {
    const uniqueIdentiefier = Math.floor(Math.random() * 9999) + 1111;
    return uniqueIdentiefier;
  }

}
