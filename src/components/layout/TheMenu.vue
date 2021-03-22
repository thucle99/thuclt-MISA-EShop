<template>
  <div class="body-left">
    <div class="logo-site">
      <div class="toggle-icon">
        <img src="../../content/img/toggle.png" alt="" />
      </div>
      <div class="amis-logo">
        <img src="../../content/img/cukcuk-logo.png" alt="" />
      </div>
    </div>
    <div class="navbar">
      <ul>
        <a href="#" class="navbar-item">
          <img src="../../content/icon/dashboard.png" alt="" />
          <p>Tổng quan</p>
        </a>
        <a href="#" class="navbar-item">
          <img src="../../content/icon/report.png" alt="" />
          <p>Báo cáo</p>
        </a>
        <a href="#" class="navbar-item">
          <img src="../../content/icon/dashboard.png" alt="" />
          <p>Mua hàng</p>
        </a>
        <router-link class="navbar-item" to="/dictionary/customer">
          <img src="../../content/icon/dic-employee.png" alt="" />
          <span>Danh sách khách hàng</span>
        </router-link>
        <router-link  class="navbar-item" to="/dictionary/employee">
          <img src="../../content/icon/dic-employee.png" alt="" />
          <span>Danh sách nhân viên</span>
        </router-link>
        <a href="#" class="navbar-item">
          <img src="../../content/icon/setting.png" alt="" />
          <p>Thiết lập hệ thống</p>
        </a>
      </ul>
    </div>
  </div>
</template>

<script>
export default {
  name: "TheMenu",
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
@import url("../../css/common/menu.css");
@import url("../../css/common/leftSideBar.css");
</style>
