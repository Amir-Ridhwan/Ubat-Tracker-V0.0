# UBAT TRACKER V0.0

This is my project for subject UFH 2009 Application Programming. It keep track the medicine for pharmacy and patient. This is mockup system designed for University Malaya Medical Center. All right reserved. 

I would like to thank Professor Ang Tan Fong from University of Malaya for his guidance in this project.

## Data Migration for Password Hashing

After applying the security updates, you must run a one-time data migration script to hash all existing plaintext passwords in the database. Failure to do so will result in all existing users being locked out of their accounts.

### How to Run the Migration Script

1.  **Open the project in Visual Studio.**
2.  **Temporarily change the project's output type to "Console Application".**
    *   Right-click on the `Ubat Tracker V0.0` project in the Solution Explorer and select "Properties".
    *   In the "Application" tab, change the "Output type" from "Windows Application" to "Console Application".
    *   Change the "Startup object" to `MigratePasswords`.
3.  **Run the application.** This will compile and run the `migrate_passwords.vb` script, which will connect to the database and hash all existing plaintext passwords.
4.  **Change the project's output type back to "Windows Application".**
    *   Right-click on the `Ubat Tracker V0.0` project in the Solution Explorer and select "Properties".
    *   In the "Application" tab, change the "Output type" from "Console Application" back to "Windows Application".
    *   Change the "Startup object" back to `Ubat_Tracker_V0._0.My.MyApplication`.
5.  **Save the project and you're done.**

## Authors

- [@Amir-Ridhwan (https://github.com/Amir-Ridhwan))

## Contributing

Contributions are always welcome!

See `contributing.md` for ways to get started.

Please adhere to this project's `code of conduct`.

## Deployment

To deploy this project, download the zipped file of the repository, uncompressed it.  install Microsoft Visual Studio Community 2022, install Microsoft SQL Express 2022 and finally install Microsoft SQL Server Management Studio. Open services.msc to ensure service called SQL Server (SQLEXPRESS) is running.

## Installation

To start the program, first we need to move the database file to the Microsoft SQL Server Management Studio directory. Find file name UBAT.mdf and UBAT.log. Copy it to directory >>This PC >> C: >> Program Files >> Microsoft SQL Server >> MSSQL16.SQLEXPRESS >> MSSQL >> DATA. Paste the files into DATA.

Start the Microsoft SQL Server Management Studio. Connect to Server name .\sqlexpress, use Windows Authentication, Encrypt Optional and click connect. On the left hand side, it should show Object Explorer. Right click on the folder Databases and click Attach....

It should pop up screen box which Databases to attach. Attach database UBAT.mdf and click button Add.

If errors called "restricted files" pop up at debugging console, go to File Explorer of the solution, find Login_Page.resx and right-click to open Properties. Uncheck the box that block the file. Do the same with Main_Dashboard.resx and Uncheck the box. Run again the program.  

## License

MIT License

Copyright (c)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Feedback

If you have any feedback, please reach out to us at amir2idhwan@gmail.com
