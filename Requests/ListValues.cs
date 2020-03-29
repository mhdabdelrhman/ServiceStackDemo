using ServiceStack;

namespace ServiceStackApp.Requests
{
    /*
     * http://localhost:61019/List
     * http://localhost:61019/List?format=json
     * http://localhost:61019/List?format=xml
     * http://localhost:61019/List?format=csv
     */
    [Route("/list/", "GET,POST")]
    [Route("/item/{id}", "GET,POST")]
    public class ListValues
    {
        public int Id { get; set; }
    }
}
