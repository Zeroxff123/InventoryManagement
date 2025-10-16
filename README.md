ZeroBillX

ZeroBillX is an advanced invoice management system built with Angular 16, ASP.NET Core Web API 6.0, and SQL Server. This system provides full-fledged invoicing capabilities, including unlimited invoice creation, customer management, PDF generation, and more. The frontend is built with Angular and utilizes NG-Zorro UI components for a modern, responsive design.

Note: This is a proprietary version of ZeroBillX owned by ZeroxFF. Unauthorized copying, redistribution, or modification is strictly prohibited.

Features

Create Unlimited Invoices: Generate invoices without any restrictions.

Email Invoice: Send invoices directly to customers via email.

PDF Generation: Export invoices as PDFs for easy sharing and storage.

Customer Management: Add, edit, and manage customers with multiple shipping addresses.

Authentication & Roles: Secure login and role-based access control.

Customer Product Management: Add products linked to customers for quick access.

Sign Up & Profile Management: Users can sign up and manage their profile.

Image Upload: Upload and manage profile pictures and invoice logos.

VAT Management: Handle VAT for customer invoices.

Database: Built to work with SQL Server.

Technologies Used

Frontend: Angular with NG-Zorro (Responsive UI components)

Backend: ASP.NET Core Web API 6.0 (Robust and scalable API layer)

Database: SQL Server (Code First Migration)

Installation (Without Docker)
Prerequisites

Node.js (For Angular)

SQL Server (For database)

.NET 6.0 SDK (For ASP.NET Core)

Installation Steps

Clone the repository:

git clone <your-private-repo-url>
cd ZeroBillX


Frontend (Angular):

cd frontend
npm install
ng serve


Backend (ASP.NET Core):

cd backend
dotnet restore


Database Setup (SQL Server):

Ensure SQL Server is installed and running.

Update the connection strings in appsettings.json to configure your SQL Server database.

Example:

"ConnectionStrings": {
  "SqlServerConnection": "Your SQL Server connection string"
}


Apply Migrations:

dotnet ef database update

Running the Application

Run the Angular frontend:

ng serve


Run the ASP.NET Core backend:

dotnet run


Open your browser and navigate to http://localhost:4200 for the frontend.

Admin login: username: admin1, password: admin1

Employee login: username: employee1, password: employee1

Backend Swagger API: http://localhost:5000/swagger/index.html

SMTP Configuration (Outlook):

If two-factor authentication (2FA) is enabled, generate an app password. Update your appsettings.json:

{
  "Email": {
    "SmtpServer": "smtp.office365.com",
    "SmtpPort": 587,
    "SenderEmail": "your-email@outlook-or-hotmail.com",
    "SenderName": "ZeroBillX Team",
    "SenderPassword": "your-app-password"
  }
}

Installation (With Docker)

Make sure Docker Desktop is installed.

Run:

docker-compose up


If the seeder fails, stop the backend container from Docker Desktop and run it again from ZeroBillX.

Access the frontend at http://localhost:4444.

Admin login: username: admin1, password: admin1

Employee login: username: employee1, password: employee1

Backend Swagger API: http://localhost:5000/swagger/index.html

Contributing

This is a proprietary system. Unauthorized contributions or public forks are prohibited. Please contact ZeroxFF for collaboration or licensing inquiries.

License

This project is proprietary and confidential. Unauthorized use, copying, distribution, or modification is strictly prohibited.
All rights reserved © 2025 ZeroxFF.

For full license details, see the LICENSE file.
