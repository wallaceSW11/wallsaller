import HomeView from "@/views/home/HomeView";
import LoginView from "@/views/login/LoginView";
import OrdersView from "@/views/orders/orders/OrdersView";
import OrderDetailView from "@/views/orders/orderdetail/OrderDetail";

const routes = [
    {
        path: "/",
        name: "HomeView",
        component: HomeView,
        meta: { requiredAuth: true },
    },
    {
        path: "/login",
        name: "LoginView",
        component: LoginView,
        meta: { requiredAuth: false },
    },
    {
        path: "/orders",
        name: "OrdersView",
        component: OrdersView,
        meta: { requiredAuth: false },
    },
    {
        path: "/order-detail",
        name: "OrderDetailView",
        component: OrderDetailView,
        meta: { requiredAuth: false },
    },
];

export default routes;
