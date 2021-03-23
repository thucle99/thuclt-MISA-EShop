<template>
  <div class="content">
    <div class="header-content">
      <div class="item-action">
        <img src="../../content/icon/dashboard.png" alt="" />
        <span>Thêm mới</span>
      </div>
      <div class="item-action">
        <img src="../../content/icon/dashboard.png" alt="" />
        <span>Nhân bản</span>
      </div>
      <div class="item-action">
        <img src="../../content/icon/dashboard.png" alt="" />
        <span>Sửa</span>
      </div>
      <div class="item-action">
        <img src="../../content/icon/dashboard.png" alt="" />
        <span>Xóa</span>
      </div>
      <div class="item-action icon-loaded">
        <img src="../../content/icon/dashboard.png" alt="" />
        <span>Nạp</span>
      </div>
    </div>

    <div class="gird-table">
      <table>
        <thead>
          <tr>
            <th style="width: 168px">Mã cửa hàng</th>
            <th style="width: 281px">Tên cửa hàng</th>
            <th>Địa chỉ</th>
            <th>Số điện thoại</th>
            <th>Trạng thái</th>
          </tr>

          <tr class="filter">
            <th style="width: 168px">
              <span>*</span>
              <input type="text" />
            </th>
            <th style="width: 281px">Tên cửa hàng</th>
            <th>Địa chỉ</th>
            <th>Số điện thoại</th>
            <th>Trạng thái</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td style="max-widtd: 100px">CH1234</td>
            <td>Hoàng Long</td>
            <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
            <td>Số điện thoại</td>
            <td>Trạng thái</td>
          </tr>
        </tbody>
      </table>
    </div>
    <div class="paging-bar">
      <div class="paging-info">Hiển thị <b>1-10/1000</b> Khách hàng</div>
      <div class="option">
        <!-- <img src="../../../../content/icon/btn-firstpage.svg" alt="" /> -->
        <!-- <img src="../../../../content/icon/btn-prev-page.svg" alt="" /> -->
        <div class="m-btn-list-page">
          <button class="btn-pagenumber btn-pagenumber-selected">1</button>
          <button class="btn-pagenumber">2</button>
          <button class="btn-pagenumber">3</button>
          <button class="btn-pagenumber">4</button>
        </div>
        <!-- <img src="../../../../content/icon/btn-next-page.svg" alt="" /> -->
        <!-- <img src="../../../../content/icon/btn-lastpage.svg" alt="" /> -->
      </div>
      <div class="paging-option"><b>10</b> Khách hàng/trang</div>
    </div>
  </div>
</template>

<script>
// import CustomerList from "../page/dictionary/customer/CustomerList";
export default {
  name: "Content",
  components: {
    // CustomerList,
  },
};
</script>

<style scoped>
@import url("../../css/common/content.css");
</style>
