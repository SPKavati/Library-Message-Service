# Library-Message-Service
Library Message service project is about using mobile technology like sms feature for performing reservation and availability checking books in library and remind about due date. This application reduces the time for end users who should spend for searching the books of their needs as well as it reduces the time for providing details without any external human involvement. For this, they need registered mobile number. The library server system will have a BULK SMS receiver which receives the sms sent by the registered users. Whenever user request it, the library server will check database, if details of requested book is existed in the database then it automatically fetch information and send sms to user. There will be no cost for sms, this application uses free services.

Aim of the project:
Library Message Service project is developed in .NET as WinFroms using C# as the frontend and MS Sql Server as the back end. The server system will have a BULK SMS gateway which receives the sms sent by the registered users. The software component reads these messages and fetches the relevant data from the database and creates an sms messages to be sent using the BULK SMS back to the user. The system keeps track of the mobile numbers of the registered users. A registered user should be a member of the library and the relevant information is entered into the database using the system’s frontend form.

This reduces the time that a student has to spend for searching the books of their need as well as it reduces the time for providing the details. This software does not need any external human involvement for accepting the SMS and sending the details. Here we use free SMS services provided by the internet such as netway, way2sms etc.

