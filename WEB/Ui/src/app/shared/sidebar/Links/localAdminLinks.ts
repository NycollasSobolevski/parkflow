import { Links }  from "./utilLinks";

export const LocalAdminLinks: Links = new Links(
  1,
  [
    {
      endpoint: "my-business",
      title: "Minha Empresa",
      icon: "monitoring",
      component: null,
      inNav: true,
    },
    {
      endpoint: "profile",
      title: "Perfil",
      icon: "person",
      component: null,
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
    }
  ],
)
