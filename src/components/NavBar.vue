<template>
    <nav class="fixed top-0 w-full text-white z-50" style="background-color: #0a0a1a;">
        <div class="flex items-center justify-between px-10 py-5">

            <!-- LEFT: Spaceman Logo -->
            <RouterLink to="/" @click="goHome" class="logo-link">
                <div class="logo-wrapper">
                    <svg viewBox="0 0 64 64" class="logo-svg" xmlns="http://www.w3.org/2000/svg">
                        <!-- Helmet -->
                        <circle cx="32" cy="22" r="16" fill="#1e1b4b" stroke="#818cf8" stroke-width="2" />
                        <!-- Visor -->
                        <ellipse cx="32" cy="22" rx="9" ry="8" fill="#312e81" opacity="0.9" />
                        <ellipse cx="32" cy="22" rx="9" ry="8" fill="url(#visorGrad)" opacity="0.6" />
                        <!-- Visor shine -->
                        <ellipse cx="28" cy="18" rx="3" ry="2" fill="white" opacity="0.3" />
                        <!-- Suit body -->
                        <rect x="20" y="36" width="24" height="18" rx="8" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5" />
                        <!-- Suit chest panel -->
                        <rect x="26" y="40" width="12" height="8" rx="3" fill="#312e81" stroke="#6366f1" stroke-width="1" />
                        <!-- Chest light -->
                        <circle cx="32" cy="44" r="2" fill="#818cf8" opacity="0.9" />
                        <!-- Left arm -->
                        <rect x="10" y="37" width="10" height="14" rx="5" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5" />
                        <!-- Right arm -->
                        <rect x="44" y="37" width="10" height="14" rx="5" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5" />
                        <!-- Gloves -->
                        <circle cx="15" cy="52" r="4" fill="#312e81" stroke="#818cf8" stroke-width="1" />
                        <circle cx="49" cy="52" r="4" fill="#312e81" stroke="#818cf8" stroke-width="1" />
                        <!-- Gradient for visor -->
                        <defs>
                            <radialGradient id="visorGrad" cx="40%" cy="40%">
                                <stop offset="0%" stop-color="#60a5fa" stop-opacity="0.8" />
                                <stop offset="100%" stop-color="#4f46e5" stop-opacity="0.2" />
                            </radialGradient>
                        </defs>
                    </svg>
                    <span class="logo-text">RoboNaut</span>
                </div>
            </RouterLink>

            <!-- CENTER: Nav Links -->
            <div class="flex items-center gap-20">

                <!-- HOME + DROPDOWN -->
                <div class="nav-item" @mouseenter="homeOpen = true" @mouseleave="homeOpen = false">
                    <div class="flex items-center gap-2">
                        <a @click="goHome" class="nav-link cursor-pointer">Home</a>
                        <svg class="w-5 h-5 cursor-pointer" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                            <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M19 9l-7 7-7-7" />
                        </svg>
                    </div>
                    <div v-if="homeOpen" class="dropdown-wrapper">
                        <div class="dropdown-menu">
                            <a @click="scrollTo('bio')" class="dropdown-item">👤 About Me</a>
                            <RouterLink to="/bio" class="dropdown-item">📖 Personal Bio</RouterLink>

                        </div>
                    </div>
                </div>

                <!-- Skills -->
                <RouterLink to="/skills" class="nav-link">Skills</RouterLink>

                <!-- Personal Projects -->
                <RouterLink to="/projects" class="nav-link">Personal Projects</RouterLink>

                <!-- CONTACT + DROPDOWN -->
                <div class="nav-item" @mouseenter="contactOpen = true" @mouseleave="contactOpen = false">
                    <div class="flex items-center gap-2">
                        <RouterLink to="/contact" class="nav-link">Contact</RouterLink>
                        <svg class="w-5 h-5 cursor-pointer" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                            <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M19 9l-7 7-7-7" />
                        </svg>
                    </div>
                    <div v-if="contactOpen" class="dropdown-wrapper">
                        <div class="dropdown-menu">
                            <RouterLink to="/contact-info" class="dropdown-item">📋 Personal Info</RouterLink>
                            <RouterLink to="/contact" class="dropdown-item">✉️ Contact Form</RouterLink>
                        </div>
                    </div>
                </div>

            </div>

            <!-- RIGHT: empty spacer to balance layout -->
            <div class="w-32"></div>

        </div>
    </nav>
</template>

<script setup>
    import { ref } from 'vue'
    import { useRouter } from 'vue-router'

    const homeOpen = ref(false)
    const contactOpen = ref(false)
    const router = useRouter()

    async function goHome() {
        homeOpen.value = false
        if (window.location.pathname !== '/') {
            await router.push('/')
            setTimeout(() => {
                document.getElementById('hero')?.scrollIntoView({ behavior: 'smooth' })
            }, 300)
        } else {
            document.getElementById('hero')?.scrollIntoView({ behavior: 'smooth' })
        }
    }

    async function scrollTo(id) {
        homeOpen.value = false
        if (window.location.pathname !== '/') {
            await router.push('/')
            setTimeout(() => {
                document.getElementById(id)?.scrollIntoView({ behavior: 'smooth' })
            }, 300)
        } else {
            document.getElementById(id)?.scrollIntoView({ behavior: 'smooth' })
        }
    }
</script>

<style scoped>
    /* Logo */
    .logo-link {
        text-decoration: none;
    }

    .logo-wrapper {
        display: flex;
        align-items: center;
        gap: 10px;
        transition: all 0.3s ease;
    }

        .logo-wrapper:hover {
            transform: scale(1.05);
        }

    .logo-svg {
        width: 52px;
        height: 52px;
        filter: drop-shadow(0 0 8px rgba(129, 140, 248, 0.7));
        animation: floatAstronaut 4s ease-in-out infinite;
    }

    .logo-text {
        font-size: 1.4rem;
        font-weight: 700;
        font-family: 'IBM Plex Serif', serif;
        background: linear-gradient(90deg, #818cf8, #a78bfa, #60a5fa);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        background-clip: text;
        letter-spacing: 0.05em;
    }

    @keyframes floatAstronaut {
        0%, 100% {
            transform: translateY(0px);
        }

        50% {
            transform: translateY(-5px);
        }
    }

    /* Nav */
    .nav-item {
        position: relative;
        padding-bottom: 8px;
        margin-bottom: -8px;
    }

    .nav-link {
        font-size: 1.875rem;
        font-weight: 600;
        letter-spacing: 0.05em;
        color: white;
        text-decoration: none;
        transition: color 0.25s ease;
        cursor: pointer;
    }

        .nav-link:hover {
            color: #818cf8;
        }

    /* Dropdown */
    .dropdown-wrapper {
        position: absolute;
        top: 100%;
        left: 50%;
        transform: translateX(-50%);
        width: 210px;
        z-index: 99;
    }

    .dropdown-menu {
        background: rgba(15, 12, 41, 0.97);
        border: 1px solid rgba(99, 102, 241, 0.3);
        border-radius: 14px;
        overflow: hidden;
        backdrop-filter: blur(16px);
        box-shadow: 0 20px 40px rgba(0,0,0,0.5), 0 0 25px rgba(79, 70, 229, 0.2);
    }

    .dropdown-item {
        display: block;
        padding: 14px 20px;
        font-size: 1rem;
        font-family: 'IBM Plex Serif', serif;
        font-weight: 400;
        color: #a5b4fc;
        text-decoration: none;
        text-align: center;
        letter-spacing: 0.08em;
        transition: all 0.25s ease;
        border-bottom: 1px solid rgba(99, 102, 241, 0.1);
        cursor: pointer;
    }

        .dropdown-item:last-child {
            border-bottom: none;
        }

        .dropdown-item:hover {
            background: rgba(79, 70, 229, 0.25);
            color: white;
        }
</style>