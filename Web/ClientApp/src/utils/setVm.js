/**
 * vue的prototype的挂载，方便在代码里调用
 *
 */
// 将常用的东西挂载到vue实例下，这样在vue里就能用this.$api这种方法快捷访问
import dayjs from 'dayjs'
import _ from 'lodash'
import * as util from './index'
import * as api from '@/api'
import store from '@/store'
import * as config from './config'
import * as enums from './enum'
export default (Vue) => {
  Vue.prototype.$getKeyValue = code => store.dispatch('keyValue/getKeyValue', code)
  Vue.prototype.$dayjs = dayjs
  Vue.prototype.$api = api
  Vue.prototype.$util = util
  Vue.prototype.$enum = enums
  Vue.prototype.$_ = _
  Vue.prototype.$config = config
}
