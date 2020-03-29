using ServiceStack;

namespace ServiceStackApp.Requests
{
    [Route("/add/{n1}/{n2}")]
    public class AddNumbers
    {
        public int N1 { get; set; }

        public int N2 { get; set; }

        public string Sum => $"{N1} + {N2} = {N1 + N2}";
    }
}
