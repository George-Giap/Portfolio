<template>
    <section class="min-h-screen flex items-center justify-center text-white px-8 pt-24 pb-16 relative overflow-hidden"
             style="background-color: transparent;">

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
                <span>Here are a few</span><br />
                <strong>things about me</strong> ✦
                <div class="cloud-tail"></div>
            </div>
        </div>

        <!-- Main Content -->
        <div class="max-w-4xl mx-auto z-10 w-full">

            <!-- Title -->
            <h1 class="text-5xl font-bold mb-4 gradient-text">Personal Bio</h1>
            <div class="bio-line mb-12"></div>

            <!-- Timeline -->
            <div class="timeline">

                <!-- Step 1 -->
                <div class="timeline-item">
                    <div class="timeline-icon">🏆</div>
                    <div class="timeline-content">
                        <h3 class="timeline-title">The Beginning — Sports Management</h3>
                        <p class="timeline-text">
                            My journey didn't start with code. I began my professional career in
                            <span class="highlight">Sports Management</span>, where I developed
                            a strong foundation in organization, teamwork, performance tracking,
                            and working under pressure. Skills that — as it turns out —
                            translate perfectly into the world of software development.
                        </p>
                    </div>
                </div>

                <!-- Step 2 -->
                <div class="timeline-item">
                    <div class="timeline-icon">💻</div>
                    <div class="timeline-content">
                        <h3 class="timeline-title">The Pivot — Bootcamp & The Code Life</h3>
                        <p class="timeline-text">
                            Driven by curiosity and ambition, I made a bold decision to pivot
                            into technology. I enrolled in an intensive bootcamp where I
                            mastered <span class="highlight">C#</span> and
                            <span class="highlight">JavaScript</span> — diving deep into
                            backend logic, frontend interactivity, and the architecture of
                            modern applications. Late nights, debugging sessions, and countless
                            commits later — a developer was born.
                        </p>
                    </div>
                </div>

                <!-- Step 3 -->
                <div class="timeline-item">
                    <div class="timeline-icon">🚀</div>
                    <div class="timeline-content">
                        <h3 class="timeline-title">Today — Fullstack PMO Developer @ PeopleCert</h3>
                        <p class="timeline-text">
                            Currently working as a <span class="highlight">Fullstack PMO Developer</span>
                            at <span class="highlight">PeopleCert</span>, one of the world's
                            leading certification bodies. I work across the full stack —
                            building and maintaining robust applications using
                            <span class="highlight">Vue.js</span>,
                            <span class="highlight">Blazor WebAssembly</span>,
                            <span class="highlight">JavaScript</span>,
                            <span class="highlight">ASP.NET Core</span>,
                            <span class="highlight">C#</span> and
                            <span class="highlight">SQL Server</span>.
                            Every day I bridge the gap between project management operations
                            and modern software engineering.
                        </p>
                    </div>
                </div>

                <!-- Step 4 -->
                <div class="timeline-item">
                    <div class="timeline-icon">✦</div>
                    <div class="timeline-content">
                        <h3 class="timeline-title">The Mission — Always Growing</h3>
                        <p class="timeline-text">
                            From the sports field to the IDE — my story is proof that
                            <span class="highlight">passion and persistence</span> can
                            redefine your path. I'm constantly expanding my skills,
                            exploring new frameworks, and pushing myself to write
                            cleaner, smarter, more impactful code.
                            The journey has just begun. 🚀
                        </p>
                    </div>
                </div>

            </div>

            <!-- Quote -->
            <div class="quote-card">
                <p class="quote-text">
                    "The secret of getting ahead is getting started."
                </p>
                <p class="quote-author">— Mark Twain</p>
            </div>

        </div>
    </section>
</template>

<style scoped>
    section {
        position: relative;
    }

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

    @keyframes floatRobo {
        0%, 100% {
            transform: translateY(-50%);
        }

        50% {
            transform: translateY(calc(-50% - 10px));
        }
    }

    /* ── Timeline ── */
    .timeline {
        display: flex;
        flex-direction: column;
        gap: 0;
        position: relative;
        margin-bottom: 60px;
    }

        .timeline::before {
            content: '';
            position: absolute;
            left: 27px;
            top: 0;
            bottom: 0;
            width: 2px;
            background: linear-gradient(to bottom, #4f46e5, #7c3aed, #2563eb);
            opacity: 0.4;
        }

    .timeline-item {
        display: flex;
        gap: 24px;
        align-items: flex-start;
        padding-bottom: 48px;
        position: relative;
    }

    .timeline-icon {
        width: 56px;
        height: 56px;
        min-width: 56px;
        background: rgba(79, 70, 229, 0.2);
        border: 2px solid rgba(99, 102, 241, 0.5);
        border-radius: 50%;
        display: flex;
        align-items: center;
        justify-content: center;
        font-size: 1.4rem;
        z-index: 1;
        box-shadow: 0 0 20px rgba(79, 70, 229, 0.3);
    }

    .timeline-content {
        background: rgba(255, 255, 255, 0.04);
        border: 1px solid rgba(99, 102, 241, 0.2);
        border-radius: 16px;
        padding: 24px 28px;
        flex: 1;
        backdrop-filter: blur(10px);
        transition: all 0.3s ease;
    }

        .timeline-content:hover {
            border-color: #6366f1;
            background: rgba(79, 70, 229, 0.1);
            transform: translateX(6px);
            box-shadow: 0 0 25px rgba(99, 102, 241, 0.2);
        }

    .timeline-title {
        font-size: 1.3rem;
        font-weight: 700;
        font-family: 'IBM Plex Serif', serif;
        color: #a5b4fc;
        margin-bottom: 12px;
    }

    .timeline-text {
        color: #94a3b8;
        font-size: 1rem;
        line-height: 1.8;
    }

    .highlight {
        color: #a5b4fc;
        font-weight: 600;
    }

    /* ── Quote ── */
    .quote-card {
        background: rgba(79, 70, 229, 0.1);
        border: 1px solid rgba(99, 102, 241, 0.3);
        border-left: 4px solid #6366f1;
        border-radius: 16px;
        padding: 32px 40px;
        text-align: center;
        box-shadow: 0 0 30px rgba(79, 70, 229, 0.15);
    }

    .quote-text {
        font-family: 'IBM Plex Serif', serif;
        font-style: italic;
        font-size: 1.2rem;
        color: #c7d2fe;
        line-height: 1.8;
        margin-bottom: 12px;
    }

    .quote-author {
        color: #6366f1;
        font-size: 0.9rem;
        font-weight: 600;
        letter-spacing: 0.1em;
    }
</style>