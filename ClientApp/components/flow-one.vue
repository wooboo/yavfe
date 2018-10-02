<template>
  <div>
    <slot name="header"></slot>
    <step-one :name="stepOne.name">
      <slot name="stepOne"></slot>
    </step-one>
    <step-two :name="stepTwo.name">
      <slot name="stepTwo"></slot>
    </step-two>
    <slot name="footer"></slot>
  </div>
</template>

<script>
  import StepOne from './step-one.vue';
  import StepTwo from './step-two.vue';

  export default {
  components: {StepOne, StepTwo},
  props:['stepOne','stepTwo','title'],
  data () {
    return {}
    }
  }
</script>

<style>
</style>
