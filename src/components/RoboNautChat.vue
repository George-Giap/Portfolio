<template>
    <div class="chat-wrapper">

        <!-- Toggle Button -->
        <div class="chat-toggle" @click="openChat">
            <svg viewBox="0 0 64 64" class="chat-robo" xmlns="http://www.w3.org/2000/svg">

                <!-- Headphone Band -->
                <path d="M14 26 Q14 10 32 10 Q50 10 50 26" fill="none" stroke="#000000" stroke-width="5" stroke-linecap="round" />

                <!-- Left Headphone Cup -->
                <rect x="8" y="24" width="10" height="14" rx="5" fill="#000000" stroke="#000000" stroke-width="2" />
                <circle cx="13" cy="31" r="3.5" fill="#000000" />
                <circle cx="13" cy="31" r="1.5" fill="#111111" />

                <!-- Right Headphone Cup -->
                <rect x="46" y="24" width="10" height="14" rx="5" fill="#000000" stroke="#000000" stroke-width="2" />
                <circle cx="51" cy="31" r="3.5" fill="#000000" />
                <circle cx="51" cy="31" r="1.5" fill="#111111" />

                <!-- Mic Arm — curves to mouth level -->
                <path d="M13 36 Q16 42 24 42" fill="none" stroke="#000000" stroke-width="9.5" stroke-linecap="round" />

                <!-- Mic Head — right in front of mouth -->
                <circle cx="24" cy="42" r="4" fill="#0a0a1a" stroke="#818cf8" stroke-width="0" />
                <circle cx="24" cy="42" r="2" fill="#818cf8" />

                <!-- Head -->
                <rect x="14" y="18" width="36" height="26" rx="8" fill="#1e1b4b" stroke="#818cf8" stroke-width="2" />

                <!-- Left Eye -->
                <circle cx="24" cy="28" r="5" fill="#0d0d2b" stroke="#6366f1" stroke-width="1.5" />
                <circle cx="24" cy="28" r="3" fill="#4f46e5" />
                <circle cx="24" cy="28" r="1.5" fill="#a78bfa" />
                <circle cx="25" cy="27" r="0.8" fill="white" opacity="0.9" />

                <!-- Right Eye -->
                <circle cx="40" cy="28" r="5" fill="#0d0d2b" stroke="#6366f1" stroke-width="1.5" />
                <circle cx="40" cy="28" r="3" fill="#4f46e5" />
                <circle cx="40" cy="28" r="1.5" fill="#a78bfa" />
                <circle cx="41" cy="27" r="0.8" fill="white" opacity="0.9" />

                <!-- Smile -->
                <path d="M22 37 Q32 45 42 37" fill="none" stroke="#818cf8" stroke-width="2" stroke-linecap="round" />

                <!-- Cheeks -->
                <ellipse cx="17" cy="34" rx="3" ry="2" fill="#7c3aed" opacity="0.35" />
                <ellipse cx="47" cy="34" rx="3" ry="2" fill="#7c3aed" opacity="0.35" />

                <!-- Neck -->
                <rect x="28" y="44" width="8" height="4" rx="2" fill="#1e1b4b" stroke="#6366f1" stroke-width="1" />

                <!-- Body -->
                <rect x="14" y="48" width="36" height="13" rx="6" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5" />

                <!-- Body panel -->
                <rect x="19" y="51" width="26" height="7" rx="3" fill="#0d0d2b" stroke="#4f46e5" stroke-width="1" />

                <!-- Status lights -->
                <circle cx="25" cy="54" r="2" fill="#818cf8" />
                <circle cx="32" cy="54" r="2" fill="#6366f1" />
                <circle cx="39" cy="54" r="2" fill="#a78bfa" />

                <!-- Arms -->
                <rect x="5" y="49" width="8" height="10" rx="4" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5" />
                <rect x="51" y="49" width="8" height="10" rx="4" fill="#1e1b4b" stroke="#818cf8" stroke-width="1.5" />

            </svg>
            <p class="chat-label">ChatBot</p>
            <div class="chat-badge" v-if="!isOpen">💬</div>
        </div>

        <!-- Chat Window -->
        <div class="chat-window" :class="{ 'chat-open': isOpen }">

            <!-- Header -->
            <div class="chat-header">
                <div class="flex items-center gap-3">
                    <div class="header-dot"></div>
                    <span class="header-title">RoboNaut 🧑‍🚀</span>
                </div>
                <div class="header-btns">
                    <!-- Minimize -->
                    <button @click="minimizeChat" class="header-btn" title="Minimize">─</button>
                    <!-- Close -->
                    <button @click="askClose" class="header-btn close-btn-x" title="End Chat">✕</button>
                </div>
            </div>

            <!-- Messages -->
            <div class="chat-messages" ref="messagesRef">
                <div v-for="(msg, i) in messages"
                     :key="i"
                     class="message"
                     :class="msg.from === 'bot' ? 'bot-message' : 'user-message'">
                    <span v-html="msg.text"></span>
                </div>
            </div>

            <!-- Quick Suggestions -->
            <div class="suggestions">
                <button v-for="s in suggestions"
                        :key="s"
                        class="suggestion-btn"
                        @click="sendMessage(s)">
                    {{ s }}
                </button>
            </div>

            <!-- Input -->
            <div class="chat-input-wrapper">
                <input v-model="userInput"
                       @keyup.enter="sendMessage(userInput)"
                       type="text"
                       placeholder="Ask me anything..."
                       class="chat-input" />
                <button @click="sendMessage(userInput)" class="send-btn">
                    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" fill="currentColor" style="width:20px;height:20px;">
                        <path d="M2.01 21L23 12 2.01 3 2 10l15 2-15 2z" />
                    </svg>
                </button>
            </div>

        </div>

        <!-- ── Confirm Close Dialog ── -->
        <div class="confirm-overlay" v-if="showConfirm">
            <div class="confirm-box">
                <div class="confirm-icon">🧑‍🚀</div>
                <p class="confirm-title">End Conversation?</p>
                <p class="confirm-text">
                    Are you sure you want to end the chat?<br />
                    All messages will be lost and a fresh conversation will start next time.
                </p>
                <div class="confirm-btns">
                    <button @click="confirmClose" class="confirm-yes">Yes, End It</button>
                    <button @click="cancelClose" class="confirm-no">No, Continue</button>
                </div>
            </div>
        </div>

    </div>
</template>

<script setup>
    import { ref, nextTick } from 'vue'
    const isOpen = ref(false)
    const userInput = ref('')
    const messagesRef = ref(null)
    const showConfirm = ref(false)

    const suggestions = [
        '👤 About Me',
        '🛠️ Skills',
        '💼 Projects',
        '📬 Contact',
        '📖 Bio',
    ]

    const defaultMessage = {
        from: 'bot',
        text: `Hey there! 👋 I'm <strong>RoboNaut</strong> — Georgios's assistant!<br/>
         Ask me anything about this portfolio or use the quick buttons below 🚀`
    }

    const messages = ref([{ ...defaultMessage }])

    function openChat() { isOpen.value = true }
    function minimizeChat() { isOpen.value = false }
    function askClose() { showConfirm.value = true }
    function cancelClose() { showConfirm.value = false }

    function confirmClose() {
        showConfirm.value = false
        isOpen.value = false
        messages.value = [{ ...defaultMessage }]
        userInput.value = ''
    }

    function scrollToBottom() {
        nextTick(() => {
            if (messagesRef.value)
                messagesRef.value.scrollTop = messagesRef.value.scrollHeight
        })
    }

    function getBotReply(input) {
        const msg = input.toLowerCase().trim()

        if (msg.match(/hello|hi|hey|good|morning|evening/))
            return `Hey there! 👋 Great to meet you! I'm RoboNaut, Georgios's digital assistant.<br/>How can I help you today? 🚀`

        if (msg.match(/about|who|georgios|developer|person/))
            return `Georgios is a <strong>Junior Fullstack Developer</strong> based in Athens, Greece 🇬🇷<br/>
            He works with Vue.js, ASP.NET Core, C#, Blazor and SQL Server.<br/>
            <a href="/about" class="chat-link">→ See About Me</a>`

        if (msg.match(/bio|career|story|journey|sport|peoplecert|bootcamp/))
            return `Georgios started in <strong>Sports Management</strong>, then pivoted to tech through a bootcamp!<br/>
            Now he's a Fullstack PMO Developer at <strong>PeopleCert</strong> 🚀<br/>
            <a href="/bio" class="chat-link">→ Read Full Bio</a>`

        if (msg.match(/skill|tech|vue|csharp|c#|blazor|sql|react|javascript|technology/))
            return `Georgios works with:<br/>
            💚 <strong>Vue.js</strong> · 💜 <strong>C# / .NET</strong> · 🔥 <strong>Blazor</strong><br/>
            💛 <strong>JavaScript</strong> · 🗄️ <strong>SQL Server</strong> · ⚛️ <strong>React</strong><br/>
            <a href="/skills" class="chat-link">→ See All Skills</a>`

        if (msg.match(/project|work|portfolio|build|built|made|app/))
            return `Check out Georgios's personal projects — built with real passion! 💼<br/>
            <a href="/projects" class="chat-link">→ View Projects</a>`

        if (msg.match(/contact|email|reach|hire|work together|message|send/))
            return `Want to work with Georgios or have a question? 📬<br/>
            <a href="/contact" class="chat-link">→ Send a Message</a> or<br/>
            <a href="/contact-info" class="chat-link">→ View Personal Info</a>`

        if (msg.match(/where|location|city|country|greece|athens/))
            return `Georgios is based in <strong>Athens, Greece</strong> 🇬🇷<br/>
            Available for remote work worldwide! 🌍`

        if (msg.match(/experience|years|junior|senior/))
            return `Georgios has <strong>1+ year</strong> of professional experience as a Fullstack PMO Developer.<br/>
            He's constantly learning and growing every day! 📈`

        if (msg.match(/hire|freelance|available|price|cost|pay|money|budget/))
            return `Georgios is open to exciting opportunities! 💼<br/>
            The best way to reach him is through the contact form.<br/>
            <a href="/contact" class="chat-link">→ Let's Talk!</a>`

        if (msg.match(/github|code|repository|repo/))
            return `You can find Georgios's code on GitHub 🐙<br/>
            <a href="/contact-info" class="chat-link">→ Find the GitHub link here</a>`

        if (msg.match(/thank|thanks|great|awesome|cool|nice/))
            return `You're welcome! 😊 That's what I'm here for!<br/>
            Anything else I can help you with? 🚀`

        if (msg.match(/bye|goodbye|see you|cya|later/))
            return `Goodbye! 👋 Come back anytime — I'll be here floating around! 🧑‍🚀✨`

        return `Hmm... I'm just a RoboNaut, not a genius AI! 🤖<br/>
          I can only answer questions about this portfolio.<br/>
          Try asking about: <strong>skills, projects, bio, contact</strong> or <strong>experience</strong>! 🚀`
    }

    function sendMessage(text) {
        if (!text || !text.trim()) return
        const cleanText = text.replace(/^[^\w]+ /, '').trim()
        messages.value.push({ from: 'user', text: cleanText })
        userInput.value = ''
        scrollToBottom()
        setTimeout(() => {
            messages.value.push({ from: 'bot', text: getBotReply(cleanText) })
            scrollToBottom()
        }, 500)
    }
</script>

<style scoped>
    .chat-wrapper {
        position: fixed;
        bottom: 80px;
        right: 60px;
        z-index: 1000;
    }

    .chat-toggle {
        width: 180px;
        height: 180px;
        cursor: pointer;
        position: relative;
        filter: drop-shadow(0 0 12px rgba(129, 140, 248, 0.8));
        transition: transform 0.3s ease;
        display: flex;
        flex-direction: column;
        align-items: center;
    }

        .chat-toggle:hover {
            transform: scale(1.1);
        }

    .chat-robo {
        width: 180px;
        height: 180px;
    }

    .chat-label {
        font-size: 1.1rem;
        font-family: 'IBM Plex Serif', serif;
        font-style: italic;
        color: #e0e7ff;
        letter-spacing: 0.08em;
        margin-top: 8px;
        text-align: center;
        font-weight: 700;
        text-shadow: 0 0 16px rgba(129, 140, 248, 1);
    }

    .chat-badge {
        position: absolute;
        top: -5px;
        right: -5px;
        font-size: 1.1rem;
        animation: bounceBadge 1.5s ease-in-out infinite;
    }

    @keyframes floatRobo {
        0%, 100% {
            transform: translateY(0px);
        }

        50% {
            transform: translateY(-8px);
        }
    }

    @keyframes bounceBadge {
        0%, 100% {
            transform: scale(1);
        }

        50% {
            transform: scale(1.2);
        }
    }

    /* Chat Window */
    .chat-window {
        position: absolute;
        bottom: 170px;
        right: 0;
        width: 700px;
        background: rgba(10, 8, 30, 0.98);
        border: 1px solid rgba(99, 102, 241, 0.4);
        border-radius: 35px;
        overflow: hidden;
        backdrop-filter: blur(20px);
        box-shadow: 0 0 40px rgba(79, 70, 229, 0.3);
        opacity: 0;
        transform: translateY(20px) scale(0.95);
        pointer-events: none;
        transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
    }

    .chat-open {
        opacity: 1;
        transform: translateY(0) scale(1);
        pointer-events: all;
    }

    /* Header */
    .chat-header {
        display: flex;
        justify-content: space-between;
        align-items: center;
        padding: 16px 20px;
        background: rgba(79, 70, 229, 0.2);
        border-bottom: 1px solid rgba(99, 102, 241, 0.2);
    }

    .header-dot {
        width: 10px;
        height: 10px;
        background: #818cf8;
        border-radius: 50%;
        box-shadow: 0 0 8px #818cf8;
        animation: pulse 2s ease-in-out infinite;
    }

    @keyframes pulse {
        0%, 100% {
            opacity: 1;
        }

        50% {
            opacity: 0.4;
        }
    }

    .header-title {
        font-family: 'IBM Plex Serif', serif;
        font-size: 1.5rem;
        font-weight: 600;
        color: #a5b4fc;
    }

    /* Header buttons */
    .header-btns {
        display: flex;
        gap: 8px;
        align-items: center;
    }

    .header-btn {
        background: rgba(99, 102, 241, 0.15);
        border: 1px solid rgba(99, 102, 241, 0.3);
        border-radius: 8px;
        color: #a5b4fc;
        font-size: 1.5rem;
        width: 32px;
        height: 32px;
        display: flex;
        align-items: center;
        justify-content: center;
        cursor: pointer;
        transition: all 0.2s ease;
    }

        .header-btn:hover {
            background: rgba(99, 102, 241, 0.35);
            color: white;
        }

    .close-btn-x:hover {
        background: rgba(239, 68, 68, 0.3);
        border-color: rgba(239, 68, 68, 0.5);
        color: #fca5a5;
    }

    /* Messages */
    .chat-messages {
        height: 550px;
        overflow-y: auto;
        padding: 16px;
        display: flex;
        flex-direction: column;
        gap: 12px;
        scrollbar-width: thin;
        scrollbar-color: #4f46e5 transparent;
    }

    .message {
        max-width: 100%;
        padding: 12px 16px;
        border-radius: 14px;
        font-size: 1.1rem;
        line-height: 1.9;
        font-family: 'IBM Plex Serif', serif;
    }

    .bot-message {
        background: rgba(79, 70, 229, 0.2);
        border: 1px solid rgba(99, 102, 241, 0.3);
        color: #c7d2fe;
        align-self: flex-start;
        border-bottom-left-radius: 4px;
    }

    .user-message {
        background: rgba(99, 102, 241, 0.3);
        border: 1px solid rgba(129, 140, 248, 0.4);
        color: white;
        align-self: flex-end;
        border-bottom-right-radius: 6px;
    }

    /* Suggestions */
    .suggestions {
        display: flex;
        flex-wrap: wrap;
        gap: 8px;
        padding: 12px 16px;
        border-top: 1px solid rgba(99, 102, 241, 0.1);
    }

    .suggestion-btn {
        background: rgba(79, 70, 229, 0.15);
        border: 1px solid rgba(99, 102, 241, 0.3);
        border-radius: 20px;
        padding: 8px 18px;
        color: #a5b4fc;
        font-size: 1.1rem;
        cursor: pointer;
        transition: all 0.2s ease;
        font-family: 'IBM Plex Serif', serif;
    }

        .suggestion-btn:hover {
            background: rgba(99, 102, 241, 0.3);
            color: white;
        }

    /* Input */
    .chat-input-wrapper {
        display: flex;
        gap: 8px;
        padding: 12px 16px;
        border-top: 1px solid rgba(99, 102, 241, 0.2);
    }

    .chat-input {
        flex: 1;
        background: rgba(255, 255, 255, 0.05);
        border: 1px solid rgba(99, 102, 241, 0.3);
        border-radius: 10px;
        padding: 12px 16px;
        color: white;
        font-size: 0.95rem;
        outline: none;
        font-family: 'IBM Plex Serif', serif;
        transition: border 0.2s;
    }

        .chat-input:focus {
            border-color: #6366f1;
        }

        .chat-input::placeholder {
            color: rgba(255,255,255,0.2);
        }

    .send-btn {
        background: linear-gradient(135deg, #4f46e5, #7c3aed);
        border: none;
        border-radius: 10px;
        padding: 12px 16px;
        color: white;
        cursor: pointer;
        transition: all 0.2s ease;
        display: flex;
        align-items: center;
        justify-content: center;
    }

        .send-btn:hover {
            transform: scale(1.05);
            box-shadow: 0 0 15px rgba(79, 70, 229, 0.5);
        }

    /* ── Confirm Dialog ── */
    .confirm-overlay {
        position: absolute;
        bottom: 180px;
        right: 0;
        width: 600px;
        z-index: 200;
        display: flex;
        align-items: center;
        justify-content: center;
    }

    .confirm-box {
        background: rgba(10, 8, 30, 0.99);
        border: 1px solid rgba(99, 102, 241, 0.5);
        border-radius: 20px;
        padding: 96px 70px;
        text-align: center;
        backdrop-filter: blur(20px);
        box-shadow: 0 0 40px rgba(79, 70, 229, 0.4);
        width: 100%;
    }

    .confirm-icon {
        font-size: 3rem;
        margin-bottom: 12px;
    }

    .confirm-title {
        font-family: 'IBM Plex Serif', serif;
        font-size: 1.4rem;
        font-weight: 700;
        color: #a5b4fc;
        margin-bottom: 12px;
    }

    .confirm-text {
        font-family: 'IBM Plex Serif', serif;
        font-size: 1rem;
        color: #94a3b8;
        line-height: 1.7;
        margin-bottom: 28px;
    }

    .confirm-btns {
        display: flex;
        gap: 16px;
        justify-content: center;
    }

    .confirm-yes {
        padding: 12px 32px;
        background: rgba(239, 68, 68, 0.2);
        border: 1px solid rgba(239, 68, 68, 0.5);
        border-radius: 12px;
        color: #fca5a5;
        font-size: 1rem;
        font-family: 'IBM Plex Serif', serif;
        font-weight: 600;
        cursor: pointer;
        transition: all 0.2s ease;
    }

        .confirm-yes:hover {
            background: rgba(239, 68, 68, 0.4);
            transform: translateY(-2px);
        }

    .confirm-no {
        padding: 12px 32px;
        background: rgba(79, 70, 229, 0.2);
        border: 1px solid rgba(99, 102, 241, 0.5);
        border-radius: 12px;
        color: #a5b4fc;
        font-size: 1rem;
        font-family: 'IBM Plex Serif', serif;
        font-weight: 600;
        cursor: pointer;
        transition: all 0.2s ease;
    }

        .confirm-no:hover {
            background: rgba(79, 70, 229, 0.4);
            color: white;
            transform: translateY(-2px);
        }
</style>