using RecepieBackOffice.UI.Web.Features.Common;

namespace RecepieBackOffice.UI.Web.Features.Tags.Models
{
    public class AddTagRequest : BaseRequest
    {

        public AddTagRequest(string requestUrl) : base(requestUrl)
        {
        }
        public string Title { get; set; }
    }
}
