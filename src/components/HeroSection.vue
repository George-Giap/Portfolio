<template>
  <div class="page-wrapper">

    <div class="scroll-progress" :style="{ width: scrollProgress + '%' }"></div>

    <section id="hero" class="hero-section">

      <div class="hero-content" :class="{ 'hero-visible': heroVisible }">
        <p class="hi-text">Hi, I Am</p>
        <h1 class="name-text mb-6">
          Georgios<br/>
          <span class="gradient-text">Giapitzakis</span>
        </h1>
        <h2 class="subtitle">
          Junior Developer · Vue.js · Javascript · ASP.NET Core · C#
        </h2>
        <p class="description">
          Passionate about building clean, efficient software.
          Currently learning and growing every day.
        </p>
        <div class="flex gap-6 justify-center">
          <RouterLink to="/projects" class="btn-primary">View Projects</RouterLink>
          <RouterLink to="/contact" class="btn-secondary">Contact Me</RouterLink>
        </div>
      </div>

      <div class="robonaut-wrapper">
        <svg viewBox="0 0 64 64" class="robonaut-svg" xmlns="http://www.w3.org/2000/svg">
          <circle cx="32" cy="22" r="16" fill="#1e1b4b" stroke="#818cf8" stroke-width="2"/>
          <ellipse cx="32" cy="22" rx="9" ry="8" fill="#312e81" opacity="0.9"/>
          <ellipse cx="32" cy="22" rx="9" ry="8" fill="url(#visorGrad2)" opacity="0.6"/>
          <ellipse cx="28" cy="18" rx="3" ry="2" fill="white" opacity="0.3"/>
          <rect x="20" y="36" width="24" height="18" rx="8" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5"/>
          <rect x="26" y="40" width="12" height="8" rx="3" fill="#312e81" stroke="#6366f1" stroke-width="1"/>
          <circle cx="32" cy="44" r="2" fill="#818cf8" opacity="0.9"/>
          <rect x="10" y="37" width="10" height="14" rx="5" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5"/>
          <rect x="44" y="37" width="10" height="14" rx="5" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5"/>
          <circle cx="15" cy="52" r="4" fill="#312e81" stroke="#818cf8" stroke-width="1"/>
          <circle cx="49" cy="52" r="4" fill="#312e81" stroke="#818cf8" stroke-width="1"/>
          <defs>
            <radialGradient id="visorGrad2" cx="40%" cy="40%">
              <stop offset="0%" stop-color="#60a5fa" stop-opacity="0.8"/>
              <stop offset="100%" stop-color="#4f46e5" stop-opacity="0.2"/>
            </radialGradient>
          </defs>
        </svg>
        <div class="cloud-bubble">
          <span>Welcome to</span><br/>
          <strong>RoboNaut Coding</strong> 🚀
          <div class="cloud-tail"></div>
        </div>
      </div>

      <p class="athens-tag">Athens, Greece 🇬🇷</p>

      <div class="scroll-hint" :class="{ 'hint-hidden': scrollY > 50 }">
        <div class="scroll-hint-dot"></div>
        <p>Scroll</p>
      </div>

      <div class="wave-wrapper">
        <svg viewBox="0 0 1440 120" preserveAspectRatio="none" xmlns="http://www.w3.org/2000/svg">
          <path d="M0,60 C180,120 360,0 540,60 C720,120 900,0 1080,60 C1260,120 1380,40 1440,60 L1440,120 L0,120 Z"
                fill="#0d0d2b"/>
        </svg>
      </div>
    </section>

    <section id="bio" ref="bioRef" class="bio-section"
             :class="{ 'bio-visible': bioVisible }"
             style="background-color: #0d0d2b;">

      <div class="stair-wrapper">
        <svg viewBox="0 0 400 300" xmlns="http://www.w3.org/2000/svg" class="stair-svg">
          <text x="345" y="18" font-size="35" text-anchor="middle">🏆</text>
          <polyline
            points="0,300 0,240 60,240 60,180 120,180 120,130 180,130 180,90 240,90 240,55 300,55 300,25 380,25"
            fill="none" stroke="url(#stairGrad)" stroke-width="3"
            stroke-linecap="round" stroke-linejoin="round"/>
          <circle cx="60"  cy="240" r="4" fill="#818cf8" opacity="0.8"/>
          <circle cx="120" cy="180" r="4" fill="#818cf8" opacity="0.8"/>
          <circle cx="180" cy="130" r="4" fill="#818cf8" opacity="0.8"/>
          <circle cx="240" cy="90"  r="4" fill="#818cf8" opacity="0.8"/>
          <circle cx="300" cy="55"  r="4" fill="#818cf8" opacity="0.8"/>
          <text x="18"  y="268" font-size="14" fill="#a5b4fc" font-weight="600">Start</text>
          <text x="68"  y="208" font-size="14" fill="#a5b4fc" font-weight="600">Learn</text>
          <text x="128" y="158" font-size="14" fill="#a5b4fc" font-weight="600">Build</text>
          <text x="188" y="118" font-size="14" fill="#a5b4fc" font-weight="600">Grow</text>
          <text x="248" y="78"  font-size="14" fill="#a5b4fc" font-weight="600">Deliver</text>
          <text x="308" y="44"  font-size="14" fill="#ffffff" font-weight="bold">Success</text>
          <defs>
            <linearGradient id="stairGrad" x1="0%" y1="100%" x2="100%" y2="0%">
              <stop offset="0%"   stop-color="#312e81" stop-opacity="0.6"/>
              <stop offset="50%"  stop-color="#4f46e5" stop-opacity="0.9"/>
              <stop offset="100%" stop-color="#818cf8" stop-opacity="1"/>
            </linearGradient>
          </defs>
        </svg>
      </div>

      <div class="max-w-6xl mx-auto z-10 w-full px-8">
        <div class="flex flex-col md:flex-row items-center gap-16">

          <div class="flex-1 text-left">
            <h2 class="text-5xl font-bold mb-4 gradient-text reveal-item" :class="{ revealed: bioVisible }">About Me</h2>
            <div class="bio-line mb-8"></div>
            <p class="text-gray-300 text-xl leading-relaxed mb-6 reveal-item delay-1" :class="{ revealed: bioVisible }">
              I'm <span class="text-indigo-400 font-semibold">Georgios Giapitzakis</span>, a Junior Developer
              based in Athens, Greece. I specialize in building modern web applications
              using <span class="text-indigo-400">Vue.js</span>,
              <span class="text-indigo-400">Blazor WebAssembly</span> and
              <span class="text-indigo-400">JavaScript</span> on the frontend and
              <span class="text-indigo-400">ASP.NET Core with C#</span> on the backend.
            </p>
            <p class="text-gray-400 text-lg leading-relaxed mb-12 reveal-item delay-2" :class="{ revealed: bioVisible }">
              Passionate about clean code, continuous learning, and turning ideas
              into real working software. Expanding my skills in full-stack
              development, database management and real-world application architecture.
            </p>
            <div class="grid grid-cols-3 gap-6 mb-16">
              <div class="stat-card reveal-item delay-1" :class="{ revealed: bioVisible }">
                <h3 class="text-5xl font-bold gradient-text">1+</h3>
                <p class="text-gray-400 mt-3 tracking-wide">Year Experience</p>
              </div>
              <div class="stat-card reveal-item delay-2" :class="{ revealed: bioVisible }">
                <h3 class="text-5xl font-bold gradient-text">10+</h3>
                <p class="text-gray-400 mt-3 tracking-wide">Technologies</p>
              </div>
              <div class="stat-card reveal-item delay-3" :class="{ revealed: bioVisible }">
                <h3 class="text-5xl font-bold gradient-text">∞</h3>
                <p class="text-gray-400 mt-3 tracking-wide">Passion to Learn</p>
              </div>
            </div>
            <div @click="backToTop" class="flex flex-col items-center gap-2 cursor-pointer group w-full text-center mt-24">
              <div class="back-top-dot"></div>
              <p class="text-gray-500 text-xs tracking-widest uppercase group-hover:text-indigo-400 transition">Back to Top</p>
            </div>
          </div>

          <div class="flex-shrink-0 flex flex-col items-center gap-4 reveal-item delay-2" :class="{ revealed: bioVisible }">
            <div class="photo-ring">
              <img src="../assets/profile.jpg" alt="Georgios Giapitzakis"
                   class="w-full h-full object-cover object-top scale-105"/>
            </div>
            <p class="text-indigo-400 text-sm tracking-widest uppercase">Georgios Giapitzakis</p>
            <p class="text-gray-500 text-xs tracking-wide">Junior Developer</p>
          </div>

        </div>
      </div>
    </section>

  </div>
</template>

<script setup>
import { ref, onMounted, onUnmounted } from 'vue'

const bioRef         = ref(null)
const bioVisible     = ref(false)
const heroVisible    = ref(false)
const scrollProgress = ref(0)
const scrollY        = ref(0)
const isScrolling    = ref(false)
const currentPage    = ref(0)
let observer = null

function updateScroll() {
  const total = document.documentElement.scrollHeight - window.innerHeight
  scrollY.value        = window.scrollY
  scrollProgress.value = total > 0 ? (window.scrollY / total) * 100 : 0
}

function goToBio() {
  if (isScrolling.value) return
  isScrolling.value = true
  bioVisible.value  = true
  document.getElementById('bio')?.scrollIntoView({ behavior: 'smooth' })
  currentPage.value = 1
  setTimeout(() => { isScrolling.value = false }, 1000)
}

function backToTop() {
  if (isScrolling.value) return
  isScrolling.value = true
  document.getElementById('hero')?.scrollIntoView({ behavior: 'smooth' })
  currentPage.value = 0
  setTimeout(() => { isScrolling.value = false }, 1000)
}

function handleWheel(e) {
  if (isScrolling.value) { e.preventDefault(); return }
  if (e.deltaY > 30 && currentPage.value === 0) {
    e.preventDefault(); goToBio()
  } else if (e.deltaY < -30 && currentPage.value === 1) {
    e.preventDefault(); backToTop()
  }
}

onMounted(() => {
  setTimeout(() => { heroVisible.value = true }, 100)
  window.addEventListener('scroll', updateScroll, { passive: true })
  window.addEventListener('wheel',  handleWheel,  { passive: false })
  observer = new IntersectionObserver(
    ([entry]) => { if (entry.isIntersecting) bioVisible.value = true },
    { threshold: 0.15 }
  )
  if (bioRef.value) observer.observe(bioRef.value)
})

onUnmounted(() => {
  window.removeEventListener('scroll', updateScroll)
  window.removeEventListener('wheel',  handleWheel)
  if (observer) observer.disconnect()
})
</script>

<style scoped>
.page-wrapper {
  min-height: 100vh;
}

.scroll-progress {
  position: fixed;
  top: 0; left: 0;
  height: 3px;
  background: linear-gradient(90deg, #4f46e5, #818cf8, #a78bfa);
  z-index: 9999;
  transition: width 0.1s ease;
  box-shadow: 0 0 8px rgba(129,140,248,0.8);
}

.hero-section {
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
  color: white;
  position: relative;
  overflow: hidden;
}

.hero-content {
  z-index: 10;
  width: 100%;
  max-width: 64rem;
  margin: 0 auto;
  text-align: center;
  padding: 2rem;
  opacity: 0;
  transform: translateY(40px) scale(0.97);
  transition: all 1s cubic-bezier(0.4, 0, 0.2, 1);
}
.hero-visible {
  opacity: 1 !important;
  transform: translateY(0) scale(1) !important;
}

.hi-text {
  font-size: 1.4rem;
  font-weight: 400;
  color: #a5b4fc;
  letter-spacing: 0.2em;
  text-transform: uppercase;
  margin-bottom: 16px;
  font-family: 'Georgia', serif;
  font-style: italic;
}
.name-text {
  font-size: 6.5rem;
  font-weight: 300;
  font-family: 'Georgia', serif;
  letter-spacing: 0.05em;
  line-height: 1.15;
}
.gradient-text {
  background: linear-gradient(90deg, #818cf8, #a78bfa, #60a5fa);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  background-clip: text;
}
.subtitle {
  font-size: 1.5rem;
  color: #9ca3af;
  margin-bottom: 2rem;
}
.description {
  color: #d1d5db;
  max-width: 42rem;
  margin: 0 auto 2.5rem;
  line-height: 1.8;
  font-size: 1.1rem;
}

.btn-primary {
  padding: 14px 36px;
  background: linear-gradient(135deg, #4f46e5, #7c3aed);
  border-radius: 10px;
  font-weight: 600;
  font-size: 1.1rem;
  transition: all 0.3s ease;
  box-shadow: 0 0 20px rgba(79,70,229,0.4);
  text-decoration: none;
  color: white;
}
.btn-primary:hover {
  transform: translateY(-3px) scale(1.03);
  box-shadow: 0 0 35px rgba(79,70,229,0.7);
}
.btn-secondary {
  padding: 14px 36px;
  border: 2px solid #6366f1;
  border-radius: 10px;
  font-weight: 600;
  font-size: 1.1rem;
  transition: all 0.3s ease;
  text-decoration: none;
  color: white;
}
.btn-secondary:hover {
  background: #6366f1;
  transform: translateY(-3px) scale(1.03);
  box-shadow: 0 0 25px rgba(99,102,241,0.5);
}

.athens-tag {
  position: fixed;
  bottom: 24px; right: 32px;
  color: rgba(165,180,252,0.6);
  font-size: 0.75rem;
  letter-spacing: 0.2em;
  text-transform: uppercase;
  z-index: 50;
}

.scroll-hint {
  position: absolute;
  bottom: 140px; left: 50%;
  transform: translateX(-50%);
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 8px;
  color: rgba(165,180,252,0.6);
  font-size: 0.75rem;
  letter-spacing: 0.2em;
  text-transform: uppercase;
  z-index: 10;
  transition: opacity 0.5s ease;
}
.hint-hidden { opacity: 0; }
.scroll-hint-dot {
  width: 6px; height: 6px;
  background: #818cf8;
  border-radius: 50%;
  animation: bounceDown 1.5s ease-in-out infinite;
}
@keyframes bounceDown {
  0%, 100% { transform: translateY(0);   opacity: 1;   }
  50%       { transform: translateY(8px); opacity: 0.4; }
}

.wave-wrapper {
  position: absolute;
  bottom: -2px; left: 0;
  width: 100%; line-height: 0;
  z-index: 5;
}
.wave-wrapper svg {
  display: block;
  width: 100%; height: 120px;
  animation: waveFlow 6s ease-in-out infinite;
}
@keyframes waveFlow {
  0%, 100% { transform: translateX(0);    }
  50%       { transform: translateX(-20px); }
}

.robonaut-wrapper {
  position: absolute;
  left: 250px; top: 40%;
  transform: translateY(-50%);
  display: flex;
  flex-direction: row;
  align-items: flex-start;
  gap: 16px;
  z-index: 10;
  animation: floatRobo 10s ease-in-out infinite;
}
.robonaut-svg {
  width: 180px; height: 130px;
  filter: drop-shadow(0 0 14px rgba(129,140,248,0.9));
  flex-shrink: 0;
}
.cloud-bubble {
  position: relative;
  margin-top: -40px;
  background: rgba(15,12,41,0.95);
  border: 4px solid rgba(99,102,241,0.5);
  border-radius: 50px;
  padding: 32px 50px;
  font-size: 1.03rem;
  font-family: 'IBM Plex Serif', serif;
  color: #c7d2fe;
  text-align: center;
  line-height: 1.7;
  backdrop-filter: blur(10px);
  box-shadow: 0 0 25px rgba(79,70,229,0.3);
  min-width: 200px;
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
  left: -20px; top: 80%;
  transform: translateY(-50%) rotate(-25deg);
  border-top: 8px solid transparent;
  border-bottom: 8px solid transparent;
  border-right: 12px solid rgba(99,102,241,0.5);
}
@keyframes floatRobo {
  0%, 100% { transform: translateY(-50%);              }
  50%       { transform: translateY(calc(-50% - 10px)); }
}

.reveal-item {
  opacity: 0;
  transform: translateY(30px);
  transition: all 0.8s cubic-bezier(0.4,0,0.2,1);
}
.reveal-item.revealed { opacity: 1; transform: translateY(0); }
.delay-1 { transition-delay: 0.2s; }
.delay-2 { transition-delay: 0.4s; }
.delay-3 { transition-delay: 0.6s; }

.bio-section {
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
  color: white;
  padding: 2rem;
  position: relative;
  opacity: 0;
  transform: translateY(60px);
  transition: opacity 1.2s ease, transform 1.2s cubic-bezier(0.4,0,0.2,1);
}
.bio-visible { opacity: 1 !important; transform: translateY(0) !important; }
.bio-line {
  width: 80px; height: 3px;
  background: linear-gradient(90deg, #4f46e5, #7c3aed);
  margin: 0; border-radius: 2px;
}

.stat-card {
  background: rgba(255,255,255,0.04);
  border: 1px solid rgba(99,102,241,0.2);
  border-radius: 16px;
  padding: 32px 16px;
  text-align: center;
  transition: all 0.4s ease;
  backdrop-filter: blur(10px);
}
.stat-card:hover {
  border-color: #6366f1;
  background: rgba(79,70,229,0.15);
  transform: translateY(-8px) rotateX(5deg);
  box-shadow: 0 20px 40px rgba(99,102,241,0.3);
}

.back-top-dot {
  width: 6px; height: 6px;
  background: #6366f1; border-radius: 50%;
  animation: bounceUp 1.5s ease-in-out infinite;
}
@keyframes bounceUp {
  0%, 100% { transform: translateY(0);    opacity: 1;   }
  50%       { transform: translateY(-8px); opacity: 0.4; }
}

.photo-ring {
  width: 280px; height: 280px;
  border-radius: 50%;
  padding: 4px;
  background: linear-gradient(135deg, #4f46e5, #7c3aed, #2563eb);
  box-shadow: 0 0 40px rgba(79,70,229,0.5);
  overflow: hidden;
  animation: pulseBorder 3s ease-in-out infinite;
  transition: transform 0.4s ease;
}
.photo-ring:hover { transform: scale(1.05) rotateY(5deg); }
@keyframes pulseBorder {
  0%, 100% { box-shadow: 0 0 30px rgba(79,70,229,0.4); }
  50%       { box-shadow: 0 0 60px rgba(124,58,237,0.8); }
}

.stair-wrapper {
  position: absolute;
  left: 80px; top: 15%;
  opacity: 0.6;
  pointer-events: none;
  z-index: 0;
  animation: stairGlow 8s ease-in-out infinite;
}
.stair-svg {
  width: 450px; height: 700px;
  filter: drop-shadow(0 0 10px rgba(99,102,241,0.8));
}
@keyframes stairGlow {
  0%, 100% { opacity: 0.5; }
  50%       { opacity: 0.8; }
}
</style>
