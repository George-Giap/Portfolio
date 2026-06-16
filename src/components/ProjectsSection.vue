<template>
    <section id="projects" class="py-20 bg-gray-900 text-white px-8">
        <h2 class="text-4xl font-bold text-center mb-12">Projects</h2>
        <div class="grid md:grid-cols-2 lg:grid-cols-3 gap-8 max-w-6xl mx-auto">
            <div v-for="project in projects"
                 :key="project.title"
                 class="bg-gray-800 rounded-xl p-6 hover:shadow-indigo-500/20 hover:shadow-xl transition">
                <h3 class="text-xl font-bold mb-2 text-indigo-400">{{ project.title }}</h3>
                <p class="text-gray-400 mb-4 text-sm">{{ project.description }}</p>
                <div class="flex gap-2 flex-wrap mb-4">
                    <span v-for="tag in project.tags"
                          :key="tag"
                          class="text-xs bg-indigo-900 text-indigo-300 px-2 py-1 rounded-full">{{ tag }}</span>
                </div>
                <a :href="project.github" target="_blank" class="text-sm text-indigo-400 hover:underline">
                    🔗 View on GitHub
                </a>
            </div>
        </div>
    </section>
</template>

<script setup>
const projects = [
  {
    title: 'Personal Portfolio',
    description: 'This portfolio website built with Vue 3, Tailwind CSS and ASP.NET Core backend.',
    tags: ['Vue.js', 'Tailwind', 'C#', 'ASP.NET Core'],
    github: 'https://github.com/YOUR-USERNAME/portfolio'
  }
]
</script>