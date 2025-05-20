import { Injectable } from "@angular/core";

@Injectable({
  providedIn: 'root'
})
export default class UserService {
  private user: any = null;
  private userLevel: number = 3;

  constructor() {
    this.user = JSON.parse(localStorage.getItem('user') || 'null');
    this.userLevel = JSON.parse(localStorage.getItem('userLevel') || '2');
  }

  setUser(user: any) {
    this.user = user;
    localStorage.setItem('user', JSON.stringify(user));
  }

  getUser() {
    return this.user;
  }

  setUserLevel(userLevel: number) {
    this.userLevel = userLevel;
    localStorage.setItem('userLevel', JSON.stringify(userLevel));
  }

  getUserLevel() {
    return this.userLevel;
  }
}
