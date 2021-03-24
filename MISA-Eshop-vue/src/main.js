import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router'
import StoreList from './components/page/dictionary/store/StoreList.vue';

const routes = [
  { path: '/dictionary/store', component: StoreList },
]
const router = new VueRouter({
  routes // short for `routes: routes`
})
Vue.config.productionTip = false
Vue.use(VueRouter)

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')
