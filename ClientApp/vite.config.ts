import { defineConfig } from 'vite'

import vue from "@vitejs/plugin-vue";

export default defineConfig({
  base: '/dist/',
  build: {
    outDir: './wwwroot/dist',
    emptyOutDir: true,
    manifest: true,
    rollupOptions: {
      input: {
        main: './ClientApp/js/main.js',
      }
    }
  },
  plugins: [vue()],
  server: {
    watch: {
      usePolling: true
    }
  }
})