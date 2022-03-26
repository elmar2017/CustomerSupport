using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomerSupport.Extensions
{
    public static class ModelStateExtension
    {
        public static List<string> GetValidationErrors(this ModelStateDictionary modelState)
        {
            return modelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
        }
    }
}
