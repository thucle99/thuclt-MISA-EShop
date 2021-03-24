<template>
  <div class="content">
     <!-- <StoreListDetail
      @closePopup="closePopup"
      :isHide="isHideDetail"
      ref="Datail"
    /> -->
    <div class="header-content">
      <div class="item-action" id="btnAdd" @click="btnAddStore">
        <img src="../../../../content/icon/icon-add.png" alt="" />
        <span>Thêm mới</span>
      </div>
      <div class="item-action">
        <img src="../../../../content/icon/icon-copy.png" alt="" />
        <span>Nhân bản</span>
      </div>
      <div class="item-action">
        <img src="../../../../content/icon/icon-edit.png" alt="" />
        <span>Sửa</span>
      </div>
      <div class="item-action">
        <img src="../../../../content/icon/icon-delete.png" alt="" />
        <span>Xóa</span>
      </div>
      <div class="item-action icon-loaded">
        <img src="../../../../content/icon/icon-load.png" alt="" />
        <span>Nạp</span>
      </div>
    </div>

    <main>
      <!-- table  -->
      <div class="gird-table">
        <table>
          <thead>
            <tr>
              <th style="width: 168px">
                <div class="title">Mã cửa hàng</div>
                <div class="filter">
                  <span>*</span>
                  <input type="text" />
                </div>
              </th>
              <th style="width: 281px">
                <div class="title">Tên cửa hàng</div>
                <div class="filter">
                  <span>*</span>
                  <input type="text" />
                </div>
              </th>
              <th>
                <div class="title">Địa chỉ</div>
                <div class="filter">
                  <span>*</span>
                  <input type="text" />
                </div>
              </th>
              <th>
                <div class="title">Số điện thoại</div>
                <div class="filter">
                  <span>*</span>
                  <input type="text" />
                </div>
              </th>
              <th>
                <div class="title">Trạng thái</div>
                <div class="filter">
                  <span>*</span>
                  <input type="text" />
                </div>
              </th>
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
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
            <tr>
              <td style="max-widtd: 100px">CH1234</td>
              <td>Hoàng Long</td>
              <td>Số 35 ngõ 4, Đào Xá, Hoàng Long, Phú Xuyên, Hà Nội</td>
              <td>Số điện thoại</td>
              <td>Trạng thái</td>
            </tr>
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
      <TheFooter />
    </main>
  </div>
</template>

<script>
// import StoreListDetail from "./StoreListDetail";
import TheFooter from '../../../layout/TheFooter'
export default {
  name: "Content",
  components: {
    // StoreListDetail,
    TheFooter
  },
  data() {
    return {
      isHideDetail: true,
    };
  },
  methods: {
    btnAddStore() {
      this.isHideDetail = false;
      // setTimeout(() => {
      //   this.$refs.Datail.$refs.ab.focus();
      // }, 0);
      console.log('isHideDetail',this.isHideDetail);
    },
    closePopup(value) {
      this.isHideDetail = value;
    },
  }
};
</script>

<style scoped>
@import url("../../../../css/common/content.css");
</style>
