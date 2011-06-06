using RaccoonBlog.Web.Infrastructure.AutoMapper.Profiles.Resolvers;
using RaccoonBlog.Web.Infrastructure.Common;

namespace RaccoonBlog.Web.ViewModels
{
    public class PostReference
    {
        public string Id { get; set; }
        public string Title { get; set; }

        private int _domainId;
        public int DomainId
        {
            get
            {
                if (_domainId == 0)
                    _domainId = RavenIdResolver.Resolve(Id);
                return _domainId;
            }
        }

        private string _slug;
        public string Slug
        {
            get { return _slug ?? (_slug = SlugConverter.TitleToSlug(Title)); }
            set { _slug = value; }
        }
    }
}
