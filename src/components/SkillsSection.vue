<template>
    <section class="min-h-screen flex items-center justify-center text-white px-8 relative overflow-hidden bg-transparent pt-20 pb-24">
        <!-- Robonaut -->
        <div class="robonaut-wrapper">
            <svg viewBox="0 0 64 64" class="robonaut-svg" xmlns="http://www.w3.org/2000/svg">
                <circle cx="32" cy="22" r="16" fill="#1e1b4b" stroke="#818cf8" stroke-width="2" />
                <ellipse cx="32" cy="22" rx="9" ry="8" fill="#312e81" opacity="0.9" />
                <ellipse cx="32" cy="22" rx="9" ry="8" fill="url(#visorGrad3)" opacity="0.6" />
                <ellipse cx="28" cy="18" rx="3" ry="2" fill="white" opacity="0.3" />
                <rect x="20" y="36" width="24" height="18" rx="8" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5" />
                <rect x="26" y="40" width="12" height="8" rx="3" fill="#312e81" stroke="#6366f1" stroke-width="1" />
                <circle cx="32" cy="44" r="2" fill="#818cf8" opacity="0.9" />
                <rect x="10" y="37" width="10" height="14" rx="5" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5" />
                <rect x="44" y="37" width="10" height="14" rx="5" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5" />
                <circle cx="15" cy="52" r="4" fill="#312e81" stroke="#818cf8" stroke-width="1" />
                <circle cx="49" cy="52" r="4" fill="#312e81" stroke="#818cf8" stroke-width="1" />
                <defs>
                    <radialGradient id="visorGrad3" cx="40%" cy="40%">
                        <stop offset="0%" stop-color="#60a5fa" stop-opacity="0.8" />
                        <stop offset="100%" stop-color="#4f46e5" stop-opacity="0.2" />
                    </radialGradient>
                </defs>
            </svg>

            <!-- Cloud Bubble -->
            <div class="cloud-bubble">
                <span>Learn about</span><br />
                <strong>my skills</strong> ✦
                <div class="cloud-tail"></div>
            </div>
        </div>
        <div class="z-10 w-full max-w-6xl mx-auto text-center">
            <h2 class="text-5xl font-bold mb-4 gradient-text">Skills</h2>
            <p class="text-gray-400 text-lg mb-4">Technologies and tools I work with</p>
            <p class="text-indigo-400 text-sm mb-16 tracking-widest uppercase">✦ Click a card to learn more ✦</p>

            <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-4 gap-8">
                <div v-for="skill in skills"
                     :key="skill.name"
                     class="card-wrapper"
                     @click="skill.flipped = !skill.flipped">
                    <div class="card" :class="{ flipped: skill.flipped }">

                        <!-- FRONT -->
                        <div class="card-face card-front">
                            <i :class="skill.icon" class="skill-icon"></i>
                            <p class="font-semibold text-lg mt-4">{{ skill.name }}</p>
                            <p class="text-xs text-gray-400 mt-1">{{ skill.level }}</p>
                        </div>

                        <!-- BACK -->
                        <div class="card-face card-back">
                            <div class="back-icon">{{ skill.emoji }}</div>
                            <h3 class="back-title">{{ skill.name }}</h3>
                            <p class="back-desc">{{ skill.description }}</p>
                        </div>

                    </div>
                </div>
            </div>
        </div>

    </section>
</template>

<script setup>
    import { reactive } from 'vue'

    const skills = reactive([
        {
            name: 'Vue.js',
            icon: 'devicon-vuejs-plain colored',
            level: 'Frontend Framework',
            emoji: '▲',
            description: 'Progressive JavaScript framework for building modern, reactive user interfaces and single-page applications.',
            flipped: false
        },
        {
            name: 'C#',
            icon: 'devicon-csharp-plain colored',
            level: 'Backend Language',
            emoji: '⌗',
            description: 'Powerful object-oriented language by Microsoft. Used for backend APIs, business logic and enterprise applications.',
            flipped: false
        },
        {
            name: '.NET Core',
            icon: 'devicon-dotnetcore-plain colored',
            level: 'Backend Framework',
            emoji: '⬡',
            description: 'Cross-platform framework for building high-performance web APIs and server-side applications with C#.',
            flipped: false
        },
        {
            name: 'JavaScript',
            icon: 'devicon-javascript-plain colored',
            level: 'Frontend Language',
            emoji: 'JS',
            description: 'The language of the web. Used for dynamic interactions, DOM manipulation and modern frontend development.',
            flipped: false
        },
        {
            name: 'SQL Server',
            icon: 'devicon-microsoftsqlserver-plain colored',
            level: 'Database',
            emoji: '🛢',
            description: 'Microsoft relational database system. Used for storing, querying and managing structured application data.',
            flipped: false
        },
        {
            name: 'Git',
            icon: 'devicon-git-plain colored',
            level: 'Version Control',
            emoji: '⎇',
            description: 'Distributed version control system for tracking code changes, branching and collaborating with teams.',
            flipped: false
        },
        {
            name: 'GitHub',
            icon: 'devicon-github-original',
            level: 'Code Hosting',
            emoji: '🐙',
            description: 'Cloud platform for hosting Git repositories. Used for code sharing, collaboration and portfolio showcasing.',
            flipped: false
        },
        {
            name: 'Tailwind CSS',
            icon: 'devicon-tailwindcss-plain colored',
            level: 'CSS Framework',
            emoji: '～',
            description: 'Utility-first CSS framework for building beautiful, responsive designs directly in your HTML markup.',
            flipped: false
        },
        {
            name: 'HTML5',
            icon: 'devicon-html5-plain colored',
            level: 'Markup Language',
            emoji: '⬡',
            description: 'The standard markup language for creating web pages. Defines the structure and content of every website.',
            flipped: false
        },
        {
            name: 'CSS3',
            icon: 'devicon-css3-plain colored',
            level: 'Styling',
            emoji: '③',
            description: 'Stylesheet language for designing and animating web pages. Controls layout, colors, fonts and effects.',
            flipped: false
        },
        {
            name: 'Blazor',
            icon: 'devicon-blazor-original colored',
            level: 'Frontend Framework',
            emoji: '🔥',
            description: 'Microsoft framework for building interactive web UIs using C# instead of JavaScript via WebAssembly.',
            flipped: false
        },
        {
            name: 'React',
            icon: 'devicon-react-original colored',
            level: 'Frontend Framework',
            emoji: '⚛',
            description: 'Popular JavaScript library by Meta for building fast, component-based user interfaces and SPAs.',
            flipped: false
        },
    ])
</script>

<style scoped>
    .gradient-text {
        background: linear-gradient(90deg, #818cf8, #a78bfa, #60a5fa);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        background-clip: text;
    }

    .devicon-github-original {
        color: white !important;
        filter: drop-shadow(0 0 6px rgba(255, 255, 255, 0.4));
    }

    .card-wrapper {
        perspective: 1000px;
        height: 280px;
        cursor: pointer;
    }

    .card {
        width: 100%;
        height: 100%;
        position: relative;
        transform-style: preserve-3d;
        transition: transform 0.6s cubic-bezier(0.4, 0, 0.2, 1);
    }

        .card.flipped {
            transform: rotateY(180deg);
        }

    .card-face {
        position: absolute;
        inset: 0;
        backface-visibility: hidden;
        border-radius: 16px;
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        padding: 24px 16px;
    }

    .card-front {
        background: rgba(255, 255, 255, 0.05);
        border: 1px solid rgba(99, 102, 241, 0.2);
        backdrop-filter: blur(10px);
        transition: all 0.3s ease;
    }

    .card-wrapper:hover .card-front {
        border-color: #6366f1;
        box-shadow: 0 0 25px rgba(99, 102, 241, 0.3);
    }


    .skill-icon {
        font-size: 4.5rem;
    }


    .card-back {
        background: linear-gradient(135deg, rgba(79, 70, 229, 0.3), rgba(124, 58, 237, 0.2));
        border: 1px solid rgba(99, 102, 241, 0.5);
        transform: rotateY(180deg);
        backdrop-filter: blur(10px);
        box-shadow: 0 0 30px rgba(79, 70, 229, 0.3);
        padding: 20px;
        text-align: center;
    }



    .back-icon {
        font-size: 3rem;
        margin-bottom: 12px;
        color: #a5b4fc;
        font-weight: 700;
        font-family: 'IBM Plex Serif', serif;
    }


    .back-title {
        font-size: 1.5rem;
        font-weight: 700;
        color: #a5b4fc;
        margin-bottom: 12px;
        font-family: 'IBM Plex Serif', serif;
    }



    .back-desc {
        font-size: 1rem;
        color: #cbd5e1;
        line-height: 1.7;
    }

    .grid {
        gap: 24px; 
    }

    /* ── Robonaut ── */
    .robonaut-wrapper {
        position: absolute;
        left: 200px;
        top: 20%;
        transform: translateY(-50%);
        display: flex;
        flex-direction: row;
        align-items: center;
        gap: 16px;
        z-index: 10;
        animation: floatRobo 10s ease-in-out infinite;
    }

    .robonaut-svg {
        width: 130px;
        height: 130px;
        filter: drop-shadow(0 0 14px rgba(129, 140, 248, 0.9));
        flex-shrink: 0;
    }

    .cloud-bubble {
        position: relative;
        margin-top: -130px;
        background: rgba(15, 12, 41, 0.95);
        border: 1px solid rgba(99, 102, 241, 0.5);
        border-radius: 50px;
        padding: 16px 22px;
        font-size: 1.04rem;
        font-family: 'IBM Plex Serif', serif;
        color: #c7d2fe;
        text-align: center;
        line-height: 1.7;
        backdrop-filter: blur(10px);
        box-shadow: 0 0 25px rgba(79, 70, 229, 0.3);
        min-width: 160px;
    }

        .cloud-bubble strong {
            background: linear-gradient(90deg, #818cf8, #a78bfa, #60a5fa);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            font-weight: 700;
        }

    .cloud-tail {
        position: absolute;
        left: -17px;
        top: 70%;
        transform: translateY(-50%) rotate(-25deg);
        border-top: 8px solid transparent;
        border-bottom: 8px solid transparent;
        border-right: 12px solid rgba(99, 102, 241, 0.5);
    }
</style>