using System.Net;

namespace chubbExamen.Models.Generics
{
    public class ResponseAPI
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }

        public ResponseAPI()
        {

            ErrorMessages = new List<string>();
        }
    }
}
