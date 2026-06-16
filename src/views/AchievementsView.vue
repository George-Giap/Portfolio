<template>
    <section class="min-h-screen flex items-center justify-center text-white px-8 relative overflow-hidden bg-[#0a0a1a]">
        <div class="orb orb-1"></div>
        <div class="orb orb-2"></div>
        <div class="grid-overlay"></div>
        <div class="z-10 text-center">
            <h1 class="text-6xl font-bold gradient-text mb-6">Achievements</h1>
            <p class="text-gray-400 text-xl">Coming Soon 🏆</p>
        </div>
    </section>
</template>

<style scoped>
    .orb {
        position: absolute;
        border-radius: 50%;
        filter: blur(80px);
        opacity: 0.5;
        animation: floatOrb 10s ease-in-out infinite;
        pointer-events: none;
    }

    .orb-1 {
        width: 500px;
        height: 500px;
        background: radial-gradient(circle, #4f46e5, transparent 70%);
        top: -150px;
        left: -150px;
    }

    .orb-2 {
        width: 450px;
        height: 450px;
        background: radial-gradient(circle, #7c3aed, transparent 70%);
        bottom: -150px;
        right: -100px;
        animation-delay: -4s;
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
        position: absolute;
        inset: 0;
        background-image: linear-gradient(rgba(99, 102, 241, 0.07) 1px, transparent 1px), linear-gradient(90deg, rgba(99, 102, 241, 0.07) 1px, transparent 1px);
        background-size: 50px 50px;
        pointer-events: none;
    }

    .gradient-text {
        background: linear-gradient(90deg, #818cf8, #a78bfa, #60a5fa);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        background-clip: text;
    }
</style>