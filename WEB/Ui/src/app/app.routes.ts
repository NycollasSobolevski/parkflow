import { Routes } from '@angular/router';
import { PublicLinks } from './shared/sidebar/Links/publicLinks';
import { VigilantLinks } from './shared/sidebar/Links/vigilanteLinks';
import { LocalAdminLinks } from './shared/sidebar/Links/localAdminLinks';
import { SysAdminLinks } from './shared/sidebar/Links/sysAdminLinks';
import { GatewayPageComponent } from './pages/vigilant/gateway-page/gateway-page.component';


export const routes: Routes =
[
    // ...PublicLinks.getRoutes(),
    // // ...UserLinks.getRoutes(),
    // ...VigilantLinks.getRoutes(),
    // ...LocalAdminLinks.getRoutes(),
    // ...SysAdminLinks.getRoutes(),
    {
      title: 'Portaria', path: 'gateway', component: GatewayPageComponent
    }
];
