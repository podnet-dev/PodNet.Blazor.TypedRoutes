namespace _9_RazorDeclarationDuplicatesPageDirective;

// Newer Razor compilers (observed with .NET SDK 11) make a declaration of the component, including its [Route]
// attributes, visible to other generators. The same routes then come from both the @page directives and the attributes.
[Microsoft.AspNetCore.Components.RouteAttribute("/person/{id:int}")]
[Microsoft.AspNetCore.Components.RouteAttribute("/person/{id:int}/edit")]
public partial class MyComponent;