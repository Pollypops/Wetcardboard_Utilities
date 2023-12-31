using Microsoft.AspNetCore.Components;

namespace Wetcardboard_Components.Ui
{
    public partial class CustButton
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
