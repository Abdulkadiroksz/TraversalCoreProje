using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.View_Components.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
