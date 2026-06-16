<template>
    <section class="min-h-screen flex items-center justify-center text-white px-8 pt-24" style="background-color: #0a0a1a;">
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
                <span>Here u can find</span><br />
                <strong> my personal Info </strong> ✦
                <div class="cloud-tail"></div>
            </div>
        </div>
            <div class="max-w-3xl mx-auto z-10 w-full">

                <h1 class="text-5xl font-bold mb-4 gradient-text">Personal Info</h1>
                <div class="bio-line mb-12"></div>

                <div class="grid grid-cols-1 gap-6">

                    <div class="info-card">
                        <span class="text-2xl">👤</span>
                        <div>
                            <p class="text-gray-400 text-sm uppercase tracking-widest mb-1">Full Name</p>
                            <p class="text-white text-lg font-semibold">Georgios Giapitzakis</p>
                        </div>
                    </div>

                    <div class="info-card">
                        <span class="text-2xl">📍</span>
                        <div>
                            <p class="text-gray-400 text-sm uppercase tracking-widest mb-1">Location</p>
                            <p class="text-white text-lg font-semibold">Athens, Greece 🇬🇷</p>
                        </div>
                    </div>

                    <div class="info-card">
                        <span class="text-2xl">💼</span>
                        <div>
                            <p class="text-gray-400 text-sm uppercase tracking-widest mb-1">Role</p>
                            <p class="text-white text-lg font-semibold">Junior Full-Stack Developer</p>
                        </div>
                    </div>
                    <div class="info-card">
                        <i class="devicon-linkedin-plain colored" style="font-size: 2rem;"></i>
                        <div>
                            <p class="text-gray-400 text-sm uppercase tracking-widest mb-1">LinkedIn</p>
                            <a href="https://www.linkedin.com/in/george-giapitzakis-025403191/" target="_blank"
                               class="text-indigo-400 text-lg font-semibold hover:underline">
                                linkedin.com/in/george-giapitzakis-025403191
                            </a>
                        </div>
                    </div>
                    <div class="info-card">
                        <i class="devicon-github-original" style="font-size: 2rem; color: white;"></i>
                        <div>
                            <p class="text-gray-400 text-sm uppercase tracking-widest mb-1">GitHub</p>
                            <a href="https://github.com/George-Giap/Portfolio.git" target="_blank"
                               class="text-indigo-400 text-lg font-semibold hover:underline">
                                github.com/George-Giap/Portfolio.git
                            </a>
                        </div>
                    </div>

                    <div class="info-card">
                        <svg style="width: 2rem; height: 2rem; color: #a5b4fc; flex-shrink: 0;" fill="currentColor" viewBox="0 0 24 24">
                            <path d="M20 4H4C2.9 4 2 4.9 2 6V18C2 19.1 2.9 20 4 20H20C21.1 20 22 19.1 22 18V6C22 4.9 21.1 4 20 4ZM20 8L12 13L4 8V6L12 11L20 6V8Z" />
                        </svg>
                        <div>
                            <p class="text-gray-400 text-sm uppercase tracking-widest mb-1">Email</p>
                            <p class="text-white text-lg font-semibold">g.giapitzakis@outlook.com</p>
                        </div>
                    </div>

                </div>
            </div>
    </section>
</template>

<style scoped>
    .gradient-text {
        background: linear-gradient(90deg, #818cf8, #a78bfa, #60a5fa);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        background-clip: text;
    }

    .bio-line {
        width: 80px;
        height: 3px;
        background: linear-gradient(90deg, #4f46e5, #7c3aed);
        border-radius: 2px;
    }

    .info-card {
        display: flex;
        align-items: center;
        gap: 20px;
        background: rgba(255, 255, 255, 0.04);
        border: 1px solid rgba(99, 102, 241, 0.2);
        border-radius: 16px;
        padding: 20px 24px;
        transition: all 0.3s ease;
        backdrop-filter: blur(10px);
    }

        .info-card:hover {
            border-color: #6366f1;
            background: rgba(79, 70, 229, 0.15);
            transform: translateX(6px);
            box-shadow: 0 0 20px rgba(99, 102, 241, 0.3);
        }
    /* ── Robonaut ── */
    .robonaut-wrapper {
        position: absolute;
        left: 200px;
        top: 40%;
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