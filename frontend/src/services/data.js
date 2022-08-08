const Orders = [
    {
        id: "1",
        user: "doucuras",
        client: "Fulano de tal",
        deadline: "15/09/2022",
        status: "Aguardando aprovação da turquesa",
    },
    {
        id: "2",
        user: "doucuras",
        client: "Ciclano de tal",
        deadline: "21/09/2022",
        status: "Aguardando aprovação da arte",
    },
    {
        id: "3",
        user: "doucuras",
        client: "Rodnelson Werickson",
        deadline: "10/10/2022",
        status: "Aprovado",
    },
];

const OrderDetail = {
    id: "1",
    createdAt: "2022-08-06",
    user: "douçuras",
    client: "Fulado de tal",
    deadline: "2022-12-28",
    status: "Aguardando aprovação da turquesa",
    totalOrder: "80,00",
    items: [
        {
            id: "1",
            type: "topo",
            description: "Topo especial",
            quantity: "1",
            theme: "Minecraft",
            size: "20 cm",
            name: "Pedrinho",
            age: "4",
            note: "Destaque no personagem Flip",
            price: "35,00",
        },
        {
            id: "3",
            type: "caixa",
            description: "Kit caixa milk luxo",
            quantity: "1",
            color: "Rosa",
            pics: ["pic1.jpg", "pic2.jpg"],
            texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
            size: "15 cm",
            drawer: false,
            note: "Foto 2 é a principal",
            price: "121,00",
        },
        {
            id: "2",
            type: "caixa",
            description: "Caixa explosão sextavada",
            quantity: "1",
            color: "Rosa",
            pics: ["pic1.jpg", "pic2.jpg"],
            texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
            size: "15 cm",
            drawer: false,
            note: "Foto 2 é a principal",
            price: "45,00",
        },
        {
            id: "2",
            type: "caixa",
            description:
                "Caixa piramide luxo com o laço e camadas com borboletas",
            quantity: "1",
            color: "Rosa",
            pics: ["pic1.jpg", "pic2.jpg"],
            texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
            size: "15 cm",
            drawer: false,
            note: "Foto 2 é a principal",
            price: "45,00",
        },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
        // {
        //     id: "2",
        //     type: "caixa",
        //     description: "Caixa explosão sextavada",
        //     quantity: "1",
        //     color: "Rosa",
        //     pics: ["pic1.jpg", "pic2.jpg"],
        //     texts: ["Vocé é muito especial...", "Gostamos muito de vc"],
        //     size: "15 cm",
        //     drawer: false,
        //     note: "Foto 2 é a principal",
        //     price: "45,00",
        // },
    ],
    payments: [
        {
            id: "1",
            description: "PIX",
            value: "20,00",
        },
        {
            id: "2",
            description: "Transferêcia bancária",
            value: "30,00",
        },
        {
            id: "3",
            description: "Boleto",
            value: "30,00",
        },
    ],
};

export default {
    Orders,
    OrderDetail,
};
