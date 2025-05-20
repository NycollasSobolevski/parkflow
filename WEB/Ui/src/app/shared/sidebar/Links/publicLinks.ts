import { Links } from "./utilLinks";

export const PublicLinks: Links = new Links(
  null,
  [
    {
      endpoint: "login",
      title: "Login",
      icon: "login",
      component: null,
      inNav: true,
    },
    {
      endpoint: "register",
      title: "Registrar",
      icon: "person_add",
      component: null,
      inNav: true,
    },
    {
      endpoint: "forgot-password",
      title: "Esqueci minha senha",
      icon: "lock_reset",
      component: null,
      inNav: true,
    },
  ],
)
