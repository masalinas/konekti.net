using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Konekti.Framework.Plugins;

// La información general sobre un ensamblado se controla mediante el siguiente 
// conjunto de atributos. Cambie estos atributos para modificar la información
// asociada con un ensamblado.
[assembly: AssemblyTitle("Konekti.Plugin.MessageManager")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("UNDERGROUND")]
[assembly: AssemblyProduct("Konekti.Plugin.MessageManager")]
[assembly: AssemblyCopyright("© UNDERGROUND 2007")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Si establece ComVisible como false hace que los tipos de este ensamblado no sean visibles 
// a los componentes COM. Si necesita obtener acceso a un tipo en este ensamblado desde 
// COM, establezca el atributo ComVisible como true en este tipo.
[assembly: ComVisible(false)]

// El siguiente GUID sirve como identificador de la biblioteca de tipos si este proyecto se expone a COM
[assembly: Guid("6c01a05e-57f0-40de-97eb-25772882d5ba")]

// La información de versión de un ensamblado consta de los cuatro valores siguientes:
//
//      Versión principal
//      Versión secundaria 
//      Número de versión de compilación
//      Revisión
//
// Puede especificar todos los valores o puede establecer como valores predeterminados los números de revisión y generación 
// mediante el asterisco ('*'), como se muestra a continuación:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: PluginExportedFromAssemblyAttribute(typeof(Konekti.Plugin.MessageManager.frmMessageDockPanel))]