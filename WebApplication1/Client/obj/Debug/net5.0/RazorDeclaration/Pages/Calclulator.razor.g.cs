// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\_Imports.razor"
using WebApplication1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\_Imports.razor"
using WebApplication1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\Pages\Calclulator.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calculator")]
    public partial class Calclulator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 193 "C:\Users\Mzwandile\source\repos\WebApplication1\WebApplication1\Client\Pages\Calclulator.razor"
      

    Memory_ Calculation = new Memory_();

    string displayText = "";

    private async Task ChangeText(string number)
    {

        displayText += number;

        //await jsr.InvokeVoidAsync("alert", displayText);
    }

    private async Task EvaluateExpression()
    {
        var result = Evaluate(displayText);

        Calculation.Expression = displayText;
        Calculation.Result = Double.Parse(result);

        displayText = result;

        // await jsr.InvokeVoidAsync("alert", displayText);


    }

    private void Clear()
    {
        displayText = "";
    }

    private void ViewMemories()
    {
        navManager.NavigateTo("/memories");
    }

    private async Task Save()
    {
        await httpClient.PostAsJsonAsync("/api/memory",Calculation);
        //await jsr.InvokeVoidAsync("arlet", "Calculation saved");
    }

   






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
    }
}
#pragma warning restore 1591
