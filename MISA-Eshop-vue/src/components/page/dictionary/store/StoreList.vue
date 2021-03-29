<template>
  <div class="content">
    <StoreListDetail
      @closePopup="closePopup"
      @closePopupDelete="closePopupDelete"
      :store="store"
      :isHide="isHideDetail"
      ref="Datail"
    />
     <StoreConform
      @closePopupDelete="closePopupDelete"
      :isHide="isHideConfirm"
      :storeDelete="storeDelete"
    />
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
      <div class="item-action" @click="btnDeleteStore">
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
              <th style="max-width: 100px">
                <div class="title">Trạng thái</div>
                <div class="filter">
                  <select name="" id="" class="select-status">
                    <option value="">Đang hoạt động</option>
                    <option value="">Đang Off</option>
                    <option value="">Ẩn trạng thái</option>
                  </select>
                </div>
              </th>
            </tr>
          </thead>
          <tbody>
            <tr class="table" tabindex="15"
             v-for="item in stores" :key="item.StoreId"
             @click="selectCustomer(item)"
             >
              <td style="max-widtd: 100px">{{ item.StoreCode }}</td>
              <td>{{ item.StoreName }}</td>
              <td>{{ item.StoreAddress }}</td>
              <td style="max-width: 50px">{{ item.StorePhoneNumber }}</td>
              <td>{{ item.StoreStatus }}</td>
            </tr>
          </tbody>
        </table>
      </div>
      <TheFooter />
    </main>
  </div>
</template>

<script>
import axios from "axios";
import StoreListDetail from "./StoreListDetail";
import StoreConform from "./StoreConform";
import TheFooter from "../../../layout/TheFooter";
export default {
  name: "Content",
  components: {
    StoreListDetail,
    StoreConform,
    TheFooter,
  },
  data() {
    return {
      stores: [],
      // store:{
      //   StoreCode: "CH10",
      //   StoreName: "Phuong Le",
      //   StoreAddress: "ha noi",
      //   StorePhoneNumber: "0248248924",
      //   StoreStatus: "Đang hoạt động",
      //   TaxNumber: 12345,
      //   AdministrativeUnitId: "11452b0c-768e-5ff7-0d63-eeb1d8ed8cef",
      //   CreatedDate: "2021-03-26T12:19:19",
      //   CreatedBy: null,
      //   ModifiledDate: null,
      //   ModifiledBy: null
      // },
      store:{
        StoreCode: "",
        StoreName: "",
        StoreAddress: "",
        StorePhoneNumber: "",
        StoreStatus: "",
        TaxNumber: null,
        AdministrativeUnitId: "",
        CreatedDate: "",
        CreatedBy: null,
        ModifiledDate: null,
        ModifiledBy: null
      },
      isHideDetail: true,
      isHideConfirm: true,
      storeDelete:{}
    };
  },
  methods: {
    btnAddStore() {
      this.isHideDetail = false;
      setTimeout(() => {
        this.$refs.Datail.$refs.StoreCode.focus();
      }, 0);
      console.log("isHideDetail", this.isHideDetail);
    },
    closePopup(value) {
      this.isHideDetail = value;
    },

    btnDeleteStore() {
      this.isHideConfirm = false;
    },
    closePopupDelete(value) {
      this.isHideConfirm = value;
      this.storeDelete = {}
    },
    selectCustomer(data) {
      this.storeDelete = data;
    },
  },
  created() {
    axios.get("http://localhost:51777/api/v1/stores").then((res) => {
      this.stores = res.data;
    });
  },
};
</script>

<style scoped>
@import url("../../../../css/common/content.css");
</style>
