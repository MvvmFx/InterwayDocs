# InterwayDocs - Sample MvvmFx WinForms/Wisej application

This application was developed as "freemium" application to replace mail register books, intended for absolute beginners in low-tech environments.

It was a desktop only application: no network, no server, no authentication. The missing features would exist only on the "premium" application.
Thanks to Codisa IT Solutions of Interway Group to release the code as open source.

The WinForms application was ported to Wisej. Since Wisej is a Web platform, authentication and authorization are badly needed and so is a more robust multilanguage system. Those missing bits must be (and will be) added.

This application uses an interesting environment:
- business layer uses [CSLA .NET](http://github.com/MarimerLLC/csla)
- business rules and date parser uses [CSLA .NET public contribution](http://github.com/MarimerLLC/cslacontrib)
- business layer code was generated using [CslaGenFork](http://github.com/CslaGenFork/CslaGenFork)
- UI uses [MvvmFx](http://github.com/MvvmFx/MvvmFx)

The project is instrumental for the improvement and maturity of MvvmFx.

## Project Status

Project is ready to run using LocalDb for SQL Server 2014. Instructions included on how to use LocalDB for SQL Server 2012.

The translation feature is ready but some translations are missing.

## Roadmap

### Version 1.3.7
- Add Wisej standalone executable (run as a desktop application) - done
- Translate all resources in all 4 languages - done
- Add language combobox to Wisej version. - done

#### When you build the solution in Release mode, there will be 3 folder
with ready to run versions:
- WebSite
- WebStandalone
- WinForms

### Version 1.3.8 (last single user release)
- Load all translations from database

### Version 1.4.0
- Add authentication, autorization and roles
- Add user management

## What is Wisej?

Take your WinForms project, port it to Wisej retaining all your BO/DAL code and most UI code.
Now run it as a Web application.
[Get Wisej](http://wisej.com)