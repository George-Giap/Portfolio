<template>
    <div class="app-wrapper">
        <div class="orb orb-1"></div>
        <div class="orb orb-2"></div>
        <div class="orb orb-3"></div>
        <div class="orb orb-4"></div>
        <div class="orb orb-5"></div>
        <div class="grid-overlay"></div>

        <div class="code-snippet snippet-1">const dev = "Georgios"</div>
        <div class="code-snippet snippet-2">&lt;Portfolio /&gt;</div>
        <div class="code-snippet snippet-3">git push origin main</div>
        <div class="code-snippet snippet-4">npm run dev</div>
        <div class="code-snippet snippet-5">SELECT * FROM skills</div>

        <div class="galaxy-bg"></div>

        <div class="rocket-wrapper" ref="rocketRef">
            <svg class="rocket-svg" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                <path d="M12 2C12 2 7 6 7 13H9C9 10 12 7 12 7C15 10 15 13 15 13H17C17 6 12 2 12 2Z" fill="#818cf8" />
                <path d="M9 13H15V17L12 22L9 17V13Z" fill="#6366f1" />
                <path d="M7 14H9V16L7 17V14Z" fill="#a78bfa" opacity="0.6" />
                <path d="M15 14H17V17L15 16V14Z" fill="#a78bfa" opacity="0.6" />
                <circle cx="12" cy="11" r="2" fill="#e0e7ff" opacity="0.9" />
            </svg>
            <div class="trail"></div>
        </div>

        <NavBar />
        <RouterView />
        <RoboNautChat />
    </div>
</template>

<script setup>
    import RoboNautChat from './components/RoboNautChat.vue'
    import { ref, onMounted, onUnmounted } from 'vue'
    import NavBar from './components/NavBar.vue'

    const rocketRef = ref(null)
    let timeoutId = null

    function launchRocket() {
        const rocket = rocketRef.value
        if (!rocket) return

        const startPositions = [
            { x: Math.random() * window.innerWidth, y: window.innerHeight + 60 },
            { x: -60, y: Math.random() * window.innerHeight },
            { x: window.innerWidth + 60, y: Math.random() * window.innerHeight },
        ]
        const start = startPositions[Math.floor(Math.random() * startPositions.length)]
        const endX = (Math.random() - 0.5) * 2000
        const endY = -(Math.random() * 800 + 400)
        const angle = Math.atan2(endX, -endY) * (180 / Math.PI)

        rocket.style.transition = 'none'
        rocket.style.opacity = '0'
        rocket.style.transform = `translate(${start.x}px, ${start.y}px) rotate(${angle}deg)`

        setTimeout(() => {
            rocket.style.transition = 'transform 4s ease-in, opacity 0.3s ease'
            rocket.style.opacity = '1'
            rocket.style.transform = `translate(${start.x + endX}px, ${start.y + endY}px) rotate(${angle}deg)`
            setTimeout(() => { rocket.style.opacity = '0' }, 3500)
            timeoutId = setTimeout(launchRocket, Math.random() * 5000 + 5000)
        }, 50)
    }

    onMounted(() => {
        timeoutId = setTimeout(launchRocket, 2000)
    })

    onUnmounted(() => {
        clearTimeout(timeoutId)
    })
</script>

<style scoped>
    .app-wrapper {
        min-height: 100vh;
        background-color: #0a0a1a;
        position: relative;
        overflow-x: hidden;
    }

    .galaxy-bg {
        position: fixed;
        inset: 0;
        z-index: 0;
        pointer-events: none;
        background-image: url('./assets/galaxy.jpg');
        background-size: cover;
        background-position: center;
        background-repeat: no-repeat;
        opacity: 0.25;
        filter: brightness(0.6) contrast(1.2) saturate(1.3);
    }

    .orb {
        position: fixed;
        border-radius: 50%;
        filter: blur(80px);
        opacity: 0.5;
        animation: floatOrb 10s ease-in-out infinite;
        pointer-events: none;
        z-index: 0;
    }

    .orb-1 {
        width: 500px;
        height: 500px;
        background: radial-gradient(circle, #4f46e5, transparent 70%);
        top: -150px;
        left: -150px;
        animation-delay: 0s;
    }

    .orb-2 {
        width: 450px;
        height: 450px;
        background: radial-gradient(circle, #7c3aed, transparent 70%);
        bottom: -150px;
        right: -100px;
        animation-delay: -4s;
    }

    .orb-3 {
        width: 300px;
        height: 300px;
        background: radial-gradient(circle, #2563eb, transparent 70%);
        top: 40%;
        left: 40%;
        animation-delay: -7s;
    }

    .orb-4 {
        width: 200px;
        height: 200px;
        background: radial-gradient(circle, #ec4899, transparent 70%);
        top: 20%;
        right: 30%;
        opacity: 0.15;
        animation-delay: -2s;
        animation-duration: 14s;
    }

    .orb-5 {
        width: 150px;
        height: 150px;
        background: radial-gradient(circle, #06b6d4, transparent 70%);
        bottom: 20%;
        left: 20%;
        opacity: 0.15;
        animation-delay: -5s;
        animation-duration: 12s;
    }

    @keyframes floatOrb {
        0%, 100% {
            transform: translate(0px, 0px) scale(1);
        }

        33% {
            transform: translate(40px, -40px) scale(1.08);
        }

        66% {
            transform: translate(-30px, 30px) scale(0.95);
        }
    }

    .grid-overlay {
        position: fixed;
        inset: 0;
        background-image: linear-gradient(rgba(99,102,241,0.07) 1px, transparent 1px), linear-gradient(90deg, rgba(99,102,241,0.07) 1px, transparent 1px);
        background-size: 50px 50px;
        pointer-events: none;
        z-index: 0;
    }

    .code-snippet {
        position: fixed;
        font-family: 'Courier New', monospace;
        font-size: 0.85rem;
        color: rgba(129,140,248,0.2);
        pointer-events: none;
        z-index: 0;
        white-space: nowrap;
        animation: floatCode 12s ease-in-out infinite;
    }

    .snippet-1 {
        top: 15%;
        left: 5%;
        animation-delay: 0s;
    }

    .snippet-2 {
        top: 30%;
        right: 5%;
        animation-delay: -3s;
    }

    .snippet-3 {
        top: 60%;
        left: 8%;
        animation-delay: -6s;
    }

    .snippet-4 {
        top: 75%;
        right: 8%;
        animation-delay: -9s;
    }

    .snippet-5 {
        top: 45%;
        left: 50%;
        animation-delay: -5s;
    }

    @keyframes floatCode {
        0%, 100% {
            transform: translateY(0px);
            opacity: 0.2;
        }

        50% {
            transform: translateY(-15px);
            opacity: 0.45;
        }
    }

    .rocket-wrapper {
        position: fixed;
        z-index: 1;
        pointer-events: none;
        opacity: 0;
        top: 0;
        left: 0;
    }

    .rocket-svg {
        width: 28px;
        height: 28px;
        filter: drop-shadow(0 0 8px rgba(129,140,248,0.9)) drop-shadow(0 0 16px rgba(99,102,241,0.5));
    }

    .trail {
        position: absolute;
        bottom: -5px;
        left: 50%;
        transform: translateX(-50%);
        width: 2px;
        height: 50px;
        background: linear-gradient(to bottom, rgba(129,140,248,0.9), rgba(99,102,241,0.3), transparent);
        border-radius: 4px;
    }
</style>