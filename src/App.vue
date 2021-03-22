<template>
  <body>
    <div>
      <div class="body-left">
        <TheMenu/>
      </div>
      <div class="body-right">
        <TheHeader />
        <TheContent/>
      </div>
    </div>
  </body>
</template>

<script>
import TheHeader from "./components/layout/TheHeader"
import TheMenu from "./components/layout/TheMenu"
import TheContent from "./components/layout/TheContent"

export default {
  name: "App",
  components: {
    TheHeader,
    TheMenu,
    TheContent,
  },
};
</script>

<style>
@import url("./css/common/main.css");
@import url("./css/common/common.css");
@import url("./css/common/dialog.css");
@import url("./css/common/layout.css");
</style>
