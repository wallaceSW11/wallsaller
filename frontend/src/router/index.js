import { createRouter, createWebHistory } from "vue-router";
import routes from "./routes";

const router = createRouter({
    history: createWebHistory(process.env.BASE_URL),
    routes,
});

// router.beforeEach((to, from, next) => {

//     let token = localStorage.getItem('user');

//     if (to.name == 'Login'){

//         if (token){
//           next({name: 'Dashboard'});
//         } else {
//           next();
//         }
//     } else if (to.matched.some(rota => rota.meta.requiredAuth)){

//       if (token == null) {
//         next({
//           path: "/login",
//           params: {nextUrl: to.fullPath}
//         });

//       } else {
//         next();
//       }

//     } else {

//       if(token == null){
//         next();

//       }else{
//         next({name: 'Dashboard'})
//       }
//     }

// });

export default router;
