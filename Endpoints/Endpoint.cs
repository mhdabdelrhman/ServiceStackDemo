using ServiceStack;
using ServiceStackApp.Requests;
using System.Collections.Generic;
using System.Linq;

namespace ServiceStackApp.Endpoints
{
    public class Endpoint : Service
    {
        public string Get(AddNumbers request)
        {
            return request?.Sum;
        }

        public IEnumerable<object> Any(ListValues request)
        {
            if (request.Id != 0)
            {
                return new[] {
                    new { id = request.Id, Name = $"Value{request.Id}" }
                };
            }
            return new[] {
                new { id=1, Name="Value1" },
                new { id=2, Name="Value2" },
                new { id=3, Name="Value3" },
                new { id=4, Name="Value4" },
                new { id=5, Name="Value5" },
            };
        }
    }
}
