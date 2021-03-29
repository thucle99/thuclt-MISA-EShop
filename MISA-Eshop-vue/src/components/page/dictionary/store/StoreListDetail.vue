<template>
  <div class="m-dialog dialog-detail" :class="{ isHide: isHide }">
    <div class="dialog-modal">
      
    </div>
    <div class="dialog-err" :class="{ showErr: showErr }">{{err}}</div>
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
          <input
            class="m-input"
            tabindex="1"
            type="text"
            required
            ref="StoreCode"
            v-model="store.StoreCode"
          />
        </div>
        <div class="row">
          <div class="m-lable">Tên cửa hàng <span class="require">*</span></div>
          <input
            class="m-input"
            v-model="store.StoreName"
            tabindex="2"
            type="text"
            required
          />
        </div>
        <div class="row row-area">
          <div class="m-lable lable-area">
            Địa chỉ <span class="require">*</span>
          </div>
          <textarea
            v-model="store.StoreAddress"
            tabindex="3"
            rows="6"
            class="text-area"
          ></textarea>
        </div>

        <div class="row">
          <div class="col-2">
            <div class="m-lable">Số điện thoại</div>
            <input
              class="m-input m-input-both"
              tabindex="4"
              type="text"
              required
              v-model="store.StorePhoneNumber"
            />
          </div>
          <div class="col-2">
            <div class="m-lable lable-right">Mã số thuế</div>
            <input
              class="m-input m-input-both"
              tabindex="5"
              type="text"
              required
              v-model="store.TaxNumber"
            />
          </div>
        </div>

        <div class="row">
          <div class="col-2">
            <div class="m-lable">Quốc gia</div>
            <select name="" id="" class="m-input m-input-both" tabindex="6">
              <option value="">Việt Nam</option>
              <option value="">Lào</option>
              <option value="">Campuchia</option>
            </select>
          </div>
        </div>

        <div class="row">
          <div class="col-2">
            <div class="m-lable">Tỉnh/Thành phố</div>
            <select name="" id="" class="m-input m-input-both" tabindex="7">
              <option value="">Hà Nội</option>
              <option value="">Hồ Chí Minh</option>
              <option value="">Thanh Hóa</option>
              <option value="">Bắc Giang</option>
              <option value="">Lào Cai</option>
              <option value="">Vĩnh Phúc</option>
              <option value="">Hưng Yên</option>
            </select>
          </div>
          <div class="col-2">
            <div class="m-lable lable-right">Quận/Huyện</div>
            <select name="" id="" class="m-input m-input-both" tabindex="7">
              <option value="">Phú Xuyên</option>
              <option value="">Thường Tín</option>
              <option value="">Thanh Oai</option>
              <option value="">Thạch Thất</option>
              <option value="">Ba Vì</option>
              <option value="">Hoài Đức</option>
            </select>
          </div>
        </div>

        <div class="row">
          <div class="col-2">
            <div class="m-lable">Phường/Xã</div>
            <select name="" id="" class="m-input m-input-both" tabindex="7">
              <option value="">Hoàng Long</option>
              <option value="">Hồng Minh</option>
              <option value="">Phượng Dực</option>
              <option value="">Tri Chỉ</option>
              <option value="">Phú Túc</option>
              <option value="">Văn Hoàng</option>
            </select>
          </div>
          <div class="col-2">
            <div class="m-lable lable-right">Đường phố</div>
            <input
              class="m-input m-input-both"
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
          <div class="item-action itemSave" @click="btnSaveStore">
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
// import axios from "axios";
export default {
  name: "StoreListDatail",
  data() {
    return {
      err: "",
      showErr: true,
    };
  },
  props: ["isHide", "store"],
  methods: {
    btnSaveStore() {
      console.log('data',this.store);
      if (!this.store.StoreCode) {
        this.err="Mã cửa hàng không được để trống"
        this.showErr=false;
        setTimeout( ()=>{
          this.showErr=true;
        },1500)
      } 
      else if (!this.store.StoreName) {
        this.err="Tên cửa hàng không được để trống"
        this.showErr=false;
         setTimeout( ()=>{
          this.showErr=true;
        },1500)
      } 
      else if (!this.store.StoreAddress) {
        this.err="Địa chỉ cửa hàng không được để trống"
        this.showErr=false;
         setTimeout( ()=>{
          this.showErr=true;
        },1500)
      } 
      // else {
      //   axios
      //     .post("http://localhost:51777/api/v1/customers", this.store)
      //     .then((res) => {
      //       console.log("res", res.data);
      //     })
      //     .catch((err) => {
      //       console.log(err);
      //     });
      //   this.$emit("closePopup", true);
      // }
    },

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
.showErr{
  display: none;
}
@import url("../../../../css/common/dialog.css");
</style>
