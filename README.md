# CodeNight – Twitter Login & Mini Twitter Clone

![ASP.NET MVC](https://img.shields.io/badge/ASP.NET-MVC-blue)
![CSharp](https://img.shields.io/badge/C%23-.NET-green)
![Platform](https://img.shields.io/badge/Platform-Web-lightgrey)
![Status](https://img.shields.io/badge/Status-Demo%20Project-orange)
![License](https://img.shields.io/badge/License-Not%20Specified-red)

A demo **ASP.NET MVC** project created for a **CodeNight workshop**, showcasing a **Twitter-like web application** with authentication and core social features such as tweeting, direct messages, notifications, and search.

This repository includes both the **MVC frontend** and a supporting **Web API** project.

---

## 🧠 Overview

The goal of this project is to demonstrate:

- Twitter-style **authentication flow**
- A **home feed (dashboard)** with core social features
- Separation of concerns using **MVC + Web API**
- UI flow and architecture for a social media platform

The project also includes **UI mockups, flow diagrams, and a presentation deck** used during the workshop.

---

## ✨ Features

### 🔐 Authentication
- Twitter-style login flow
- Registration screen
- Session-based authentication

### 🏠 Home Page (Main Dashboard)
After login, users are redirected to the **Home Page**, which includes:

- 📝 **Tweet Posting**
  - Create and share new tweets
- 💬 **Direct Messages (DM Inbox)**
  - View message inbox
  - Access private conversations
- 🔔 **Notifications**
  - View user notifications (likes, interactions, system events)
- 🔍 **Search**
  - Search users or content (UI-level implementation)

### 📐 Architecture & UI
- MVC pattern for frontend
- Separate Web API for authentication and logic
- UI flow and architecture diagrams included

---

## 🧰 Tech Stack

- **ASP.NET MVC**
- **C#**
- **ASP.NET Web API**
- **HTML / CSS / JavaScript**
- **Twitter OAuth (conceptual / demo integration)**

---

## 📂 Repository Structure

```text
CodeNight-TwitterLogin/
├── TwitterWebApi/           # Backend Web API (auth & logic)
├── WebApplication1/         # ASP.NET MVC frontend
├── anasayfa.png             # Home page (dashboard) mockup
├── login.png                # Login screen
├── register.png             # Register screen
├── diagram.png              # Architecture / flow diagram
├── SunuTwitter.pptx         # Workshop presentation
├── 1446864_620x410.jpg      # Visual asset
└── README.md
```
---
## 📸 Screenshots

The repository contains UI mockups demonstrating the application flow:

| File           | Description                                      |
| -------------- | ------------------------------------------------ |
| `login.png`    | Login screen                                     |
| `register.png` | Registration screen                              |
| `anasayfa.png` | Home page with tweet, DM, notifications & search |
| `diagram.png`  | Application flow & architecture                  |
---
## 📈 Application Flow

1. User opens the login page
2. Authentication / registration is completed
3. User is redirected to the Home Page
4. From the Home Page, user can:
    - **Tweeting** – post new tweets
    - **Direct Messages** – open DM inbox
    - **Notifications** – view activity updates
    - **Search** – find users or content

The overall flow is documented visually in `diagram.png`.

---
## 📌 Prerequisites

To run this project locally, you need:

- Visual Studio 2019 or later
- ASP.NET & Web API workloads installed
- .NET Framework compatible with the project
- (Optional) Twitter Developer credentials for real OAuth integration

---

## 🚀 How to Run

**1. Clone the repository**
```bash
git clone https://github.com/SergenEsendemir/CodeNight-TwitterLogin.git
```
**2. Open the solution(s)** in Visual Studio:
- `WebApplication1`
- `TwitterWebApi`

**3. Configure Startup Projects**
- Set both projects to start together (Multiple Startup Projects)

**4. Run**
- Press **F5** or click **Start Debugging**
---
## 🎯 Purpose
This project was created primarily for:
- Educational purposes
- Workshop / presentation demos
- Demonstrating MVC + API architecture
- Explaining social media UI flows

It is **not intended as a full production Twitter clone**, but as a learning and demonstration project.

---

## 🤝 Contributing
Contributions are welcome:
- Improve backend logic
- Enhance UI/UX
- Add real-time features
- Improve authentication flow

---

## 👤 Author

**Sergen Esendemir**

GitHub: https://github.com/SergenEsendemir

---
## 📄 License

No license is currently specified.
You may add one if required (e.g., MIT License).

