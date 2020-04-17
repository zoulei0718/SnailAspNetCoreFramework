import { getKeyValue } from '@/api'
const state = {
  keyValues: {}
}

const mutations = {
  SET_ENUM_LIST(state, payload) {
    state.keyValues[payload.code] = payload.data || []
  }
}

const actions = {
  async getKeyValue({ commit, getters }, key) {
    const keyValues = getters.keyValues
    var list = keyValues[key]
    if (list) {
      return list
    }
    try {
      const data = await getKeyValue(key)
      commit('SET_ENUM_LIST', { data, key })
      return getters.keyValues[key]
    } catch (error) {
      // eslint-disable-next-line
                  console.log('获取键值出错', error);
    }
  }
}

export default {
  namespaced: true,
  state,
  mutations,
  actions
}

