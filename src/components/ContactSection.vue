<template>
    <section id="contact" class="py-20 bg-gray-800 text-white px-8">
        <h2 class="text-4xl font-bold text-center mb-12">Contact Me</h2>
        <form @submit.prevent="submitForm" class="max-w-xl mx-auto flex flex-col gap-4">
            <input v-model="form.name"
                   type="text"
                   placeholder="Your Name"
                   class="bg-gray-700 rounded-lg px-4 py-3 focus:outline-none focus:ring-2 focus:ring-indigo-500"
                   required />
            <input v-model="form.email"
                   type="email"
                   placeholder="Your Email"
                   class="bg-gray-700 rounded-lg px-4 py-3 focus:outline-none focus:ring-2 focus:ring-indigo-500"
                   required />
            <textarea v-model="form.message"
                      rows="5"
                      placeholder="Your Message"
                      class="bg-gray-700 rounded-lg px-4 py-3 focus:outline-none focus:ring-2 focus:ring-indigo-500"
                      required />
            <button type="submit"
                    class="bg-indigo-500 hover:bg-indigo-600 py-3 rounded-lg font-semibold transition">
                Send Message 🚀
            </button>
            <p v-if="sent" class="text-green-400 text-center">✅ Message sent successfully!</p>
        </form>
    </section>
</template>

<script setup>
import { ref } from 'vue'
import axios from 'axios'

const form = ref({ name: '', email: '', message: '' })
const sent = ref(false)

async function submitForm() {
  try {
    await axios.post('http://localhost:5000/api/contact', form.value)
    sent.value = true
    form.value = { name: '', email: '', message: '' }
  } catch (e) {
    alert('Something went wrong. Is the backend running?')
  }
}
</script>