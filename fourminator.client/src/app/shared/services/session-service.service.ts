import { Injectable } from '@angular/core';
import User from '../data/user';
import Session from '../data/session';

@Injectable({
  providedIn: 'root'
})
export class SessionServiceService {


  private storageItemName = 'fm-session';

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
      guid: '',
      deviceId: '',
      location: '',
      nickname: nickname,
      uniqueIdentifier: 1234
    }

    return newUser;
  }


}
