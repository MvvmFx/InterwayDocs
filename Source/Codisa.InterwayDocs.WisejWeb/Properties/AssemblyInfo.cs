using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Wisej.Core;

// Add the WisejResources attribute to 
// merge js and css embedded resources with the wisej package.
// [assembly: WisejResources(ExcludeList: "")]

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyCulture("en")]
[assembly: AssemblyTitle("Wisej Web UI for .NET 4.5")]
[assembly: AssemblyProduct("InterwayDocs")]
[assembly: AssemblyDescription("Wisej Web UI for .NET 4.5")]

// Make sure that you have this line uncommented
// so that your JavaScript file will be sent to the client
[assembly: WisejResources(ExcludeList: "")]