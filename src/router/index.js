import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import SkillsView from '../views/SkillsView.vue'
import ProjectsView from '../views/ProjectsView.vue'
import ContactView from '../views/ContactView.vue'
import AboutView from '../views/AboutView.vue'
import AchievementsView from '../views/AchievementsView.vue'
import BioView from '../views/BioView.vue'
import PersonalInfoView from '../views/PersonalInfoView.vue'

const routes = [
    { path: '/', component: HomeView },
    { path: '/skills', component: SkillsView },
    { path: '/projects', component: ProjectsView },
    { path: '/contact', component: ContactView },
    { path: '/about', component: AboutView },
    { path: '/achievements', component: AchievementsView },
    { path: '/bio', component: BioView },
    { path: '/contact-info', component: PersonalInfoView },
]

export default createRouter({
    history: createWebHistory(),
    routes,
    scrollBehavior() {
        return { top: 0 }   
    }
})