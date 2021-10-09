# Eau Claire's Salon

#### An app to help manage stylist/client data for the salon

#### By Scott Hutley

## Technologies Used

* _C#_
* _.Net 5.0_
* _MSTest_
* _ASP.NET Core_
* _NuGet_

## Description

The aim of this app is to provide Claire with the ability to add stylists she has hired and assign them clients. If the client has been to Eau Claire's before, details from their last visit can also be entered as well as a contact number (if submitted by client) to be used for appointment reminders.

## Setup/Installation

#### Technology Requirements

* .NET 5
* VS Code or other text editor
* MySQL Workbench

#### Cloning and Database Creation

* Clone this repository to your desktop
* Open with text editor and navigate into HairSalon.Solution/HairSalon folder
* Create an appsettings.json file
* Add the following code to the appsettings.json:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=scott_hutley;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* Replace "YOUR_PASSWORD" in the above code with your own personal MySql password
* Open a Windows Powershell terminal (or Mac equivalent)
* In that terminal run *mysql -uroot -p<YOUR_PASSWORD>* (again, replacing with your actual password)
* Open MySQL Workbench
* In the *Navigator>Administration* window, select *Data Import/Restore*
* In *Import Options* select *Import from Self-Contained File*
* Navigate to scott_hutley.sql
* Under *Default Schema to be Imported To*, select *New* and enter scott_hutley as the name of the database
* Click *Ok*
* Navigate to the tab called *Import Progress* and click *Start Import* at the bottom right corner of the window
* Re-open the *Navigator>Schemas* tab
* Right-click and select *Refresh All* to ensure scott_hutley database now exists

*phew* Grab a quick snack, you're almost there!

* Return to your text editor
* Navigate to the HairSalon.Solution/HairSalon folder level (if you are not already there)
* Run *dotnet restore*
* Run *dotnet build*
* Run *dotnet run* to use the app!
(note: If dotnet run does not auto-generate a browser page, you can manually enter http://localhost:5000 into your web browser)

## Known Bugs

* _No know issues_

## License

_[MIT](https://opensource.org/licenses/MIT)_

Copywrite(c)2021 Scott Hutley

## Contact Information

Scott Hutley: scotthutley1@comcast.net