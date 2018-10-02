import Vue from 'vue'
import axios from 'axios'
import router from './router/index'
import store from './store'
import { sync } from 'vuex-router-sync'
import App from 'components/app-root'
import BlaBla from 'components/bla-bla'
import FlowOne from 'components/flow-one'
import { FontAwesomeIcon } from './icons'

// Registration of global components
Vue.component('icon', FontAwesomeIcon)

Vue.prototype.$http = axios

sync(store, router)

const app = new Vue({
  components: { App, BlaBla, FlowOne },
  template: '#template',
  store,
  router
})

export {
  app,
  router,
  store
}
