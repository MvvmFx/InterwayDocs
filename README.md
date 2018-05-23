# InterwayDocs - Sample MvvmFx Wisej/WinForms application

This application was developed as "freemium" application to replace mail register books, intended for absolute beginners in low-tech environments.

It was a desktop only application: no network, no server, no authentication. The missing features would exist only on the "premium" application.
Thanks to Codisa IT Solutions of Interway Group to release the code as open source.

The WinForms application was ported to Wisej. Since Wisej is a Web platform, authentication and authorization are badly needed and so is a more robust multilanguage system. Those missing bits must be (and will be) added.

This application uses an interesting environment:
- business layer uses [CSLA .NET](http://github.com/MarimerLLC/csla)
- business rules and date parser uses [CSLA .NET public contribution](http://github.com/MarimerLLC/cslacontrib)
- business layer code was generated using [CslaGenFork](http://github.com/CslaGenFork/CslaGenFork)
- UI uses [MvvmFx](http://github.com/MvvmFx/MvvmFx)

The project is instrumental for the improvement of [MvvmFx](https://github.com/MvvmFx/MvvmFx.

## Project Status

Project is ready to run using LocalDb for SQL Server 2014. Instructions included on how to use LocalDB for SQL Server 2012.

## News

### [Release 1.4.0](https://github.com/MvvmFx/InterwayDocs/milestone/3) (ongoing)
- Wisej multi page application
- Add authentication, autorization and roles
- Add user management

### [Release 1.3.8](https://github.com/MvvmFx/InterwayDocs/releases/tag/v1.3.8) (21 May 2018)
- Load all resources from database
- Wisej change language without reloading page
- Wisej disable change language by URL
- Wisej main menu looks like MDI
- Wisej alert when closing browser may loose unsaved information
- Fix sorting of fields on Excel reports
- Fix Excel reports on Wisej Standalone  

### [Release 1.3.7](https://github.com/MvvmFx/InterwayDocs/releases/tag/v1.3.7) (03 May 2018)
- Add Wisej standalone executable (run as a desktop application)
- Translate all resources in all 4 languages
- Add language combobox to Wisej version
- Fetch Wisej dependency from NuGet

__N.B. - Run Wisej samples (web and standalone) from [NuGet](https://www.nuget.org/packages/Wisej/) - you don't need to install Wisej.__

### Release mode build
When you build the solution in __Release__ mode, at the root level there will be an __Outputs__ folder.
On this folder there are 3 folders with ready to run versions:
- WebSite - Wisej web site IIS ready
- WebStandalone - Wisej web site packed into a desktop .exe file
- WinForms - Windows Forms desktop application

## What is Wisej?

Take your WinForms project, port it to Wisej retaining all your BO/DAL code and most UI code.
Now run it as a Web application.
[Get Wisej](http://wisej.com)

License
-------
InterwayDocs is copyright Grupo Interway and Tiago Freitas Leal.
Its use is governed by the [MIT license](https://github.com/MvvmFx/InterwayDocs/blob/master/LICENSE.md).
