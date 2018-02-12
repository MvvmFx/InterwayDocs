# InterwayDocs - Sample MvvmFx WinForms/Wisej application

This application was developed as "freemium" application to replace mail register books, intended for absolute beginners in low-tech environments.

It was a desktop only application: no network, no server, no authentication. The missing features would exist only on the "premium" application.
Thanks to Codisa IT Solutions of Interway Group to release the code as open source.

The WinFormns application was ported to since Wisej is a Web platform, the missing bits must be (and will be) added.

This application uses an interesting environment:
- business layer uses [CSLA .NET](http://github.com/MarimerLLC/csla)
- business rules and date parser uses [CSLA .NET public contribution](http://github.com/MarimerLLC/cslacontrib)
- business layer code was generated using [CslaGenFork](https://github.com/CslaGenFork/CslaGenFork)
- UI uses [MvvmFx](https://github.com/MvvmFx/MvvmFx)

The project was instrumental for the improvement and maturity of MvvmFx.
