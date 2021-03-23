<template>
  <div class="header">
    <p>Cửa hàng</p>
    <div class="branch">
      <select name="" id="">
        <option value="">Nhà hàng Biển Đông</option>
        <option value="">Nhà hàng Hải Dương</option>
        <option value="">Nhà hàng Đội Cấn</option>
        <option value="">Nhà hàng Cầu Giấy</option>
      </select>
    </div>
    <div class="right-header">
      <!-- <img src="../../content/icon/avatar-default.png" class="avatar" alt="" /> -->
      <p>Lê Trung Thực</p>
       <img src="../../content/icon/option.png" class="notification" alt="" />
      <!-- <p class="option">?</p> -->
    </div>
  </div>
</template>

<script>
export default {
  name: "TheHeader",
  data() {
    return {};
  },
  props: {
    msg: String,
  },
  methods: {
    xuLySuKien() {
      this.count += 2;
    },
  },
};
</script>

<style scoped>
@import url("../../css/common/header.css");
</style>
