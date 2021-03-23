<template>
  <div class="body-left">
    <div class="logo-site">
      <div class="toggle-icon">
        <img src="../../content/img/logo.png" alt="" />
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
          <p>Đơn hàng</p>
        </a>
        <a href="#" class="navbar-item" >
          <img src="../../content/icon/dic-employee.png" alt="" />
          <span>Mua hàng</span>
        </a>
        <a href="#" class="navbar-item" >
          <img src="../../content/icon/dic-employee.png" alt="" />
          <span>Quản lý cửa hàng</span>
        </a>
        <hr>
        <a href="#" class="navbar-item">
          <img src="../../content/icon/setting.png" alt="" />
          <p>Hàng hóa</p>
        </a>
      </ul>
    </div>
  </div>
</template>

<script>
export default {
  name: "TheMenu",
};
</script>

<style scoped>
@import url("../../css/common/menu.css");
@import url("../../css/common/leftSideBar.css");
</style>
