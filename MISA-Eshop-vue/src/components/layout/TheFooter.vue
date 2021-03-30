<template>
  <!-- foorter off page -->
  <div class="paging-bar">
    <div class="paging-info">
      <button class="btn">
        <img src="../../content/icon/icon-backed.png" alt="" />
      </button>
      <button class="btn">
        <img src="../../content/icon/icon-prevpage.png" alt="" />
      </button>
      <span class="page">Trang</span>
      <span class="number-page">1</span>
      <span class="page">trên 1</span>
      <button class="btn">
        <img src="../../content/icon/icon-nextpage.png" alt="" />
      </button>
      <button class="btn">
        <img src="../../content/icon/icon-lastpage.png" alt="" />
      </button>
      <button class="btn btn-reload">
        <img src="../../content/icon/icon-loadpage.png" alt="" />
      </button>
      <span class="max-page"
        >50<img
          src="../../content/icon/bottom-arrow.jpg"
          class="bottom-arrow"
          alt=""
      /></span>
    </div>
    <div class="paging-option">Hiển thị 1 - 13/trên 13 kết quả</div>
  </div>
</template>

<script>
export default {
  name: "TheFooter",
  components: {},
};
</script>

<style scoped>
@import url("../../css/common/footer.css");
</style>
