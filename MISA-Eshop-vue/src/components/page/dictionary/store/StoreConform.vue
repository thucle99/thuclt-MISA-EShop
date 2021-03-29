<template>
  <div
    class="n-dialog dialog-detail"
    :class="{ isHide: isHide }"
    title="Thông tin cửa hàng"
  >
    <div class="dialog-modal"></div>
    <div class="dialog-content">
      <div class="dialog-header">
        <div class="dialog-header-title">Xóa dữ liệu</div>
        <div class="dialog-header-close">
          <button id="exit" @click="btnCancel">x</button>
        </div>
      </div>

      <div class="dialog-body">
        <img src="../../../../content/icon/icon-question.png" alt="" />
        <p>
          Bạn có chắc muốn xóa dữ <span>{{storeDelete.StoreName}}</span> khỏi danh
          sách cửa hàng
        </p>
      </div>

      <div class="dialog-footer">
        <div class="footer-right">
          <div class="item-action itemDelete" @click="btnDelete">
            <img
              src="../../../../content/icon/icon-delete.png"
              class="icon-delete"
              alt=""
            />
            <span>Xóa</span>
          </div>
          <div class="item-action itemCancel" @click="btnCancel">
            <img src="../../../../content/icon/x.svg" alt="" />
            <span>Hủy bỏ</span>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
  name: "StoreListDatail",
  data() {
    return {};
  },
  props: ["isHide", "storeDelete"],
  methods: {
    btnCancel() {
      this.$emit("closePopupDelete", true);
    },
    btnDelete() {
      this.$emit("closePopupDelete", true);
      axios.delete(`http://localhost:51777/api/v1/stores/${this.storeDelete.StoreId}`).then((res) => {
        console.log('delete success',res.data);
      });
    },
  },
};
</script>

<style scoped>
.isHide {
  display: none;
}
@import url("../../../../css/common/conform.css");
</style>
