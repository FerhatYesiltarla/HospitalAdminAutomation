using BLL.Service;

namespace WebApi.Service
{
    public sealed class DataService
    {
        private static readonly EntityService _service = new EntityService();

        public static EntityService Service
        {
            get
            {
                return _service;
            }
        }
    }
}