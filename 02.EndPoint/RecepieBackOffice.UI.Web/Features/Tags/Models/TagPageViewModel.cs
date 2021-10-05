using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RecepieBackOffice.UI.Web.Features.Tags.Models
{
    public class TagPageViewModel : ITagPageViewModel
    {
        private readonly HttpClient client;

        public TagPageViewModel(HttpClient client)
        {

            this.client = client;

        }
        public List<Tag> Tags { get; set; }
        public TagListRequest TagListRequest { get; set; } = new TagListRequest("/api/tag/search");
        public Tag TagForSave { get; set; } = new Tag();

        public async Task InitializeViewModel()
        {
            Tags = await client.GetFromJsonAsync<List<Tag>>(TagListRequest.RequestUrl);
        }

        public async Task SaveTag()
        {
            if (TagForSave.Id != Guid.Empty)
            {
                var addTagRequest = new AddTagRequest("/api/tag");

                await client.PutAsJsonAsync(addTagRequest.RequestUrl, TagForSave);

            }
            else
            {
                var addTagRequest = new AddTagRequest("/api/tag");

                await client.PostAsJsonAsync(addTagRequest.RequestUrl, TagForSave);
                Tags = await client.GetFromJsonAsync<List<Tag>>(TagListRequest.RequestUrl);
            }

            TagForSave = new Tag();
        }
    }
}
