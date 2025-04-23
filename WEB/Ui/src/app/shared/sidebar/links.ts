interface NavLink {
    title: string,
    endpoint: string
}

interface UserLinks {
    userLevel: number,
    urls: NavLink[]
}

const Links: UserLinks[] = [
    {
        userLevel: 0,
        urls: [
            {
                endpoint: "all-users",
                title: "Usuários"
            }
        ]
    },
    {
        userLevel: 3,
        urls: [
            {
                endpoint: "gateway",
                title: "Portaria"
            }
        ]
    }
]