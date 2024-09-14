import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [react()],
  build: {
    sourcemap: true, // Gera source maps para facilitar o debugging
  },
  server: {
    sourcemapIgnoreList: (source) => {
      // Ignora arquivos que não necessitam de mapas de código
      return source.includes('node_modules');
    }
  }
})
