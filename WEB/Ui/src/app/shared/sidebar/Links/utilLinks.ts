import {UserLinks} from './userlinks';
import { LocalAdminLinks } from './localAdminLinks';
import { SysAdminLinks } from './sysAdminLinks';
import { Route } from '@angular/router';
import { VigilantLinks } from './vigilanteLinks';
import { PublicLinks } from './publicLinks';

export interface NavLink {
    title: string,
    endpoint: string,
    component?: any,
    icon?: string,
    inNav?: boolean
}

export interface ILinks {
  userLevel: number | null,
  urls: NavLink[]
}

export class Links {
  public constructor(
    public userLevel: number | null,
    public urls: NavLink[]
  ) {}
  public getRoutes(): Route[] {
    return this.urls.map((link) => ({
      title: link.title,
      path: link.endpoint,
      component: link.component,
    }));
  }
  public toIlink(): ILinks {
    return {
      userLevel: this.userLevel,
      urls: this.urls
    };
  }
}

export const AllLinks: ILinks[] = [

]
