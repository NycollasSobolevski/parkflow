import { Links } from "./utilLinks";

const UserLinks = new Links(
  3,
  [
    {
      endpoint: "profile",
      title: "Perfil",
      icon: "person",
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
    }
  ]
)


export {UserLinks}
