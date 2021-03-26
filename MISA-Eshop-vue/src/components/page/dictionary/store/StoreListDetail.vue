<template>
  <div
    class="m-dialog dialog-detail"
    :class="{ isHide: isHide }"
    title="Thông tin cửa hàng"
  >
    <div class="dialog-modal"></div>
    <div class="dialog-content">
      <div class="dialog-header">
        <div class="dialog-header-title">Thêm mới cửa hàng</div>
        <div class="dialog-header-close">
          <button id="exit" @click="btnCancel">x</button>
        </div>
      </div>
      <div class="dialog-body">
        <div class="row">
          <div class="m-lable">Mã cửa hàng <span class="require">*</span></div>
          <input class="m-input" ref="StoreCode" tabindex="1" type="text" required />
        </div>
        <div class="row">
          <div class="m-lable">Tên cửa hàng <span class="require">*</span></div>
          <input class="m-input" tabindex="2" type="text" required  />
        </div>
        <div class="row row-area">
          <div class="m-lable lable-area">
            Địa chỉ <span class="require">*</span>
          </div>
          <textarea tabindex="3" rows="6" class="text-area"></textarea>
        </div>

        <div class="row">
          <div class="col-2">
            <div class="m-lable">Số điện thoại</div>
            <input
              class="m-input-both"
              tabindex="4"
              type="text"
              required
            />
          </div>
          <div class="col-2">
            <div class="m-lable lable-right">Mã số thuế</div>
            <input
              class="m-input-both"
              tabindex="5"
              type="text"
              required
            />
          </div>
        </div>

        <div class="row">
          <div class="col-2">
            <div class="m-lable">Quốc gia</div>
            <select name="" id="" class="m-input-both" tabindex="6">
              <option value="">Việt Nam</option>
              <option value="">Lào</option>
              <option value="">Campuchia</option>
            </select>
          </div>
        </div>

        <div class="row">
          <div class="col-2">
            <div class="m-lable">Tỉnh/Thành phố</div>
            <select name="" id="" class="m-input-both" tabindex="7">
              <option value="">Việt Nam</option>
              <option value="">Lào</option>
              <option value="">Campuchia</option>
            </select>
          </div>
          <div class="col-2">
            <div class="m-lable lable-right">Quận/Huyện</div>
            <select name="" id="" class="m-input-both" tabindex="7">
              <option value="">Việt Nam</option>
              <option value="">Lào</option>
              <option value="">Campuchia</option>
            </select>
          </div>
        </div>

        <div class="row">
          <div class="col-2">
            <div class="m-lable">Phường/Xã</div>
            <select name="" id="" class="m-input-both" tabindex="7">
              <option value="">Việt Nam</option>
              <option value="">Lào</option>
              <option value="">Campuchia</option>
            </select>
          </div>
          <div class="col-2">
            <div class="m-lable lable-right">Đường phố</div>
            <input
              class="m-input-both"
              tabindex="8"
              type="text"
              required
            />
          </div>
        </div>
      </div>
      <div class="dialog-footer">
        <div class="footer-left">
          <img src="../../../../content/icon/icon-question.png" alt="" />
          <span>Trợ giúp</span>
        </div>
        <div class="footer-right">
          <div class="item-action itemSave">
            <img src="../../../../content/icon/document-online.png" alt="" />
            <span>Lưu</span>
          </div>
          <div class="item-action itemAdd">
            <span>Lưu và thêm mới</span>
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
export default {
  name: "StoreListDatail",
  data() {
    return {};
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
