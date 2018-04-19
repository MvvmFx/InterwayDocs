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

### Release mode build
When you build the solution in __Release__ mode, at the root level there will be 3 folders with ready to run versions:
- WinForms - Windows Forms desktop application
- WebSite - Wisej web site IIS ready
- WebStandalone - Wisej web site packed into a desktop .exe file

## Project Status

Project is ready to run using LocalDb for SQL Server 2014. Instructions included on how to use LocalDB for SQL Server 2012.

## Roadmap

### Release 1.3.7 (ongoing)
- Add Wisej standalone executable (run as a desktop application) - done
- Translate all resources in all 4 languages - done
- Add language combobox to Wisej version - done
- Fetch Wisej dependency from NuGet - done

__N.B. - To run Wisej samples (web and standalone) you don't need to install Wisej.__

### Release 1.3.8 (planned - last single user release)
- Load all translations from database

### Release 1.4.0 (planned)
- Add authentication, autorization and roles
- Add user management

## What is Wisej?

Take your WinForms project, port it to Wisej retaining all your BO/DAL code and most UI code.
Now run it as a Web application.
[Get Wisej](http://wisej.com)