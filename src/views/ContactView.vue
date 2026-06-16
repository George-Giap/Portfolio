<template>
    <section class="min-h-screen flex items-center justify-center text-white px-8 pt-24 pb-16 relative overflow-hidden">
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
                <span>U can also </span><br />
                <strong> contact me via Email </strong> ✦
                <div class="cloud-tail"></div>
            </div>
        </div>

        <div class="max-w-2xl mx-auto z-10 w-full">

            <h1 class="text-5xl font-bold mb-4 gradient-text">Contact Me</h1>
            <div class="contact-line mb-4"></div>
            <p class="text-gray-400 text-lg mb-12">
                Have a question or want to work together? Send me a message! 🚀
            </p>

            <form @submit.prevent="submitForm" class="flex flex-col gap-6">

                <div class="input-wrapper">
                    <label class="input-label">Your Full Name <span class="required">*</span></label><input
                v-model="form.name"
                type="text"
                placeholder="John Doe"
                class="input-field"
                required />
                </div>

                <div class="input-wrapper">
                    <label class="input-label">Your Email <span class="required">*</span></label>
                    <input v-model="form.email"
                           type="email"
                           placeholder="john@example.com"
                           class="input-field"
                           required />
                </div>

                <div class="input-wrapper">
                    <label class="input-label">Subject</label>
                    <input v-model="form.subject"
                           type="text"
                           placeholder="(optional)"
                           class="input-field" />
                </div>

                <div class="input-wrapper">
                    <label class="input-label">Message <span class="required">*</span></label>
                    <textarea v-model="form.message"
                              rows="6"
                              placeholder="Your message here..."
                              class="input-field resize-none"
                              required />
                </div>

                <button type="submit" class="submit-btn">
                    Send Message 
                </button>


                <p class="text-gray-400 text-sm mt-2 text-center">
                    Or you can reach me through my LinkedIn link below!
                </p>


                <p v-if="sent" class="text-green-400 text-center text-lg">
                    ✅ Message sent successfully!
                </p>
                <p v-if="error" class="text-red-400 text-center text-lg">
                    ❌ Something went wrong. Try again!
                </p>

            </form>

            <!-- Social Links -->
            <div class="flex justify-center gap-8 mt-16">
                <a href="https://github.com/YOUR-USERNAME" target="_blank" class="social-link">
                    <i class="devicon-github-original" style="font-size: 2rem; color: white;"></i>
                </a>
                <a href="https://www.linkedin.com/in/YOUR-LINKEDIN" target="_blank" class="social-link">
                    <i class="devicon-linkedin-plain colored" style="font-size: 2rem;"></i>
                </a>
                <a href="mailto:your.email@gmail.com" class="social-link">
                    <svg style="width: 2rem; height: 2rem; color: #a5b4fc;" fill="currentColor" viewBox="0 0 24 24">
                        <path d="M20 4H4C2.9 4 2 4.9 2 6V18C2 19.1 2.9 20 4 20H20C21.1 20 22 19.1 22 18V6C22 4.9 21.1 4 20 4ZM20 8L12 13L4 8V6L12 11L20 6V8Z" />
                    </svg>
                </a>
            </div>

        </div>
    </section>
</template>

<script setup>
    import { ref } from 'vue'
    import axios from 'axios'

    const form = ref({
        name: '',
        email: '',
        subject: '',
        message: ''
    })

    const sent = ref(false)
    const error = ref(false)

    async function submitForm() {
        try {
            await axios.post('http://localhost:5092/api/contact', form.value)
            sent.value = true
            error.value = false
            form.value = { name: '', email: '', subject: '', message: '' }
        } catch (e) {
            console.error('Full error:', e.response?.data || e.message)
            error.value = true
        }
    }
</script>

<style scoped>
    .gradient-text {
        background: linear-gradient(90deg, #818cf8, #a78bfa, #60a5fa);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        background-clip: text;
    }

    .contact-line {
        width: 80px;
        height: 3px;
        background: linear-gradient(90deg, #4f46e5, #7c3aed);
        border-radius: 2px;
    }

    .input-wrapper {
        display: flex;
        flex-direction: column;
        gap: 8px;
    }

    .input-label {
        font-size: 0.9rem;
        font-family: 'IBM Plex Serif', serif;
        color: #a5b4fc;
        letter-spacing: 0.05em;
    }

    .input-field {
        background: rgba(255, 255, 255, 0.05);
        border: 1px solid rgba(99, 102, 241, 0.3);
        border-radius: 12px;
        padding: 14px 18px;
        color: white;
        font-size: 1rem;
        outline: none;
        transition: all 0.3s ease;
        backdrop-filter: blur(10px);
        width: 100%;
    }

        .input-field::placeholder {
            color: rgba(255, 255, 255, 0.2);
        }

        .input-field:focus {
            border-color: #6366f1;
            box-shadow: 0 0 20px rgba(99, 102, 241, 0.3);
            background: rgba(79, 70, 229, 0.1);
        }

    .submit-btn {
        padding: 16px;
        background: linear-gradient(135deg, #4f46e5, #7c3aed);
        border: none;
        border-radius: 12px;
        color: white;
        font-size: 1.1rem;
        font-family: 'IBM Plex Serif', serif;
        font-weight: 600;
        letter-spacing: 0.05em;
        cursor: pointer;
        transition: all 0.3s ease;
        box-shadow: 0 0 20px rgba(79, 70, 229, 0.4);
    }

        .submit-btn:hover {
            transform: translateY(-3px);
            box-shadow: 0 0 35px rgba(79, 70, 229, 0.7);
        }

    .social-link {
        transition: all 0.3s ease;
        opacity: 0.7;
    }

        .social-link:hover {
            transform: translateY(-4px);
            opacity: 1;
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