<template>
  <div>
    <h1>{{name}}</h1>
    <slot></slot>
  </div>
</template>

<script>
export default {
  props:['name'],
  data () {
    return {}
  }
}
</script>

<style>
</style>
