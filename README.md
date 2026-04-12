# DevOps Capstone Project

## 📌 Description
This project demonstrates a complete CI/CD pipeline using Jenkins, Docker, and AWS EC2 for deploying a .NET Web API application.

## 🛠 Tech Stack
- .NET Web API
- Jenkins
- Docker
- AWS EC2
- GitHub

## ⚙️ Setup Instructions

### Clone Repo
git clone https://github.com/nithyaravi8198-tech/DevOpsApp.git

### Build App
dotnet build

### Run App
dotnet run

### Docker Build
docker build -t devops-app .

### Run Container
docker run -d -p 5000:80 devops-app

## 🔄 CI/CD Flow
1. Code pushed to GitHub
2. Jenkins triggers build
3. Docker image created
4. Container deployed on EC2
