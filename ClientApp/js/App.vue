<script setup>
import { ref, onMounted } from 'vue'

const count = ref(0)
const apiRes = ref(null)

const incrementCount = () => {
  count.value++
}

onMounted(() => {
  const json = fetch('/api/test')
    .then(req => req.json())
    .then(data => {
      apiRes.value = data
    })
})
</script>

<template>
  <main class="max-w-6xl mx-auto">
    <h1 class="text-4xl font-bold text-blue-500">Hello world from Vue</h1>
    <div>
      {{ count }}
      <br />
      <button class="px-4 py-2 border-2 border-blue-500" @click="incrementCount">Count++</button>
    </div>
    <hr />
    <div class="mt-4">
      <h2 class="font-bold">Response From API</h2>
      <div>{{ apiRes }}</div>
    </div>
  </main>
</template>