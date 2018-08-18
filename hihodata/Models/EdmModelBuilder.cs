using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;

namespace AlvaChien.HIH.OData.Models
{
    public static class EdmModelBuilder
    {
        private static IEdmModel _edmModel;

        public static IEdmModel GetEdmModel()
        {
            if (_edmModel == null)
            {
                var builder = new ODataConventionModelBuilder();
                builder.EntitySet<Movie>("Movies");
                builder.EntitySet<DBVersion>("DBVersion");
                _edmModel = builder.GetEdmModel();
            }

            return _edmModel;
        }
    }
}
