<template>
  <div class="header">
    <p class="store">Cửa hàng</p>
    <div class="right-header">
      <div class="branch">
        <select name="" id="">
          <option value="">BLACKLEO- 160 Lê Trung Thực</option>
          <option value="">DODAVI- 160 Hoàng Hoa Thám</option>
          <option value="">COXUDE- 150 Nguyễn Thị Ngọc</option>
        </select>
      </div>
      <img src="../../content/icon/avatar-default.png" class="avatar" alt="" />
      <p>Lê Trung Thực</p>
      <img
        src="../../content/icon/bottom-arrow.jpg"
        class="bottom-arrow"
        alt=""
      />
      <img src="../../content/icon/avatar-default.png" class="avatar" alt="" />
      <img src="../../content/icon/avatar-default.png" class="avatar" alt="" />
      <img src="../../content/icon/avatar-default.png" class="avatar" alt="" />
      <!-- <img src="../../content/icon/ic_support.svg" class="support" alt="" />
      <img src="../../content/icon/ic_support.svg" class="support" alt="" />
      <img src="../../content/icon/ic_support.svg" class="support" alt="" /> -->
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
