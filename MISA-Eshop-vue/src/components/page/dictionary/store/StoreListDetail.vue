<template>
  <div
    class="m-dialog dialog-detail isHide"
    :class="{ isHide: isHide }"
    title="Thông tin khách hàng"
  >
    <div class="dialog-modal"> chao anh em</div>
    <div class="dialog-content">
      
      chao anh em
    </div>
  </div>
</template>

<script>
export default {
  name: "StoreListDatail",
  data() {
    return {
    };
  },
  props: ["isHide"],
  methods: {
    btnCancel() {
      this.$emit("closePopup", true);
      // dùng để thay đổi giá trị của props do thằng cha truyền sang
    },
  },
};
</script>

<style scoped>
.isHide {
  display: none;
}
/* :class="{ isHide: isHide }" */
/* @import url("../../css/common/dialog.css"); */
</style>
