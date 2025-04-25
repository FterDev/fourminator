import { inject, Inject, Injectable } from '@angular/core';
import User from '../data/user';
import Session from '../data/session';
import { HelperService } from './helper-service.service';

@Injectable({
  providedIn: 'root'
})
export class SessionService {


  private storageItemName = 'fm-session';
  private helperService = inject(HelperService);

  setSession(nickname: string, remember: boolean)
  {
    const user = this.createNewUser(nickname);
    const session: Session = {
      user: user,
      remember: remember
    }

    session.remember == true ? localStorage.setItem(this.storageItemName, JSON.stringify(session)) : sessionStorage.setItem(this.storageItemName, JSON.stringify(session));

  }

  deleteSession()
  {
    const sessionLocalStorage = localStorage.getItem(this.storageItemName) != null;

    sessionLocalStorage == true ? localStorage.removeItem(this.storageItemName) : sessionStorage.removeItem(this.storageItemName);
  }

  private createNewUser(nickname: string) : User
  {
    const newUser: User = {
      guid: this.helperService.generateGuid(),
      deviceId: '',
      location: '',
      nickname: nickname,
      uniqueIdentifier: this.helperService.generateUniqueIdentifier()
    }

    return newUser;
  }


}
