"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var home_component_1 = require("./home/home.component");
var welcome_component_1 = require("./welcome/welcome.component");
var register_component_1 = require("./register/register.component");
exports.routes = [
    { path: 'home', component: home_component_1.HomeComponent },
    { path: 'register', component: register_component_1.RegisterComponent },
    { path: 'welcome', component: welcome_component_1.WelcomeComponent }
];
//# sourceMappingURL=app-routing.module.js.map