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
      :storeSelect="storeSelect"
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
      <div class="item-action" @click="btnUpdateStore">
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
            <tr
              class="table"
              tabindex="15"
              v-for="item in stores"
              :key="item.StoreId"
              @click="selectCustomer(item)"
            >
              <td style="max-width: 100px">{{ item.StoreCode }}</td>
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
      store: {
        StoreCode: "",
        StoreName: "",
        StoreAddress: "",
        StorePhoneNumber: "",
        StoreStatus: "Đang hoạt động",
        TaxNumber: null,
        AdministrativeUnitId: "",
        CreatedDate: null,
        CreatedBy: null,
        ModifiledDate: null,
        ModifiledBy: null,
      },
      isHideDetail: true,
      isHideConfirm: true,
      storeSelect: {},
    };
  },
  methods: {
    // Thêm mới cửa hàng
    //Created by LTThuc(27/03/2021)
    btnAddStore() {
      this.store = {};
      this.isHideDetail = false;
      setTimeout(() => {
        this.$refs.Datail.$refs.StoreCode.focus();
      }, 0);
    },

    // Sửa thông tin cửa hàng
    //Created by LTThuc(27/03/2021)
    btnUpdateStore() {
      this.store = this.storeSelect;
      this.isHideDetail = false;
    },

    // Đóng popup thông tin chi tiết cửa hàng
    //Created by LTThuc(27/03/2021)
    closePopup(value) {
      this.isHideDetail = value;
    },

    // Xóa cửa hàng
    //Created by LTThuc(28/03/2021)
    btnDeleteStore() {
      this.isHideConfirm = false;
    },
    // Đóng popup  xóa cửa hàng
    //Created by LTThuc(28/03/2021)
    closePopupDelete(value) {
      this.isHideConfirm = value;
      this.storeSelect = {};
    },

    // Chọn cửa hàng để sửa hoặc xóa
    //Created by LTThuc(27/03/2021)
    selectCustomer(data) {
      this.storeSelect = data;
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
