import { GatewayPageComponent } from "../../../pages/vigilant/gateway-page/gateway-page.component";
import { Links } from "./utilLinks";

export const VigilantLinks: Links = new Links(
   2,
   [
    {
      endpoint: "profile",
      title: "Perfil",
      icon: "person",
      component: null,
      inNav: true,
    },
    {
      endpoint: "gateway",
      title: "Portaria",
      icon: "fence",
      component: GatewayPageComponent,
      inNav: true,
    },
    {
      endpoint: "new-user",
      title: "Criar Usuário",
      icon: "person_add",
      component: null,
      inNav: true,
    },
    {
      endpoint: "vehicles",
      title: "Veículos",
      icon: "directions_car",
      component: null,
      inNav: true,
    },
    {
      endpoint: "vehicle/:id",
      title: "Veículo",
      icon: "directions_car",
      component: null,
    },
  ],
)
