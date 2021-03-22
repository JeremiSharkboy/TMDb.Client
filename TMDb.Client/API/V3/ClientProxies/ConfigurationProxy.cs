using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Configuration;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class ConfigurationProxy : ApiProxy
    {
        public ConfigurationProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<ConfigurationResponse> GetConfigurationAsync() =>
            Client.SendAsync<ConfigurationResponse>(new ConfigurationRequest());

        public virtual Task<CountriesConfigurationResponse> GetCountriesConfigurationAsync() =>
            Client.SendAsync<CountriesConfigurationResponse>(new CountriesConfigurationRequest());

        public virtual Task<DepartmentJobsConfigurationResponse> GetDepartmentJobsAsync() =>
            Client.SendAsync<DepartmentJobsConfigurationResponse>(new DepartmentJobsConfigurationRequest());

        public virtual Task<LanguagesConfigurationResponse> GetLanguagesAsync() =>
            Client.SendAsync<LanguagesConfigurationResponse>(new LanguagesConfigurationRequest());

        public virtual Task<PrimaryTranslationsConfigurationResponse> GetPrimaryTranslationsAsync() =>
            Client.SendAsync<PrimaryTranslationsConfigurationResponse>(new PrimaryTranslationsConfigurationRequest());

        public virtual Task<TimezonesConfigurationResponse> GetTimezonesAsync() =>
            Client.SendAsync<TimezonesConfigurationResponse>(new TimezonesConfigurationRequest());
    }
}